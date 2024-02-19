using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuJinChemicalMES
{
    public partial class formWork : Form
    {

        private string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
        private Timer timer;

        public formWork()
        {
            InitializeComponent();

            //LoadImageFromDatabase();
            //InitializeTimer();
        }

        private void formWork_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;



        }
        /*
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; // 5초 간격으로 설정 (원하는 간격으로 수정 가능)
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        public void LoadImageFromDatabase()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // MySQL 쿼리 작성
                    string query = "SELECT beth_number, chemical_type FROM beth_operation_status";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string bethNumber = reader["beth_number"].ToString();
                                string chemicalType = reader["chemical_type"].ToString();
                                string resourceName = "";

                                // 베스 번호에 따라 리소스 이름 선택
                                if (bethNumber == "베스1호")
                                {
                                    resourceName = "SuJinChemicalMES.Properties.Resources.tankak4";
                                    // 리소스 파일에서 이미지 가져오기
                                    //pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                                    pictureBox5.Image = Properties.Resources.tankak4;

                                }
                                if (bethNumber == "베스2호")
                                {
                                    resourceName = "SuJinChemicalMES.Properties.Resources.tamk02";
                                    // 리소스 파일에서 이미지 가져오기
                                    //pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                                    pictureBox4.Image = Properties.Resources.tankam4;
                                }
                                if (bethNumber == "베스3호")
                                {
                                    resourceName = "SuJinChemicalMES.Properties.Resources.tamk02";
                                    // 리소스 파일에서 이미지 가져오기
                                    //pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                                    pictureBox3.Image = Properties.Resources.tankbs4;
                                }
                                if (bethNumber == "베스4호")
                                {
                                    resourceName = "SuJinChemicalMES.Properties.Resources.tamk02";
                                    // 리소스 파일에서 이미지 가져오기
                                    //pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                                    pictureBox2.Image = Properties.Resources.tankgs4;
                                }
                                if (bethNumber == "베스5호")
                                {
                                    resourceName = "SuJinChemicalMES.Properties.Resources.tamk02";
                                    // 리소스 파일에서 이미지 가져오기
                                    //pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                                    pictureBox1.Image = Properties.Resources.tankhs4;
                                }
                                if (bethNumber == "베스6호")
                                {
                                    resourceName = "SuJinChemicalMES.Properties.Resources.tamk02";
                                    // 리소스 파일에서 이미지 가져오기
                                    //pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                                    pictureBox6.Image = Properties.Resources.tankjs4;
                                }

                                if (pictureBox5.Image == null)
                                {
                                    MessageBox.Show($"베스 번호 '{bethNumber}'에 해당하는 이미지 파일이 로드되지 않았습니다.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로드 중 오류 발생: " + ex.Message);
            }
        }
        */
    }
}
