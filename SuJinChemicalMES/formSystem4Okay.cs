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
    public partial class formSystem4Okay : Form
    {
        public formSystem4Okay()
        {
            InitializeComponent();
        }

        private void formSystem4Okay_Load(object sender, EventArgs e)
        {
            DisplayUserData();
            //폼시작시 목록 채워놓기
        }

        int check_id = 0;

        //사용자 등록 - 중복체크
        private void ID_Check()
        {
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
            con.Open();

            string CompQuery_Id = "SELECT COUNT(*) as cnt FROM user_registration WHERE id = @ID";

            using (MySqlCommand com = new MySqlCommand(CompQuery_Id, con))
            {
                com.Parameters.AddWithValue("@ID", UserID_tb.Text);

                using (MySqlDataReader CompReader_Id = com.ExecuteReader())
                {

                    while (CompReader_Id.Read())
                    {
                        int count = Convert.ToInt32(CompReader_Id["cnt"]);

                        if (count != 0)
                            IDCheck_lb.Text = "중복된 아이디입니다.";

                        else
                        {
                            check_id = 1;
                        }
                    }

                }
            }
            con.Close();
        }

        //사용자 등록 - 입력
        private void UserRegistration_bt_Click(object sender, EventArgs e)
        {
            if (UserName_tb.Text == "")
            {
                MessageBox.Show("이름은 필수 입력사항입니다.", "미작성 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserName_tb.Focus();
            }
            else if (UserID_tb.Text == "")
            {
                MessageBox.Show("ID는 필수 입력사항입니다.", "미작성 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserID_tb.Focus();
            }
            else if (UserPW_tb.Text == "")
            {
                MessageBox.Show("PW는 필수 입력사항입니다.", "미작성 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserPW_tb.Focus();
            }

            else
            {
                ID_Check();

                if (check_id == 1)
                {
                    try
                    {
                        string name = UserName_tb.Text;
                        string id = UserID_tb.Text;
                        string password = UserPW_tb.Text;
                        string department = UserDepartment_tb.Text;
                        string user_rank = UserRank_tb.Text;

                        MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
                        con.Open();

                        string insertQuery = "INSERT INTO user_registration (name, id, password, department, user_rank) VALUES (\'" + name + "\',\'" + id + "\',\'" + password + "\',\'" + department + "\',\'" + user_rank + "\')";
                        //데이터베이스 쿼리 선택

                        MySqlCommand com = new MySqlCommand(insertQuery, con);


                        if (com.ExecuteNonQuery() == 1)
                        {

                            UserName_tb.Clear();
                            UserID_tb.Clear();
                            UserPW_tb.Clear();
                            UserDepartment_tb.Clear();
                            UserRank_tb.Clear();

                            con.Close();
                            //데이터베이스 연결 닫음
                        }
                        else
                        {
                            MessageBox.Show("다시 확인해주세요.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                RegiUserList_dgv.DataSource = null;
                DisplayUserData();
            }
        }

        private void DisplayUserData()
        {
            //데이터그리드뷰 출력
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
            con.Open();

            string DisplayQuery = "SELECT * FROM user_registration ORDER BY department";
            MySqlCommand com = new MySqlCommand(DisplayQuery, con);

            MySqlDataAdapter adapterDT = new MySqlDataAdapter(com);
            DataTable userDT = new DataTable();
            //어뎁터 이용해서 끌어오기
            adapterDT.Fill(userDT);

            // 기존에 설정된 컬럼들을 유지하고 새로운 데이터로 채우기 위해 Clear() 메서드 사용
            RegiUserList_dgv.Columns.Clear();
            RegiUserList_dgv.DataSource = userDT;

            // DataGridView의 컬럼 이름을 MySQL의 칼럼 이름으로 변경
            foreach (DataGridViewColumn column in RegiUserList_dgv.Columns)
            {
                switch (column.HeaderText)
                {
                    case "name":
                        column.HeaderText = "이름";
                        break;
                    case "id":
                        column.HeaderText = "아이디";
                        break;
                    case "password":
                        column.HeaderText = "비밀번호";
                        break;
                    case "department":
                        column.HeaderText = "부서";
                        break;
                    case "user_rank":
                        column.HeaderText = "직급";
                        break;
                    // 추가적인 컬럼 이름 변경이 필요한 경우 여기에 추가
                    default:
                        break;
                }
            }

            con.Close();
        }


    }
}
