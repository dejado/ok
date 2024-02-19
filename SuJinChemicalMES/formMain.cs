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
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            Initialize_Calendar_dtp();
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

                string Query = "SELECT * FROM accumulated_data WHERE progress_status = '발주서등록'";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);
                MySqlDataReader reader = com.ExecuteReader();

                HashSet<string> printData = new HashSet<string>();
                //중복제거 데이터

                while (reader.Read())
                {
                    String printName = reader["delivery_destination"].ToString() + ", " + reader["product_name"].ToString();
                    DateTime printDate = Convert.ToDateTime(reader["due_date_request"]);
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

                string Query = "SELECT * FROM accumulated_data WHERE progress_status = '입고'";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);
                MySqlDataReader reader = com.ExecuteReader();

                HashSet<string> printData = new HashSet<string>();
                //중복제거 데이터

                while (reader.Read())
                {
                    String printName = reader["delivery_destination"].ToString() + ", " + reader["product_name"].ToString();
                    DateTime printDate = Convert.ToDateTime(reader["registration_date"]);
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

        string CalendarPickDay_st = DateTime.Now.ToString("yyyyMMdd");

        private void Calendar_dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime cal_dt = Calendar_dtp.Value;
            Calendar_cal.CalendarDate = cal_dt;

            CalendarPickDay_st = Calendar_dtp.Value.ToString("yyyyMMdd");
            //데이터타임피커로 날짜 픽, Okay로 전달
        }

        private void CalendarPick_bt_Click(object sender, EventArgs e)
        {
            formMainOkay mok = new formMainOkay(CalendarPickDay_st);
            mok.CalendarPick_st = CalendarPickDay_st;
            mok.Show();
        }

        private void AddChart()
        {
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = accumulated_data; User id = team; Password = team1234");
            //SQL 서버와 연결, database=스키마 이름
            con.Open();
            //SQL 서버 연결

            DateTime base_day = DateTime.Now;
            string baseday_st = base_day.ToString("yyyy-MM-dd");
            DateTime baseday_dt = Convert.ToDateTime(baseday_st);

            string Query = "SELECT A.delivery_destination, A.quantity, B.production_plan_quantity FROM ( (SELECT SUM(quantity) AS quantity, delivery_destination FROM accumulated_data WHERE registration_date = @baseday_dt AND progress_status = '생산완료' GROUP BY delivery_destination) A, (SELECT SUM(production_plan_quantity) AS production_plan_quantity, delivery_destination FROM accumulated_data WHERE scheduled_production_date = @baseday_dt AND progress_status = '생산계획등록' GROUP BY delivery_destination) B) WHERE A.delivery_destination = B.delivery_destination";
            //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
            MySqlCommand com = new MySqlCommand(Query, con);
            com.Parameters.AddWithValue("@baseday_dt", baseday_dt);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string deliveryDestination = reader.GetString(0);
                int planQuantity = reader.GetInt32(2);
                int completeQuantity = reader.GetInt32(1);
                double completeRate = (completeQuantity * 100.0 / planQuantity);

                Achieve_ct.Series["PlanSum_s"].Points.AddXY(deliveryDestination, planQuantity);
                Achieve_ct.Series["CompleteSum_s"].Points.AddXY(deliveryDestination, completeQuantity);
                Achieve_ct.Series["CompleteRate_s"].Points.AddXY(deliveryDestination, completeRate);

                Achieve_ct.Series["CompleteRate_s"].Color = Color.Red;

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
        
    }
}
