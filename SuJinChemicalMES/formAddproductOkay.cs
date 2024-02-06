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
    public partial class formAddproductOkay : Form
    {
        public formAddproductOkay()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // DataGridView2에 빈 행 추가
            int index = dataGridView2.Rows.Add();

            // 현재 행의 2열에 텍스트박스1의 내용 추가
            dataGridView2.Rows[index].Cells[1].Value = textBox1.Text;
            dataGridView2.Rows[index].Cells[2].Value = comboBox1.SelectedItem;
            dataGridView2.Rows[index].Cells[3].Value = textBox6.Text;
            dataGridView2.Rows[index].Cells[4].Value = textBox4.Text;
            dataGridView2.Rows[index].Cells[5].Value = comboBox2.SelectedItem; // 수정된 부분
            dataGridView2.Rows[index].Cells[6].Value = textBox2.Text; // 이 부분은 필요한 경우에만 추가
            dataGridView2.Rows[index].Cells[7].Value = comboBox5.SelectedItem;
            dataGridView2.Rows[index].Cells[8].Value = dateTimePicker2.Value;

            // 텍스트박스1, 콤보박스1, 콤보박스3, 텍스트박스6, 텍스트박스4, 텍스트박스2, 콤보박스5, dateTimePicker2를 초기화
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox6.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // 선택된 날짜와 시간을 MySQL DATETIME 형식으로 변환
            string formattedTime = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // 변환된 값을 출력 (디버깅용)
            Console.WriteLine(formattedTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                // 체크된 행인지 확인
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // MySQL 연결 문자열 설정
            string connectionString = "Server=localhost;Database=managerproduct;User Id=root;Password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    // 데이터그리드뷰2에서 각 셀의 값을 읽어옴
                    string name = row.Cells[1].Value?.ToString() ?? ""; // 이름

                    // 데이터가 비어있는 경우 해당 행은 처리하지 않음
                    if (string.IsNullOrWhiteSpace(name))
                        continue;

                    string category = row.Cells[2].Value?.ToString() ?? ""; // 카테고리
                    string code = row.Cells[3].Value?.ToString() ?? ""; // 코드
                    string material = row.Cells[4].Value?.ToString() ?? ""; // 물질
                    string inspection = row.Cells[5].Value?.ToString() ?? ""; // 검사
                    string unit = row.Cells[6].Value?.ToString() ?? ""; // 단위
                    string kind = row.Cells[7].Value?.ToString() ?? ""; // 종류
                    string date = row.Cells[8].Value?.ToString() ?? ""; // 날짜

                    // dateTimePicker2에서 선택된 날짜와 시간을 MySQL DATETIME 형식으로 변환
                    string formattedTime = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    // MySQL에 데이터를 삽입하는 SQL 쿼리 작성
                    string query = $"INSERT INTO dfd (company, Item_Type, product_code, product_name, Test_Method, Specification, Standard_Unit, Registration_Date) VALUES " +
                       $"('{name.Replace("'", "''")}', '{category.Replace("'", "''")}', '{code.Replace("'", "''")}', " +
                       $"'{material.Replace("'", "''")}', '{inspection.Replace("'", "''")}', '{unit.Replace("'", "''")}', " +
                       $"'{kind.Replace("'", "''")}', '{formattedTime}');";

                    // 디버깅용으로 콘솔에 SQL 쿼리 출력
                    Console.WriteLine(query);

                    // 쿼리 실행
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // MySQL로의 데이터 전송이 완료되면 DataGridView2 초기화 또는 필요에 따라 다른 작업 수행
            dataGridView2.Rows.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // MySQL 연결 문자열 설정
            string connectionString = "Server=localhost;Database=managerproduct;User Id=root;Password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 텍스트박스4, 텍스트박스6의 값을 가져옴
                string productNameToSearch = textBox4.Text;
                string productCodeToSearch = textBox6.Text;

                dataGridView2.Rows.Clear();
                // 중복된 데이터를 검색하는 SQL 쿼리 작성
                string query = $"SELECT null as CheckColumn, company, Item_Type, product_code, product_name, Test_Method, Specification, Standard_Unit, Registration_Date FROM dfd WHERE product_name = '{productNameToSearch}' OR product_code = '{productCodeToSearch}';";

                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 결과를 확인
                        while (reader.Read())
                        {
                            int index = dataGridView2.Rows.Add();
                            for (int i = 1; i < reader.FieldCount; i++)
                            {
                                if (bool.TryParse(reader[i].ToString(), out _))
                                {
                                    dataGridView2.Rows[index].Cells[i].ValueType = typeof(string);
                                }
                                dataGridView2.Rows[index].Cells[i].Value = reader[i].ToString();
                            }
                        }

                        // 중복 데이터가 존재하지 않으면 알림창을 띄움
                        if (dataGridView2.Rows.Count == 0)
                        {
                            MessageBox.Show("중복된 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
