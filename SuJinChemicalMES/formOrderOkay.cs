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
    public partial class formOrderOkay : Form
    {
        public formOrderOkay()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool anyChecked = false; // 체크된 행이 있는지 여부를 나타내는 변수

            // 빈칸이 있는지 및 체크된 행이 있는지 검사
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value != null && (bool)chk.Value)
                {
                    anyChecked = true; // 체크된 행이 있음을 표시
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != 0 && (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())))
                        {
                            MessageBox.Show("빈 칸을 채워주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // 빈칸이 있으면 함수 종료
                        }
                    }
                }
            }

            // 체크된 행이 없는 경우 경고 메시지 출력 후 함수 종료
            if (!anyChecked)
            {
                MessageBox.Show("체크된 행이 없습니다. 전송할 데이터가 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // MySQL 연결 문자열
            string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

            // MySQL 연결
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 데이터그리드뷰2의 각 행을 MySQL 테이블에 전송
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        string orderNumber = row.Cells[1].Value.ToString();
                        string supplier = row.Cells[2].Value.ToString();
                        string productCode = row.Cells[3].Value.ToString();
                        string productName = row.Cells[4].Value.ToString();
                        string lotNo = row.Cells[5].Value.ToString();
                        string quantity = row.Cells[6].Value.ToString();
                        string registration_date = row.Cells[7].Value.ToString();
                        string dueDate = row.Cells[8].Value.ToString();
                        string registrant = row.Cells[9].Value.ToString();
                        string status = row.Cells[10].Value.ToString();

                        // MySQL 쿼리문 실행
                        string query = "INSERT INTO order_registration (order_number, supplier, product_code, product_name, lot_no, expected_production_quantity, registration_date, due_date, registrant, status) VALUES (@orderNumber, @supplier, @productCode, @productName, @lotNo, @quantity, @dueDate, @registrant, @status)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@orderNumber", orderNumber);
                        command.Parameters.AddWithValue("@supplier", supplier);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@lotNo", lotNo);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@registration_date", registration_date);
                        command.Parameters.AddWithValue("@dueDate", DateTime.Parse(dueDate));
                        command.Parameters.AddWithValue("@registrant", registrant);
                        command.Parameters.AddWithValue("@status", status);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("데이터가 성공적으로 전송되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 전송 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker1의 값이 변경될 때마다 dateTimePicker2의 값을 변경
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DataGridView2에 빈 행 추가
            int index = dataGridView2.Rows.Add();

            // 선택 체크박스를 추가하고 초기값으로 false 설정
            dataGridView2.Rows[index].Cells[0].Value = false;

            // 발주서번호 할당
            string orderNumber = textBox1.Text;
            if (string.IsNullOrEmpty(orderNumber))
            {
                // 발주서번호가 없으면 새로운 로트넘버 생성
                string selectedDate = dateTimePicker1.Value.ToString("yyyyMMdd");
                int lotNoIndex = GetLotNoIndex(selectedDate);
                orderNumber = "B" + selectedDate + lotNoIndex.ToString("000");
            }
            dataGridView2.Rows[index].Cells[1].Value = orderNumber;

            // 납품처 할당
            dataGridView2.Rows[index].Cells[2].Value = textBox2.Text;

            // 제품코드 할당
            dataGridView2.Rows[index].Cells[3].Value = textBox3.Text;

            // 제품명 할당
            dataGridView2.Rows[index].Cells[4].Value = textBox4.Text;

            // Lot No. 할당
            string selectedDateForLotNo = dateTimePicker1.Value.ToString("yyyyMMdd");
            int lotNoIndexForLotNo = GetLotNoIndex(selectedDateForLotNo);
            dataGridView2.Rows[index].Cells[5].Value = selectedDateForLotNo + lotNoIndexForLotNo.ToString("000");

            // 요청수량 할당
            dataGridView2.Rows[index].Cells[6].Value = textBox5.Text;

            // 등록일에 선택한 날짜 할당
            dataGridView2.Rows[index].Cells[7].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // 납기요청일에 dateTimePicker2에서 선택한 날짜 할당
            dataGridView2.Rows[index].Cells[8].Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // 등록자 할당
            dataGridView2.Rows[index].Cells[9].Value = "임진우";

            // 진행상태에 발주서등록 할당
            dataGridView2.Rows[index].Cells[10].Value = "발주서등록";

            // 텍스트박스1부터 텍스트박스5까지 초기화
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private int GetLotNoIndex(string selectedDate)
        {
            int index = 1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString().StartsWith(selectedDate))
                {
                    index++;
                }
            }
            return index;
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formOrderOkay_Load(object sender, EventArgs e)
        {
            // dateTimePicker1의 ValueChanged 이벤트 핸들러 등록
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            // dateTimePicker1의 현재 날짜를 기본값으로 설정
            dateTimePicker1.Value = DateTime.Now;

            // dateTimePicker2에는 dateTimePicker1에서 선택된 날짜에 14일을 더한 날짜를 기본값으로 설정
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(14);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
