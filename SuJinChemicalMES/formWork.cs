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
            timer.Interval = 500; // 5초 간격으로 설정 (원하는 간격으로 수정 가능)
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        public void LoadImageFromDatabase()
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>
        {bath1, bath2, bath3, bath4, bath5, bath6 };

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
                            InitializePictureBoxEvents(secondCharacterAsInt - 1);

                        }
                    }
                }
                //bathTimer1.Start();
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
                    tankak4.Start();
                    bathH(pictureBox);
                    if (count > 40) { break; }
                    break;
                case "암모니아(NH4OH)":
                    tankam4.Start();
                    bathN(pictureBox);
                    if (count2 > 40) { break; }
                    break;
                case "황산(H2SO4)":
                    tankbs4.Start();
                    if (count2 > 40) { break; }
                    break;
                case "과산화수소(H2O2)":
                    pictureBox.Image = Properties.Resources.tankgs4;
                    break;
                case "불산(HF)":
                    //pictureBox.Image = Properties.Resources.tankhs4;
                    tankak4.Start();
                    bathT(pictureBox);
                    if (count > 40) { break; }
                    //bathTimer1.Stop();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        //보라_tankak4_인산(H3PO4) 
        int b = 0;
        int count = 0;
        private void bathTimer1_Tick(object sender, EventArgs e)
        {
            count++;

        }
        private void bathH(PictureBox pictureBox)
        {

            if (count <= 10)
            {
                pictureBox.Image = Properties.Resources.tankzak4_1;
                if (b >= 1)
                {
                    bath1.Image = Properties.Resources.tamk02;
                    b = 0;
                }
                else b++;
            }
            else if (count <= 20)
            {
                pictureBox.Image = Properties.Resources.tankzak4_1;
                if (b >= 1)
                {
                    bath1.Image = Properties.Resources.tankzak4_2;
                    b = 0;
                }
                else b++;
            }
            else if (count <= 30)
            {
                pictureBox.Image = Properties.Resources.tankzak4_2;
                if (b >= 1)
                {
                    bath1.Image = Properties.Resources.tankzak4_3;
                    b = 0;
                }
                else b++;
            }
            else if (count <= 40)
            {
                pictureBox.Image = Properties.Resources.tankzak4_3;
                if (b >= 1)
                {
                    bath1.Image = Properties.Resources.tankzak4_4;
                    b = 0;
                }
                else b++;
            }
            else pictureBox.Image = Properties.Resources.tankzak4_4;
        }


        //노란_tankam4_암모니아(NH4OH)  
        int b2 = 0;
        int count2 = 0;
        private void bathTimer2_Tick(object sender, EventArgs e)
        {
            count2++;

        }

        public void bathN(PictureBox pictureBox)
        {
            if (count2 <= 10)
            {
                pictureBox.Image = Properties.Resources.tankam4_1;
                if (b2 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tamk02;
                    b2 = 0;
                }
                else b2++;
            }
            else if (count2 <= 20)
            {
                pictureBox.Image = Properties.Resources.tankam4_1;
                if (b2 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tankam4_2;
                    b2 = 0;
                }
                else b2++;
            }
            else if (count2 <= 30)
            {
                pictureBox.Image = Properties.Resources.tankam4_2;
                if (b2 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tankam4_3;
                    b2 = 0;
                }
                else b2++;
            }
            else if (count2 <= 40)
            {
                pictureBox.Image = Properties.Resources.tankam4_3;
                if (b2 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tankam4_4;
                    b2 = 0;
                }
                else b2++;
            }
            else pictureBox.Image = Properties.Resources.tankam4_4;
        }

        //하얀_tankbs4_황산(H2SO4)
        int b3 = 0;
        int count3 = 0;
        private void tankbs4_Tick(object sender, EventArgs e)
        {
            count3++;
            
        }
        public void bathT(PictureBox pictureBox)
        {
            if (count3 <= 10)
            {
                pictureBox.Image = Properties.Resources.tankbs4_1;
                if (b3 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tamk02;
                    b3 = 0;
                }
                else b3++;
            }
            else if (count3 <= 20)
            {
                pictureBox.Image = Properties.Resources.tankbs4_1;
                if (b3 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tankbs4_2;
                    b3 = 0;
                }
                else b3++;
            }
            else if (count3 <= 30)
            {
                pictureBox.Image = Properties.Resources.tankbs4_2;
                if (b3 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tankbs4_3;
                    b3 = 0;
                }
                else b3++;
            }
            else if (count3 <= 40)
            {
                pictureBox.Image = Properties.Resources.tankbs4_3;
                if (b3 >= 1)
                {
                    pictureBox.Image = Properties.Resources.tankbs4_4;
                    b3 = 0;
                }
                else b3++;
            }
            else pictureBox.Image = Properties.Resources.tankbs4_4;
        }
        private void tankgs4_Tick(object sender, EventArgs e)
        {

        }

        private void bath1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bath5_Click(object sender, EventArgs e)
        {

        }

        private void bath2_Click(object sender, EventArgs e)
        {

        }

        private void bath3_Click(object sender, EventArgs e)
        {

        }

        private void bath6_Click(object sender, EventArgs e)
        {

        }

        private void bath4_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {

        }
    }
}
