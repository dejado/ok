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
        private DataContainer dataContainer;

        public formAddproductOkay()
        {
            InitializeComponent();
            textBox6.Click += textBox6_Click;
            textBox4.Click += textBox4_Click;

        }
        public formAddproductOkay(DataContainer dataContainer)
        {
            InitializeComponent();
            textBox6.Click += textBox6_Click;
            textBox4.Click += textBox4_Click;
            this.dataContainer = dataContainer;
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
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DataGridView2에 빈 행 추가
            int index = dataGridView2.Rows.Add();

            // 선택 체크박스를 추가하고 초기값으로 false 설정
            dataGridView2.Rows[index].Cells[0].Value = false;

            // 텍스트박스1에 입력된 회사명을 DataGridView2의 회사명 열에 할당
            dataGridView2.Rows[index].Cells[1].Value = textBox1.Text;

            // 콤보박스1에서 선택된 제품유형을 DataGridView2의 제품유형 열에 할당
            dataGridView2.Rows[index].Cells[2].Value = comboBox1.SelectedItem;

            // 텍스트박스6에 입력된 제품코드를 DataGridView2의 제품코드 열에 할당
            dataGridView2.Rows[index].Cells[3].Value = textBox6.Text;

            // 텍스트박스4에 입력된 제품명을 DataGridView2의 제품명 열에 할당
            dataGridView2.Rows[index].Cells[4].Value = textBox4.Text;

            // 콤보박스2에서 선택된 검사방법을 DataGridView2의 검사방법 열에 할당
            dataGridView2.Rows[index].Cells[5].Value = comboBox2.SelectedItem;

            // dateTimePicker2에서 선택된 날짜를 DataGridView2의 등록일 열에 할당
            dataGridView2.Rows[index].Cells[6].Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // Form1의 인스턴스를 얻어옵니다.
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            // Form1이 존재하고, name_lb 라벨이 존재하는지 확인합니다.
            if (form1Instance != null && form1Instance.Controls.Find("name_lb", true).Length > 0)
            {
                // name_lb 라벨의 텍스트 값을 가져와서 '사용자 : ' 부분을 제거한 뒤 dataGridView2의 셀에 할당합니다.
                string labelText = form1Instance.Controls.Find("name_lb", true)[0].Text;
                int colonIndex = labelText.IndexOf(':');
                if (colonIndex != -1 && colonIndex + 2 < labelText.Length) // ':'이 발견되고, ':' 이후에 문자가 존재하는지 확인
                {
                    dataGridView2.Rows[index].Cells[7].Value = labelText.Substring(colonIndex + 2);
                }

            }

            // 텍스트박스1, 콤보박스1, 텍스트박스6, 텍스트박스4, 콤보박스2를 초기화
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox6.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedIndex = -1;
            dateTimePicker2.Value = DateTime.Now;
        }
        //
        private void formAddproductOkay_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // MySQL 연결 문자열 설정
            string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 텍스트박스6의 값을 가져옴
                string productCodeToSearch = textBox6.Text;

                // 중복된 데이터가 있는지 확인하기 위한 플래그
                bool hasDuplicate = false;

                // 중복된 데이터를 검색하는 SQL 쿼리 작성
                string query = $"SELECT product_code FROM product_registration WHERE product_code = '{productCodeToSearch}'";

                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 결과를 확인
                        while (reader.Read())
                        {
                            // 중복된 데이터가 하나라도 있는 경우 플래그를 설정하고 반복문 종료
                            hasDuplicate = true;
                            break;
                        }
                    }
                }

                // 중복된 데이터가 있는지 확인하여 알림창 표시
                if (hasDuplicate)
                {
                    MessageBox.Show("중복된 데이터가 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("중복된 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void textBox6_Click(object sender, EventArgs e)
        {

            textBox6.Clear();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {

            textBox4.Clear();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            // MySQL 연결 문자열 설정
            string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    // 데이터그리드뷰2의 각 셀에서 값을 읽어옴
                    string company = row.Cells[1].Value?.ToString() ?? ""; // 회사명
                    string item_type = row.Cells[2].Value?.ToString() ?? ""; // 제품유형
                    string product_code = row.Cells[3].Value?.ToString() ?? ""; // 제품코드
                    string product_name = row.Cells[4].Value?.ToString() ?? ""; // 제품명
                    string Test_Method = row.Cells[5].Value?.ToString() ?? ""; // 검사방법
                    string registrant = row.Cells[7].Value?.ToString();

                    // dateTimePicker2에서 선택된 날짜를 MySQL DATETIME 형식으로 변환
                    string registration_date = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    // MySQL에 데이터를 삽입하는 SQL 쿼리 작성
                    string query = $"INSERT INTO product_registration (company, item_type, product_code, product_name, Test_Method, registration_date) VALUES " +
                        $"('{company.Replace("'", "''")}', '{item_type.Replace("'", "''")}', '{product_code.Replace("'", "''")}', " +
                        $"'{product_name.Replace("'", "''")}', '{Test_Method.Replace("'", "''")}', '{registration_date}'), '{registrant.Replace("'", "''")};";

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}