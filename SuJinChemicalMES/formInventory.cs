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
using MySqlX.XDevAPI.Common;

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
            string connectionIncoming = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
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
                MinusMedicine(medicienText, medicineNum);
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

        private void MinusMedicine(string name, string quantityToMinus)
        {
            string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 데이터베이스에서 동일한 이름의 데이터가 이미 있는지 확인합니다.
                string selectQuery = $"SELECT * FROM medicine WHERE name = '{name}'";

                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 동일한 이름의 데이터가 이미 존재하면 수량(quantity)을 업데이트합니다.
                            string currentQuantity = reader.GetString("quantity");
                            int newQuantity = int.Parse(currentQuantity) - int.Parse(quantityToMinus);

                            reader.Close();
                            string updateQuery = $"UPDATE medicine SET quantity = '{newQuantity}' WHERE name = '{name}'";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                                Console.WriteLine("약품 수량이 수정되었습니다.");
                            }
                        }
                    }
                }
            }
        }
        // InsertData 함수 정의
        private void InsertData(string bath, string medicine, string num, string acidity, string progress, string registrant, string date)
        {
            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
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


        private void BathNum_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formInventory_Load(object sender, EventArgs e)
        {
            var sampleData12 = new MLModel2.ModelInput()
            {
                VibrationNum = 1.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var sampleData11 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 1F,
                HeightBinary = 0F,
            };
            var sampleData10 = new MLModel2.ModelInput()
            {
                VibrationNum = 1.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 1F,
                HeightBinary = 0F,
            };
            var sampleData9 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 575.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var sampleData8 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 575.3159F,
                VibrationBinary = 0F,
                HeightBinary = 1F,
            };
            var sampleData7 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var result1 = MLModel2.Predict(sampleData12);
            var result2 = MLModel2.Predict(sampleData11);
            var result3 = MLModel2.Predict(sampleData10);
            var result4 = MLModel2.Predict(sampleData9);
            var result5 = MLModel2.Predict(sampleData8);
            var result6 = MLModel2.Predict(sampleData7);

            BathNum_com.Items.Clear();
            if (result1.Score.ToString().Equals(0))
            {
                BathNum_com.Items.Add("베스1호");
            }
            if (result2.Score.ToString().Equals(0))
            {
                BathNum_com.Items.Add("베스2호");
            }
            if (result3.Score.ToString().Equals(0))
            {
                BathNum_com.Items.Add("베스3호");
            }
            if (result4.Score.ToString().Equals(0))
            {
                BathNum_com.Items.Add("베스4호");
            }
            if (result5.Score.ToString().Equals(0))
            {
                BathNum_com.Items.Add("베스5호");
            }
            if (result6.Score.ToString().Equals(0))
            {
                BathNum_com.Items.Add("베스6호");
            }

        }

        private void Re_bt_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }
    }
}
