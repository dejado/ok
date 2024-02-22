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
    public partial class formOrder : Form
    {
        public formOrder()
        {
            InitializeComponent();
        }
        private void textBox6_Click(object sender, EventArgs e)
        {

            textBox6.Clear();
        }
        private void textBox5_Click(object sender, EventArgs e)
        {

            textBox5.Clear();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            formOrderOkay formOrderOkay = new formOrderOkay();
            formOrderOkay.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // MySQL 연결 문자열 설정
            string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 중복된 데이터를 검색하는 SQL 쿼리 작성
                string query = "SELECT order_number, supplier, product_code, product_name, lot_no, expected_production_quantity, due_date, registrant, status FROM order_registration WHERE 1=1"; // 기본적으로 참인 조건 추가

                // 텍스트박스 6의 값이 비어있지 않으면 product_code 검색 조건 추가
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    query += $" AND product_code = '{textBox6.Text}'";
                }

                // 텍스트박스 5의 값이 비어있지 않으면 product_name 검색 조건 추가
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    query += $" AND product_name = '{textBox5.Text}'";
                }

                // 텍스트박스 1의 값이 비어있지 않으면 company_name 검색 조건 추가
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    query += $" AND supplier = '{textBox1.Text}'";
                }



                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // DataGridView2의 데이터를 모두 지워줍니다.
                        dataGridView2.Rows.Clear();

                        // 결과를 확인
                        bool hasResult = false; // 결과가 있는지 확인하기 위한 플래그
                        while (reader.Read())
                        {
                            hasResult = true; // 결과가 있음을 표시

                            int index = dataGridView2.Rows.Add();

                            // DataGridView에 데이터 행을 추가하면서 CheckBoxCell을 추가합니다.
                            dataGridView2.Rows[index].Cells[0].Value = false; // CheckBox 초기값은 false로 설정

                            // 각 칼럼에 대응하는 데이터를 DataGridView에 추가합니다.
                            dataGridView2.Rows[index].Cells[1].Value = reader["order_number"].ToString();
                            dataGridView2.Rows[index].Cells[2].Value = reader["supplier"].ToString();
                            dataGridView2.Rows[index].Cells[3].Value = reader["product_code"].ToString();
                            dataGridView2.Rows[index].Cells[4].Value = reader["product_name"].ToString();
                            dataGridView2.Rows[index].Cells[5].Value = reader["lot_no"].ToString();
                            dataGridView2.Rows[index].Cells[6].Value = reader["expected_production_quantity"].ToString();
                            dataGridView2.Rows[index].Cells[7].Value = ((DateTime)reader["due_date"]).ToString("yyyy-MM-dd"); // 날짜 형식 설정
                            dataGridView2.Rows[index].Cells[8].Value = reader["registrant"].ToString();
                            dataGridView2.Rows[index].Cells[9].Value = reader["status"].ToString();
                        }

                        // 중복 데이터가 존재하지 않으면 알림창을 띄움
                      /*  if (!hasResult)
                        {
                            MessageBox.Show("조건에 해당하는 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }
                }

                // 조회 후 텍스트박스 초기화
                textBox5.Clear();
                textBox6.Clear();
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool editMode = false;

        private void button3_Click(object sender, EventArgs e)
        {
            // 편집 모드 상태를 토글합니다.
            editMode = !editMode;

            // 첫 번째 칸(체크박스 열)은 항상 수정 가능한 상태로 유지됩니다.
            dataGridView2.Columns[0].ReadOnly = false;

            // 나머지 칸은 editMode에 따라 수정 가능/읽기 전용 상태를 설정합니다.
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.Index != 0) // 첫 번째 칸(체크박스 열)이 아닌 경우
                {
                    column.ReadOnly = !editMode; // editMode 값에 따라 설정됩니다.
                }
            }

            // 버튼 텍스트를 수정합니다.
            button3.Text = editMode ? "수정 완료" : "수정";

            // 수정 완료 시 MySQL 데이터베이스를 업데이트합니다.
            if (!editMode)
            {
                UpdateMySQLDatabase();
            }
        }

        private void UpdateMySQLDatabase()
        {
            // MySQL 연결 문자열 설정
            string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 선택된 행의 데이터만 수정합니다.
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                    // 체크된 행인지 확인하고 체크된 경우에만 MySQL 데이터를 수정합니다.
                    if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                    {
                        // DataGridView의 각 셀 값 가져오기
                        string orderNumber = row.Cells[1].Value.ToString();
                        string supplier = row.Cells[2].Value.ToString();
                        string productCode = row.Cells[3].Value.ToString();
                        string productName = row.Cells[4].Value.ToString();
                        string lotNo = row.Cells[5].Value.ToString();
                        string expectedQuantity = row.Cells[6].Value.ToString();
                        string dueDate = row.Cells[7].Value.ToString();
                        string registrant = row.Cells[8].Value.ToString();
                        string status = row.Cells[9].Value.ToString();

                        // SQL 쿼리 작성
                        string query = $"UPDATE order_registration SET supplier = '{supplier}', product_code = '{productCode}', product_name = '{productName}', lot_no = '{lotNo}', expected_production_quantity = '{expectedQuantity}', due_date = '{dueDate}', registrant = '{registrant}', status = '{status}' WHERE order_number = '{orderNumber}'";

                        // 쿼리 실행
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                                
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            // 선택된 행을 역순으로 삭제합니다.
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                // 체크된 행인지 확인하고 체크된 경우 해당 행을 삭제합니다.
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void formOder_Load(object sender, EventArgs e)
        {

        }

        private void formOrder_Load(object sender, EventArgs e)
        {
            LoadDataFromMySQL();
        }
        private void LoadDataFromMySQL()
        {
            string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 중복된 데이터를 검색하는 SQL 쿼리 작성
                string query = "SELECT order_number, supplier, product_code, product_name, lot_no, expected_production_quantity, due_date, registrant, status FROM order_registration WHERE 1=1"; // 기본적으로 참인 조건 추가

                // 텍스트박스 6의 값이 비어있지 않으면 product_code 검색 조건 추가
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    query += $" AND product_code = '{textBox6.Text}'";
                }

                // 텍스트박스 5의 값이 비어있지 않으면 product_name 검색 조건 추가
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    query += $" AND product_name = '{textBox5.Text}'";
                }

                // 텍스트박스 1의 값이 비어있지 않으면 company_name 검색 조건 추가
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    query += $" AND supplier = '{textBox1.Text}'";
                }



                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // DataGridView2의 데이터를 모두 지워줍니다.
                        dataGridView2.Rows.Clear();

                        // 결과를 확인
                        bool hasResult = false; // 결과가 있는지 확인하기 위한 플래그
                        while (reader.Read())
                        {
                            hasResult = true; // 결과가 있음을 표시

                            int index = dataGridView2.Rows.Add();

                            // DataGridView에 데이터 행을 추가하면서 CheckBoxCell을 추가합니다.
                            dataGridView2.Rows[index].Cells[0].Value = false; // CheckBox 초기값은 false로 설정

                            // 각 칼럼에 대응하는 데이터를 DataGridView에 추가합니다.
                            dataGridView2.Rows[index].Cells[1].Value = reader["order_number"].ToString();
                            dataGridView2.Rows[index].Cells[2].Value = reader["supplier"].ToString();
                            dataGridView2.Rows[index].Cells[3].Value = reader["product_code"].ToString();
                            dataGridView2.Rows[index].Cells[4].Value = reader["product_name"].ToString();
                            dataGridView2.Rows[index].Cells[5].Value = reader["lot_no"].ToString();
                            dataGridView2.Rows[index].Cells[6].Value = reader["expected_production_quantity"].ToString();
                            dataGridView2.Rows[index].Cells[7].Value = ((DateTime)reader["due_date"]).ToString("yyyy-MM-dd"); // 날짜 형식 설정
                            dataGridView2.Rows[index].Cells[8].Value = reader["registrant"].ToString();
                            dataGridView2.Rows[index].Cells[9].Value = reader["status"].ToString();
                        }

                        // 중복 데이터가 존재하지 않으면 알림창을 띄움
                      /*  if (!hasResult)
                        {
                            MessageBox.Show("조건에 해당하는 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }
                }
            }
    }
}
    }