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
    public partial class formSystem4 : Form
    {
        public formSystem4()
        {
            InitializeComponent();
        }

        private void formSystem4_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadDataFromMySQL();
        }
        private void LoadDataFromMySQL()
        {
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
            con.Open();

            string SelectQuery = "SELECT * FROM user_registration WHERE 1 = 1";

            if (!string.IsNullOrEmpty(CheUserName_tb.Text))
            {
                SelectQuery += $" AND name LIKE '%{CheUserName_tb.Text}%'";
            }

            if (!string.IsNullOrEmpty(CheUserDepartment_tb.Text))
            {
                SelectQuery += $" AND department LIKE '%{CheUserDepartment_tb.Text}%'";
            }

            if (!string.IsNullOrEmpty(CheUserRank_tb.Text))
            {
                SelectQuery += $" AND user_rank LIKE '%{CheUserRank_tb.Text}%'";
            }

            if (!string.IsNullOrEmpty(CheUserID_tb.Text))
            {
                SelectQuery += $" AND id LIKE '%{CheUserID_tb.Text}%'";
            }

            bool hasResult = false;

            MySqlCommand com = new MySqlCommand(SelectQuery, con);
            MySqlDataReader reader = com.ExecuteReader();

            UserList_dgv.Rows.Clear();

            while (reader.Read())
            {
                hasResult = true;

                int i = UserList_dgv.Rows.Add();

                UserList_dgv.Rows[i].Cells[0].Value = false;

                UserList_dgv.Rows[i].Cells[1].Value = reader["name"].ToString();
                UserList_dgv.Rows[i].Cells[2].Value = reader["id"].ToString();
                UserList_dgv.Rows[i].Cells[3].Value = reader["password"].ToString();
                UserList_dgv.Rows[i].Cells[4].Value = reader["department"].ToString();
                UserList_dgv.Rows[i].Cells[5].Value = reader["user_rank"].ToString();
            }

            if (!hasResult)
            {
                MessageBox.Show("조건에 해당하는 데이터가 없습니다.", "조회오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();

            CheUserName_tb.Clear();
            CheUserDepartment_tb.Clear();
            CheUserID_tb.Clear();
            CheUserRank_tb.Clear();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            formSystem4Okay u_r = new formSystem4Okay();
            u_r.ShowDialog(this);
        }

        private void UserCheck_bt_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
            con.Open();

            string SelectQuery = "SELECT * FROM user_registration WHERE 1 = 1";

            if (!string.IsNullOrEmpty(CheUserName_tb.Text))
            {
                SelectQuery += $" AND name LIKE '%{CheUserName_tb.Text}%'";
            }

            if (!string.IsNullOrEmpty(CheUserDepartment_tb.Text))
            {
                SelectQuery += $" AND department LIKE '%{CheUserDepartment_tb.Text}%'";
            }

            if (!string.IsNullOrEmpty(CheUserRank_tb.Text))
            {
                SelectQuery += $" AND user_rank LIKE '%{CheUserRank_tb.Text}%'";
            }

            if (!string.IsNullOrEmpty(CheUserID_tb.Text))
            {
                SelectQuery += $" AND id LIKE '%{CheUserID_tb.Text}%'";
            }

            bool hasResult = false;

            MySqlCommand com = new MySqlCommand(SelectQuery, con);
            MySqlDataReader reader = com.ExecuteReader();

            UserList_dgv.Rows.Clear();

            while (reader.Read())
            {
                hasResult = true;

                int i = UserList_dgv.Rows.Add();

                UserList_dgv.Rows[i].Cells[0].Value = false;

                UserList_dgv.Rows[i].Cells[1].Value = reader["name"].ToString();
                UserList_dgv.Rows[i].Cells[2].Value = reader["id"].ToString();
                UserList_dgv.Rows[i].Cells[3].Value = reader["password"].ToString();
                UserList_dgv.Rows[i].Cells[4].Value = reader["department"].ToString();
                UserList_dgv.Rows[i].Cells[5].Value = reader["user_rank"].ToString();
            }

            if (!hasResult)
            {
                MessageBox.Show("조건에 해당하는 데이터가 없습니다.", "조회오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();

            CheUserName_tb.Clear();
            CheUserDepartment_tb.Clear();
            CheUserID_tb.Clear();
            CheUserRank_tb.Clear();
        }

        private bool EditMode = false;

        private void UserCorrect_bt_Click(object sender, EventArgs e)
        {
            EditMode = !EditMode;
            //편집모드 토글

            UserList_dgv.Columns[0].ReadOnly = false;

            foreach (DataGridViewColumn col in UserList_dgv.Columns)
            {
                if (col.Index != 0)
                {
                    col.ReadOnly = !EditMode;
                }
            }
            //EditMode에 따라 수정/읽기전용 상태 설정

            UserCorrect_bt.Text = EditMode ? "수정 완료" : "수정";

            if (!EditMode)
            {
                UpdateUserManagement();
            }
        }

        private void UpdateUserManagement()
        {
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
            con.Open();

            foreach (DataGridViewRow row in UserList_dgv.Rows)
            {
                DataGridViewCheckBoxCell checkBC = row.Cells[0] as DataGridViewCheckBoxCell;
                //체크된 경우에만 데이터 수정
                if (checkBC != null && Convert.ToBoolean(checkBC.Value))
                {
                    string name = row.Cells[1].Value.ToString();
                    string id = row.Cells[2].Value.ToString();
                    string password = row.Cells[3].Value.ToString();
                    string department = row.Cells[4].Value.ToString();
                    string user_rank = row.Cells[5].Value.ToString();

                    //string modifyQuery = $"UPDATE user_registration SET name = '{name}', id = '{id}', password = '{password}', department = '{department}', user_rank = '{user_rank}'";
                    // 수정할 열의 값만 변경하고 나머지는 원래 값으로 유지
                    string modifyQuery = $"UPDATE user_registration SET ";
                    if (!string.IsNullOrEmpty(name))
                        modifyQuery += $"name = '{name}', ";
                    if (!string.IsNullOrEmpty(password))
                        modifyQuery += $"password = '{password}', ";
                    if (!string.IsNullOrEmpty(department))
                        modifyQuery += $"department = '{department}', ";
                    if (!string.IsNullOrEmpty(user_rank))
                        modifyQuery += $"user_rank = '{user_rank}', ";

                    modifyQuery = modifyQuery.TrimEnd(',', ' '); // 맨 뒤의 쉼표 및 공백 제거
                    modifyQuery += $" WHERE id = '{id}'";

                    MySqlCommand com = new MySqlCommand(modifyQuery, con);
                    com.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        private void UserDelet_bt_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; User id = team; Password = team1234");
            con.Open();

            for (int k = UserList_dgv.Rows.Count - 1; k >= 0; k--)
            {
                DataGridViewRow row = UserList_dgv.Rows[k];
                DataGridViewCheckBoxCell checkBC = row.Cells[0] as DataGridViewCheckBoxCell;

                if (checkBC != null && Convert.ToBoolean(checkBC.Value))
                {
                    string idToDelete = row.Cells[2].Value.ToString();
                    string deleteQuery = $"DELETE FROM user_registration WHERE id = '{idToDelete}'";
                    MySqlCommand com = new MySqlCommand(deleteQuery, con);
                    com.ExecuteNonQuery();
                    //체크된 열의 쿼리 지우기

                    UserList_dgv.Rows.Remove(row);
                    //체크된 열 지우기
                }
            }
            con.Close();
        }

        private void UserList_lb_Click(object sender, EventArgs e)
        {

        }

        private void UserList_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserCheck_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserCheck_lb_Click(object sender, EventArgs e)
        {

        }


    }
}
