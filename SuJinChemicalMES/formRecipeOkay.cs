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
    public partial class formRecipeOkay : Form
    {
        private DataContainer dataContainer;
        public formRecipeOkay()
        {
            InitializeComponent();
            textBox3.Click += textBox3_Click;
            textBox2.Click += textBox2_Click;


        }
        public formRecipeOkay(DataContainer dataContainer)
        {
            InitializeComponent();
            textBox3.Click += textBox3_Click;
            textBox2.Click += textBox2_Click;
            this.dataContainer = dataContainer;

        }
        private void formRecipeOkay_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_Click(object sender, EventArgs e)
        {

            textBox3.Clear();
        }
        private void textBox2_Click(object sender, EventArgs e)
        {

            textBox2.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // DataGridView2에 빈 행 추가
            int index = dataGridView2.Rows.Add();

            // 선택 체크박스를 추가하고 초기값으로 false 설정
            dataGridView2.Rows[index].Cells[0].Value = false;

            // No. 열에 행 번호 할당
            dataGridView2.Rows[index].Cells[1].Value = index + 1;

            // 텍스트박스1에 입력된 회사명을 DataGridView2의 회사명 열에 할당
            dataGridView2.Rows[index].Cells[2].Value = textBox1.Text;

            // 텍스트박스2에 입력된 제품명을 DataGridView2의 제품명 열에 할당
            dataGridView2.Rows[index].Cells[3].Value = textBox2.Text;

            // 텍스트박스3에 입력된 제품코드를 DataGridView2의 제품코드 열에 할당
            dataGridView2.Rows[index].Cells[4].Value = textBox3.Text;

            // 텍스트박스4에 입력된 제품성분을 DataGridView2의 제품성분 열에 할당
            dataGridView2.Rows[index].Cells[5].Value = textBox4.Text;

            // 텍스트박스5에 입력된 약품성분을 DataGridView2의 약품성분 열에 할당
            dataGridView2.Rows[index].Cells[6].Value = textBox5.Text;

            // 텍스트박스6에 입력된 산도수치를 DataGridView2의 산도수치 열에 할당
            dataGridView2.Rows[index].Cells[7].Value = textBox6.Text;

            // 텍스트박스7에 입력된 작업시간을 DataGridView2의 작업시간 열에 할당
            dataGridView2.Rows[index].Cells[8].Value = textBox7.Text;

            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();


            if (form1Instance != null && form1Instance.Controls.Find("name_lb", true).Length > 0)
            {
                // name_lb 라벨의 텍스트 값을 가져와서 '사용자 : ' 부분을 제거한 뒤 dataGridView2의 셀에 할당합니다.
                string labelText = form1Instance.Controls.Find("name_lb", true)[0].Text;
                int colonIndex = labelText.IndexOf(':');
                if (colonIndex != -1 && colonIndex + 2 < labelText.Length) // ':'이 발견되고, ':' 이후에 문자가 존재하는지 확인
                {
                    dataGridView2.Rows[index].Cells[9].Value = labelText.Substring(colonIndex + 2);
                }

            }


            // 텍스트박스1부터 텍스트박스7까지 초기화
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    string company = row.Cells[2].Value?.ToString() ?? ""; // 회사명
                    string product_name = row.Cells[3].Value?.ToString() ?? ""; // 제품명
                    string product_code = row.Cells[4].Value?.ToString() ?? ""; // 제품코드
                    string product_component = row.Cells[5].Value?.ToString() ?? ""; // 제품성분
                    string chemical_type = row.Cells[6].Value?.ToString() ?? ""; // 약품성분
                    string acidity_level = row.Cells[7].Value?.ToString() ?? ""; // 산도수치
                    string working_time = row.Cells[8].Value?.ToString() ?? ""; // 작업시간

                    // MySQL에 데이터를 삽입하는 SQL 쿼리 작성
                    string query = $"INSERT INTO recipe_registration (company_name, product_name, product_code, product_component, chemical_type, acidity_level, working_time) VALUES " +
                        $"('{company.Replace("'", "''")}', '{product_name.Replace("'", "''")}', '{product_code.Replace("'", "''")}', " +
                        $"'{product_component.Replace("'", "''")}', '{chemical_type.Replace("'", "''")}', '{acidity_level.Replace("'", "''")}', " +
                        $"'{working_time.Replace("'", "''")}');";

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
            // 텍스트박스6의 내용이 "code"일 경우 내용을 지웁니다.
            if (textBox3.Text == "code")
                textBox3.Clear();

            // 텍스트박스4의 내용이 "품명"일 경우 내용을 지웁니다.
            if (textBox2.Text == "품명")
                textBox2.Clear();

            // MySQL 연결 문자열 설정
            string connectionString = "Server=localhost;Database=managerproduct;User Id=root;Password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 텍스트박스4, 텍스트박스6의 값을 가져옴
                string productNameToSearch = textBox2.Text;
                string productCodeToSearch = textBox3.Text;

                // 중복된 데이터가 있는지 확인하기 위한 플래그
                bool hasDuplicate = false;

                // 중복된 데이터를 검색하는 SQL 쿼리 작성
                string query = $"SELECT * FROM recipe_registration WHERE product_name = @productName OR product_code = @productCode";

                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // 매개 변수 추가
                    cmd.Parameters.AddWithValue("@productName", productNameToSearch);
                    cmd.Parameters.AddWithValue("@productCode", productCodeToSearch);

                    // 결과 확인
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 결과가 있는지 확인
                        if (reader.HasRows)
                        {
                            hasDuplicate = true;
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}