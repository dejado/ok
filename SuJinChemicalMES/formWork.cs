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

namespace SuJinChemicalMES
{
    public partial class formWork : Form
    {

        private string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
        private Timer timer;

        public formWork()
        {
            InitializeComponent();

            LoadImageFromDatabase();
            InitializeTimer();
        }

        private void formWork_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;


        }
        
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; // 5초 간격으로 설정 (원하는 간격으로 수정 가능)
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        public void LoadImageFromDatabase()
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>
        {pictureBox5, pictureBox4, pictureBox3, pictureBox2, pictureBox1, pictureBox6 };

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImageFromDatabase();
        }

    }
}
