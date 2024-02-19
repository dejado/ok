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

        public TextBox TextBox3 => textBox3;
        public TextBox TextBox4 => textBox4;


        private void button6_Click(object sender, EventArgs e)
        {
            // 빈칸이 있는지 및 체크된 행이 있는지 검사
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value != null && (bool)chk.Value)
                {
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
                        if (!row.IsNewRow) // 새로 추가된 행이 아닌 경우에만 처리
                        {
                            string orderNumber = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;

                            // 이미 등록된 발주서번호인지 확인
                            string checkQuery = "SELECT COUNT(*) FROM order_registration WHERE order_number = @orderNumber";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@orderNumber", orderNumber);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (count > 0)
                            {
                                // 이미 등록된 발주서번호가 있음을 알림
                                MessageBox.Show("이미 등록된 발주서번호입니다: " + orderNumber, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // 등록되지 않은 발주서번호인 경우 MySQL 쿼리문 실행
                            string supplier = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                            string productCode = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
                            string productName = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;
                            string lotNo = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : string.Empty;
                            string quantity = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : string.Empty;
                            string registration_date = row.Cells[7].Value != null ? row.Cells[7].Value.ToString() : string.Empty;
                            string dueDate = row.Cells[8].Value != null ? row.Cells[8].Value.ToString() : string.Empty;
                            string registrant = row.Cells[9].Value != null ? row.Cells[9].Value.ToString() : string.Empty;
                            string status = row.Cells[10].Value != null ? row.Cells[10].Value.ToString() : string.Empty;

                            // MySQL 쿼리문 실행 (order_registration 테이블)
                            string insertQueryOrderReg = "INSERT INTO order_registration (order_number, supplier, product_code, product_name, lot_no, expected_production_quantity, registration_date, due_date, registrant, status) " +
                                                 "VALUES (@orderNumber, @supplier, @productCode, @productName, @lotNo, @quantity, @registration_date, @dueDate, @registrant, @status)";
                            MySqlCommand commandOrderReg = new MySqlCommand(insertQueryOrderReg, connection);
                            commandOrderReg.Parameters.AddWithValue("@orderNumber", orderNumber);
                            commandOrderReg.Parameters.AddWithValue("@supplier", supplier);
                            commandOrderReg.Parameters.AddWithValue("@productCode", productCode);
                            commandOrderReg.Parameters.AddWithValue("@productName", productName);
                            commandOrderReg.Parameters.AddWithValue("@lotNo", lotNo);
                            commandOrderReg.Parameters.AddWithValue("@quantity", quantity);
                            commandOrderReg.Parameters.AddWithValue("@registration_date", registration_date);
                            commandOrderReg.Parameters.AddWithValue("@dueDate", dueDate);
                            commandOrderReg.Parameters.AddWithValue("@registrant", registrant);
                            commandOrderReg.Parameters.AddWithValue("@status", status);

                            commandOrderReg.ExecuteNonQuery();

                            // MySQL 쿼리문 실행 (order_registration1 테이블)
                            string insertQueryOrderReg1 = "INSERT INTO order_registration1 (order_number, supplier, product_code, product_name, lot_no, expected_production_quantity, registration_date, due_date, registrant, status) " +
                                                 "VALUES (@orderNumber, @supplier, @productCode, @productName, @lotNo, @quantity, @registration_date, @dueDate, @registrant, @status)";
                            MySqlCommand commandOrderReg1 = new MySqlCommand(insertQueryOrderReg1, connection);
                            commandOrderReg1.Parameters.AddWithValue("@orderNumber", orderNumber);
                            commandOrderReg1.Parameters.AddWithValue("@supplier", supplier);
                            commandOrderReg1.Parameters.AddWithValue("@productCode", productCode);
                            commandOrderReg1.Parameters.AddWithValue("@productName", productName);
                            commandOrderReg1.Parameters.AddWithValue("@lotNo", lotNo);
                            commandOrderReg1.Parameters.AddWithValue("@quantity", quantity);
                            commandOrderReg1.Parameters.AddWithValue("@registration_date", registration_date);
                            commandOrderReg1.Parameters.AddWithValue("@dueDate", dueDate);
                            commandOrderReg1.Parameters.AddWithValue("@registrant", registrant);
                            commandOrderReg1.Parameters.AddWithValue("@status", status);

                            commandOrderReg1.ExecuteNonQuery();
                        }
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
            formOrderOkay2 form = new formOrderOkay2();
            form.ShowDialog();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void formOrderOkay_Load_1(object sender, EventArgs e)
        {

        }
    }
}
