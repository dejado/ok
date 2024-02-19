using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Calendar.NET;
using System.Windows.Forms.DataVisualization.Charting;

namespace SuJinChemicalMES
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            Main_tlpn.Dock = DockStyle.Fill;
            //메인 패널
            Mainright_tlpn.Dock = DockStyle.Fill;
            //캘린더와 일일달성도 구분 패널
            Calendar_pn.Dock = DockStyle.Fill;
            CalendarControl_pn.Dock = DockStyle.Fill;
            Calendar_cal.Dock = DockStyle.Fill;

            AddCalendar();
            // 폼이 생성될 때 캘린더 호출
            AddChart();
            LoadImageFromDatabase();
            InitializeTimer();
        }

        string CalendarPickDay_st;

        private void formMain_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            Initialize_Calendar_dtp();


            CalendarPickDay_st = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void AddCalendar()
        {
            Calendar_cal.CalendarDate = DateTime.Now;
            Calendar_cal.CalendarView = CalendarViews.Month;
            Calendar_cal.LoadPresetHolidays = false;
            Calendar_cal.AllowEditingEvents = true;
            CalendarLoad();
            CalendarLoad2();
            //캘린더 현재 날짜로 초기 설정
        }

        //납기일
        private void CalendarLoad()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = accumulated_data; User id = team; Password = team1234");
                //SQL 서버와 연결, database=스키마 이름
                con.Open();
                //SQL 서버 연결

                string Query = "SELECT * FROM accumulated_data WHERE progress = '발주서등록'";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);
                MySqlDataReader reader = com.ExecuteReader();

                HashSet<string> printData = new HashSet<string>();
                //중복제거 데이터

                while (reader.Read())
                {
                    String printName = reader["supplier"].ToString();
                    DateTime printDate = reader.GetDateTime("due_date_request");
                    string SynData = printName + printDate.ToString();

                    if (!printData.Contains(SynData))
                    {
                        printData.Add(SynData);

                        var exerciseEvent = new CustomEvent
                        {
                            Date = printDate,
                            EventText = printName,
                            IgnoreTimeComponent = false,
                            EventColor = Color.Red,
                        };

                        Calendar_cal.AddEvent(exerciseEvent);
                    }
                }
                reader.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //입고일
        private void CalendarLoad2()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = accumulated_data; User id = team; Password = team1234");
                //SQL 서버와 연결, database=스키마 이름
                con.Open();
                //SQL 서버 연결

                string Query = "SELECT * FROM accumulated_data WHERE progress = '입고'";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);
                MySqlDataReader reader = com.ExecuteReader();

                HashSet<string> printData = new HashSet<string>();
                //중복제거 데이터

                while (reader.Read())
                {
                    String printName = reader["company"].ToString();
                    DateTime printDate = reader.GetDateTime("registration_date");
                    string SynData = printName + printDate.ToString();

                    if (!printData.Contains(SynData))
                    {
                        printData.Add(SynData);

                        var exerciseEvent = new CustomEvent
                        {
                            Date = printDate,
                            EventText = printName,
                            IgnoreTimeComponent = false,
                            EventColor = Color.CadetBlue,
                        };

                        Calendar_cal.AddEvent(exerciseEvent);
                    }
                }
                reader.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Initialize_Calendar_dtp()
        {
            Calendar_dtp.CustomFormat = "yyyy-MM-dd";
            //데이터타임피커 형식지정
        }

        private void Calendar_dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime cal_dt = Calendar_dtp.Value;
            Calendar_cal.CalendarDate = cal_dt;

            CalendarPickDay_st = Calendar_dtp.Value.ToString("yyyy-MM-dd");
            //데이터타임피커로 날짜 픽, Okay로 전달
            AddChart();
        }

        private void CalendarPick_bt_Click(object sender, EventArgs e)
        {
            formMainOkay mok = new formMainOkay(CalendarPickDay_st);
            mok.CalendarPick_st = CalendarPickDay_st;
            mok.Show();
        }

        private void AddChart()
        {
            Achieve_ct.Series["PlanSum_s"].Points.Clear();
            Achieve_ct.Series["CompleteSum_s"].Points.Clear();
            Achieve_ct.Series["CompleteRate_s"].Points.Clear();

            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = accumulated_data; User id = team; Password = team1234");
            //SQL 서버와 연결, database=스키마 이름
            con.Open();
            //SQL 서버 연결.

            string Query = "SELECT A.supplier, A.quantity, B.production_plan_quantity FROM ((SELECT SUM(quantity) AS quantity, supplier FROM accumulated_data WHERE registration_date = @baseday_dt AND progress = '생산완료' GROUP BY supplier) A, (SELECT SUM(production_plan_quantity) AS production_plan_quantity, supplier FROM accumulated_data WHERE scheduled_production_date = @baseday_dt AND progress = '생산계획등록' GROUP BY supplier) B) WHERE A.supplier = B.supplier";
            //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
            MySqlCommand com = new MySqlCommand(Query, con);
            com.Parameters.AddWithValue("@baseday_dt", CalendarPickDay_st);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string supplier = reader.GetString(0);
                int planQuantity = reader.GetInt32(2);
                int completeQuantity = reader.GetInt32(1);
                double completeRate = (completeQuantity * 100.0 / planQuantity);

                Achieve_ct.Series["PlanSum_s"].Points.AddXY(supplier, planQuantity);
                Achieve_ct.Series["CompleteSum_s"].Points.AddXY(supplier, completeQuantity);
                Achieve_ct.Series["CompleteRate_s"].Points.AddXY(supplier, completeRate);

                Achieve_ct.Series["CompleteRate_s"].Color = Color.Red;
                Achieve_ct.Series["CompleteRate_s"].BorderWidth = 2;

                Achieve_ct.ChartAreas[0].AxisY2.Minimum = 0;
                Achieve_ct.ChartAreas[0].AxisY2.Maximum = 100;

                Achieve_ct.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                Achieve_ct.ChartAreas[0].AxisY2.MajorGrid.LineColor = Color.LightGray;
                Achieve_ct.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DimGray;

                Achieve_ct.ChartAreas[0].AxisY.Title = "수량(개)";
                Achieve_ct.ChartAreas[0].AxisY2.Title = "생산 달성률(%)";
            }
            reader.Close();
            con.Close();
        }

        private void Main_tlpn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMoni_lb_Click(object sender, EventArgs e)
        {

        }
        private Timer timer;
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; // 5초 간격으로 설정 (원하는 간격으로 수정 가능)
            timer.Tick += timer1_Tick_1;
            timer.Start();
        }

        public void LoadImageFromDatabase()
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>
        {pictureBox5, pictureBox4, pictureBox3, pictureBox2, pictureBox1, pictureBox6 };
            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT bath_num, medicine_type FROM bath";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bethNumber = reader["bath_num"].ToString();
                            string chemicalType = reader["medicine_type"].ToString();

                            int secondCharacterAsInt = 0;

                            if (!string.IsNullOrEmpty(bethNumber) && bethNumber.Length >= 2)
                            {
                                char secondCharacter = bethNumber[2];

                                if (int.TryParse(secondCharacter.ToString(), out int result))
                                {
                                    secondCharacterAsInt = result;
                                }
                                else
                                {
                                    MessageBox.Show("변환 실패");
                                }
                            }

                            SetPictureBoxImage(pictureBoxList[secondCharacterAsInt - 1], chemicalType);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로드 중 오류 발생: " + ex.Message);
            }
        }
        private void SetPictureBoxImage(PictureBox pictureBox, string chemicalType)
        {
            switch (chemicalType)
            {
                case "인산(H3PO4)":
                    pictureBox.Image = Properties.Resources.tankak4;
                    break;
                case "암모니아(NH4OH)":
                    pictureBox.Image = Properties.Resources.tankam4;
                    break;
                case "황산(H2SO4)":
                    pictureBox.Image = Properties.Resources.tankbs4;
                    break;
                case "과산화수소(H2O2)":
                    pictureBox.Image = Properties.Resources.tankgs4;
                    break;
                case "불산(HF)":
                    pictureBox.Image = Properties.Resources.tankhs4;
                    break;
                case "질산(NHO3)":
                    pictureBox.Image = Properties.Resources.tankis4;
                    break;
                case "알코올(Iso Propyl Alchol)":
                case "알카리":
                    pictureBox.Image = Properties.Resources.tankjs4;
                    break;
                case "염산(HCl)":
                case "염산":
                    pictureBox.Image = Properties.Resources.tankys4;
                    break;
                    // 다른 경우에 대한 처리도 추가 가능
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LoadImageFromDatabase();
        }
    }
}