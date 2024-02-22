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
        private formBath bath;

        public formWork()
        {
            InitializeComponent();

            LoadImageFromDatabase();
            InitializeTimer();



        }
        private void InitializePictureBoxEvents(int pictureBoxIndex)
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>
            {bath1, bath2, bath3, bath4, bath5, bath6 };

            // PictureBoxIndex에 해당하는 PictureBox에만 이벤트 핸들러를 추가합니다.
            pictureBoxList[pictureBoxIndex].MouseEnter += PictureBox_MouseEnter;
            pictureBoxList[pictureBoxIndex].MouseLeave += PictureBox_MouseLeave;
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            // PictureBox 위에 마우스가 올라갈 때 실행되는 코드
            PictureBox pictureBox = (PictureBox)sender;
            OpenBathForm(pictureBox.Name);
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            // PictureBox에서 마우스가 빠져나갈 때 실행되는 코드
            CloseBathForm();
        }
        private void OpenBathForm(string pictureBoxName)
        {
            // 이미 열려 있는지 확인
            if (bath == null || bath.IsDisposed)
            {
                // 폼이 열려있지 않으면 새로운 인스턴스 생성 및 열기
                bath = new formBath();
                bath.Text = "Form for " + pictureBoxName; // 예시로 폼의 타이틀을 설정
                string fifthCharacter = pictureBoxName[4].ToString();
                bath.SetSecondCharacter(fifthCharacter);
                bath.Show();
            }
            else if (!bath.Visible) // Check if the form is not visible (closed)
            {
                // 이미 열려 있는 경우 해당 폼을 다시 표시
                bath.Text = "Form for " + pictureBoxName;
                string fifthCharacter = pictureBoxName[4].ToString();
                bath.SetSecondCharacter(fifthCharacter);
                bath.Show();
            }
            else
            {
                // 이미 열려 있는 경우 해당 폼을 활성화
                bath.Activate();
            }
        }

        private void CloseBathForm()
        {
            // FormBath가 열려있을 경우 닫습니다.
            if (bath != null && !bath.IsDisposed)
            {
                bath.Close();
            }
        }



        private void formWork_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;


        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 5000; // 5초 간격으로 설정 (원하는 간격으로 수정 가능)
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        public void LoadImageFromDatabase()
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>
            {bath1, bath2, bath3, bath4, bath5, bath6 };
            List <int>bath=new List <int>();
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
                                    bath.Add(secondCharacterAsInt-1);
                                }
                                else
                                {
                                    MessageBox.Show("변환 실패");
                                }
                            }

                            SetPictureBoxImage(pictureBoxList[secondCharacterAsInt - 1], chemicalType);
                            InitializePictureBoxEvents(secondCharacterAsInt - 1);
                            
                        }
                    }
                    DefaultImage(bath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로드 중 오류 발생: " + ex.Message);
            }
        }
        private void DefaultImage(List <int>bath)
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>
            { bath1, bath2, bath3, bath4, bath5, bath6 };

            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                if (!bath.Contains(i))
                {
                    pictureBoxList[i].Image = Properties.Resources.tankzak5_6;
                }
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
                default:
                    pictureBox.Image = Properties.Resources.tankak4;
                    break;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImageFromDatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
