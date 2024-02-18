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
    public partial class formInventory : Form
    {
        private string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

        public formInventory()
        {
            InitializeComponent();
            ShowGrid();

        }
        public void ShowGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            // 첫 번째 MySQL 연결
            string connectionIncoming = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection1 = new MySqlConnection(connectionIncoming))
            {
                connection1.Open();

                string Query = "SELECT * from bath";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection1);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["bath_num"], reader["medicine_type"], reader["medicine_num"],
                         reader["acidity"], reader["bath_progress"], reader["registrant"], reader["date"]);
                }
            }

            // 두 번째 MySQL 연결
            string connectionInspection = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection2 = new MySqlConnection(connectionInspection))
            {
                connection2.Open();

                string Query2 = "SELECT * from medicine";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command2 = new MySqlCommand(Query2, connection2);
                MySqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    dataGridView2.Rows.Add(
                        reader2["company"].ToString(),
                        reader2["code"].ToString(),
                        reader2["name"].ToString(),
                        reader2["quantity"].ToString()
                    );
                }
            }

        }





        string medicienText;
        private void Registrant_bt_Click(object sender, EventArgs e)
        {
            // 모든 콤보박스의 선택 여부 확인
            if (BathNum_com.SelectedItem != null &&
                 Acidity_com.SelectedItem != null &&
                MedicineNum_com.SelectedItem != null &&
                Medicine_com.SelectedItem != null)
            {
                // 콤보박스에서 선택된 값 가져오기
                string bathNum = BathNum_com.SelectedItem.ToString();
                string acidity = Acidity_com.SelectedItem.ToString();
                string medicineNum = MedicineNum_com.SelectedItem.ToString();
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 현재 순회 중인 행의 0번째 열의 값을 가져오기
                    string cellValue = row.Cells[0].Value?.ToString();
                    if (BathNum_com.Text.Equals(cellValue))
                    {
                        MessageBox.Show("이미 사용된 베스입니다.");
                        return;
                    }
                }

                InsertData(bathNum, medicienText, medicineNum, acidity, "가동중", "김서진", date);
                DataStorage.MinusMedicine(medicienText, medicineNum);
                ShowGrid();

                Company_lb.Text = "";
                Code_lb.Text = "";
                ProductName_lb.Text = "";
                Acidity_com.SelectedItem = null;
                MedicineNum_com.SelectedItem = null;
                Medicine_com.SelectedItem = null;
                BathNum_com.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("콤보박스 값을 모두 선택하세요.");
            }
        }
        // InsertData 함수 정의
        private void InsertData(string bath, string medicine, string num, string acidity, string progress, string registrant, string date)
        {
            string connectionString = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // MySQL 데이터베이스로 데이터 전송을 위한 SQL 쿼리 작성
                string query = $"INSERT INTO bath(bath_num,medicine_type,medicine_num,acidity,bath_progress,registrant,date) " +
                    $"VALUES ('{bath}', '{medicine}','{num}', '{acidity}', '{progress}', '{registrant}', '{date}')";

                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }




        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            Company_lb.Text = selectedRow.Cells["Column310"].Value.ToString();
            Code_lb.Text = selectedRow.Cells["Column312"].Value.ToString();
            ProductName_lb.Text = selectedRow.Cells["Column313"].Value.ToString();
        }

        private void Medicine_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스의 선택된 항목과 다른 텍스트 박스의 텍스트를 비교
            if (Medicine_com.SelectedItem != null)
            {
                string comboBoxValue = Medicine_com.SelectedItem.ToString();
                string textBoxValue = ProductName_lb.Text;

                if (comboBoxValue == textBoxValue)
                {
                    medicienText = Medicine_com.Text;
                }
                else
                {
                    MessageBox.Show("적합한 약품이 아닙니다.");
                }
            }
        }
    }
}
