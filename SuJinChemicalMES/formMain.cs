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

namespace SuJinChemicalMES
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

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
            //캘린더 현재 날짜로 초기 설정
        }

        public void CalendarLoad()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
                //SQL 서버와 연결, database=스키마 이름
                con.Open();
                //SQL 서버 연결

                string Query = "SELECT * FROM oder_registration";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);
                MySqlDataReader reader = com.ExecuteReader();

                HashSet<string> printData = new HashSet<string>();
                //중복제거 데이터

                while (reader.Read())
                {
                    String printName = reader["supplier"].ToString() + ", " + reader["product_name"].ToString();
                    DateTime printDate = Convert.ToDateTime(reader["due_date"]);
                    string SynData = printName + printDate.ToString();

                    if (!printData.Contains(SynData))
                    {
                        printData.Add(SynData);

                        var exerciseEvent = new CustomEvent
                        {
                            Date = printDate,
                            EventText = printName,
                            IgnoreTimeComponent = false,
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


    }
}
