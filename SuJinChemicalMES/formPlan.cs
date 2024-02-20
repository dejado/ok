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
    public partial class formPlan : Form
    {
        private Timer timer;
        //private Timer timer3;
        private Timer deleteTimer;

        public formPlan()
        {
            InitializeComponent();

            dataGridView2.MouseClick += dataGridView2_MouseClick;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            InitializeTimer(); // 타이머 초기화
            //InitializeTimer2(); // 타이머3 초기화
            InitializeDeleteTimer();

        }

        private void formPlan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            BindDataGridView();
            //this.dataGridView1.Font = new Font("SegoeUI", 10, FontStyle.Bold);
        }

        static void ConsolSize(string[] args)
        {
            // 콘솔 창의 너비와 높이를 설정
            Console.WindowWidth = 50;  // 원하는 너비 값으로 변경
            Console.WindowHeight = 20; // 원하는 높이 값으로 변경

            // 다른 작업 수행
            Console.WriteLine("콘솔 창 크기를 조절했습니다.");

            // 콘솔 창이 닫히지 않도록 대기
            Console.ReadLine();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindDataGridView()
        {
            string connectionString = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // MySQL 데이터베이스 연결
                    connection.Open();

                    // 쿼리 작성
                    string query = "SELECT order_number AS '발주서번호', lot_no AS 'Lot No.', product_code AS '제품코드', product_name AS '제품명', expected_production_quantity AS '수량', due_date AS '납기일', supplier AS '회사명' FROM order_registration1";

                    // 쿼리 실행
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // DataGridView에 데이터 추가
                            while (reader.Read())
                            {
                                dataGridView2.Rows.Add(
                                    reader["발주서번호"].ToString(),
                                    reader["Lot No."].ToString(),
                                    reader["제품코드"].ToString(),
                                    reader["제품명"].ToString(),
                                    reader["수량"].ToString(),
                                    reader["납기일"].ToString(),
                                    reader["회사명"].ToString(),
                                    reader["납기일"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 오류 처리
                MessageBox.Show("데이터 로드 중 오류 발생: " + ex.Message);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("B20230207001", "230207001", "UPS_30", "Upper shield (업퍼 쉴드)", "120", "2023-02-21");
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            // DataGridView의 현재 선택된 행을 가져옵니다.
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            label15.Text = selectedRow.Cells["Column10"].Value.ToString();
            label16.Text = selectedRow.Cells["Column11"].Value.ToString();
            label17.Text = selectedRow.Cells["Column12"].Value.ToString();
            label18.Text = selectedRow.Cells["Column13"].Value.ToString();
            label19.Text = selectedRow.Cells["Column14"].Value.ToString();
            label10.Text = selectedRow.Cells["Column18"].Value.ToString();
            // 필요에 따라 추가적인 TextBox에 대한 할당을 진행합니다.
            //recipe();
            */
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView2.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];

                    // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
                    label15.Text = selectedRow.Cells["Column10"].Value?.ToString();
                    label16.Text = selectedRow.Cells["Column11"].Value?.ToString();
                    label17.Text = selectedRow.Cells["Column12"].Value?.ToString();
                    label18.Text = selectedRow.Cells["Column13"].Value?.ToString();
                    label19.Text = selectedRow.Cells["Column14"].Value?.ToString();
                    label10.Text = selectedRow.Cells["Column18"].Value?.ToString();
                    // 필요에 따라 추가적인 TextBox에 대한 할당을 진행합니다.
                    //recipe();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // 모든 콤보박스의 선택 여부 확인
            if (comboBox1.SelectedItem != null &&
                !string.IsNullOrEmpty(textBox1.Text))
            {
                // 라벨에서 데이터 가져오기
                string label15Text = label15.Text;
                string label16Text = label16.Text;
                string label17Text = label17.Text;
                string label18Text = label18.Text;
                string combobox1Text = comboBox1.Text;
                string label19Text = label19.Text;
                string textbox1Text = textBox1.Text;
                //string combobox2Text = comboBox2.Text;
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string state = "운행중";
                string workingtime = "";
                string duedate2 = "";
                string label10Text = label10.Text;
                string progress = "생산완료";




                // 그리드뷰에 행 추가
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (string.IsNullOrEmpty(combobox1Text) || combobox1Text.Equals("(베스없음)"))
                    {
                        MessageBox.Show("선택된 베스가 없습니다.");
                        return; // 선택된 베스가 없으므로 이후 로직 실행 중단
                    }
                    else
                    {

                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 현재 순회 중인 행의 0번째 열의 값을 가져오기
                    string cellValue = row.Cells[4].Value?.ToString();
                    if (comboBox1.Text.Equals(cellValue))
                    {
                        MessageBox.Show("이미 사용된 베스입니다.");
                        return;
                    }
                }
                if (int.TryParse(textBox1.Text, out int textBoxValue) && int.TryParse(label19.Text, out int labelValue))
                {
                    // TextBox1의 값이 Label19의 값보다 큰 경우 메시지 창 띄우기
                    if (textBoxValue > labelValue)
                    {
                        MessageBox.Show("작업지시량이 생산계획량보다 많을 수 없습니다.");
                        return;

                    }
                }

                timer.Start();

                string connectionString = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
                // 콤보박스에서 선택한 값을 가져오기
                string selectedValue = label17.Text.ToString();

                // MySQL 데이터베이스 연결 및 쿼리 수행
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"SELECT working_time FROM recipe_registration WHERE product_code = '{selectedValue}'";


                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // chemical_type 열의 데이터를 가져와서 라벨에 출력
                                    workingtime = reader["working_time"].ToString();
                                    //label17.Text = $"{workingtime}";
                                }
                                else
                                {
                                    label17.Text = "해당하는 데이터가 없습니다.";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터베이스 조회 중 오류 발생: " + ex.Message);
                }


                string connectionString1 = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
                // 콤보박스에서 선택한 값을 가져오기
                //string selectedValue = label17.Text.ToString();

                // MySQL 데이터베이스 연결 및 쿼리 수행
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString1))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"SELECT registration_date FROM order_registration1";


                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // chemical_type 열의 데이터를 가져와서 라벨에 출력
                                    duedate2 = reader["registration_date"].ToString();
                                    //label17.Text = $"{workingtime}";
                                }
                                else
                                {
                                    //label17.Text = "해당하는 데이터가 없습니다.";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터베이스 조회 중 오류 발생: " + ex.Message);
                }

                dataGridView1.Rows.Add(label15Text, label16Text, label17Text, label18Text, combobox1Text, label19Text, textbox1Text, state, workingtime, currentDate, "나현진", progress, label10Text, duedate2);
                //FormDataShare.AddData(combobox1Text);
            }
            else
            {
                MessageBox.Show("빈 칸을 채워주세요.");
            }

        }


        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // MySQL 데이터베이스에서 해당 행 삭제
            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // MySQL 쿼리 작성
                string query = $"DELETE FROM bath WHERE bath_num = '베스1호'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// 콤보박스 핸들러 이벤트
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1초 간격으로 설정
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // DataGridView1에서 베스번호가 '베스1호'인 행 찾기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value?.ToString() == "베스1호")
                {
                    int remainingTime = Convert.ToInt32(row.Cells[8].Value);

                    // 소요시간 10씩 감소
                    remainingTime -= 10;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime;

                    if (remainingTime <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime = 0;
                        row.Cells[7].Value = "운행종료";
                        row.Cells[7].Style.ForeColor = Color.Red;
                        timer.Stop(); // 타이머 중지

                        timer3 = new Timer();
                        timer3.Interval = 4000; // 1초 간격으로 설정
                        timer3.Tick += timer3_Tick;
                        timer3.Start();
                    }
                }
            }
        }
        //bath 데이터 삭제
        private void timer3_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer3 Tick Event");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {


                    // 3초 후에 timer1_Tick 함수 실행
                    //timer3.Interval = 10000; // 3초

                    timer3.Stop();
                    aaa();
                    // MySQL 데이터베이스에서 해당 행 삭제
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"DELETE FROM bath WHERE bath_num = '베스1호'";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    //break; // 한 번 실행 후에는 루프를 종료합니다.

                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
            // 콤보박스에서 선택한 값을 가져오기
            string selectedValue = comboBox1.SelectedItem.ToString();

            // MySQL 데이터베이스 연결 및 쿼리 수행
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // MySQL 쿼리 작성
                    string query = $"SELECT medicine_type FROM bath WHERE bath_num = '{selectedValue}'";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // chemical_type 열의 데이터를 가져와서 라벨에 출력
                                string medicineType = reader["medicine_type"].ToString();
                                label21.Text = $"{medicineType}";
                            }
                            else
                            {
                                label21.Text = "해당하는 데이터가 없습니다.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터베이스 조회 중 오류 발생: " + ex.Message);
            }
        }

        private void comboBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // MySQL 데이터베이스 연결 및 쿼리 수행
            comboBox1.Items.Clear();

            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
            string query = "SELECT DISTINCT bath_num FROM bath";    //DISTINCT 중복을 방지시킴

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // bath_num 열의 데이터를 콤보박스에 추가
                                comboBox1.Items.Add(reader["bath_num"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터베이스 조회 중 오류 발생: " + ex.Message);
            }
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int textBoxValue) && int.TryParse(label19.Text, out int labelValue))
            {
                // TextBox1의 값이 Label19의 값보다 큰 경우 메시지 창 띄우기
                if (textBoxValue > labelValue)
                {
                    MessageBox.Show("작업지시량이 생산계획량을 초과 했습니다.");
                }
                else
                {
                    // TextBox1의 값이 Label19의 값보다 작거나 같은 경우에 대한 처리
                    // 원하는 동작 수행
                }
            }
        }


        private void InsertData()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string column1Value = selectedRow.Cells["Column1"].Value.ToString(); // 예시로 Column1을 사용했으니 실제로는 사용하는 컬럼으로 변경
                    string column2Value = selectedRow.Cells["Column2"].Value.ToString();
                    string column3Value = selectedRow.Cells["Column3"].Value.ToString();
                    string column4Value = selectedRow.Cells["Column4"].Value.ToString();
                    string column5Value = selectedRow.Cells["Column5"].Value.ToString();
                    string column6Value = selectedRow.Cells["Column6"].Value.ToString();
                    string column7Value = selectedRow.Cells["Column7"].Value.ToString();
                    string column8Value = selectedRow.Cells["Column8"].Value.ToString();
                    string column9Value = selectedRow.Cells["Column17"].Value.ToString();
                    string column10Value = selectedRow.Cells["Column16"].Value.ToString();
                    string column11Value = selectedRow.Cells["Column9"].Value.ToString();

                    string query = $"INSERT INTO completed(progress,order_number,due_date,lot_no,company,product_code,product_name,quantity,registration_date_shipment,registrant_shipment) " +
                         $"VALUES ('{column1Value}', '{column2Value}','{column3Value}', '{column4Value}', '{column5Value}', '{column6Value}', '{column7Value}', '{column8Value}', '{column9Value}', '{column10Value}', '{column11Value}')";

                    // 쿼리 실행
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        //completed로 데이터 전송, 그리드뷰 해당 행 삭제
        private void aaa()
        {
            //InsertData();

            // DataGridView에서 선택된 행 확인
            //if (dataGridView1.SelectedRows.Count > 0)
            // {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    //DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string progress = row.Cells["Column1"].Value.ToString();
                    string orderNumber = row.Cells["Column2"].Value.ToString();
                    string dueDate = row.Cells["Column3"].Value.ToString();
                    string lotNo = row.Cells["Column4"].Value.ToString();
                    //string company = selectedRow.Cells["Column5"].Value.ToString();
                    //string productCode = selectedRow.Cells["Column6"].Value.ToString();
                    string productName = row.Cells["Column7"].Value.ToString();
                    //string quantity = selectedRow.Cells["Column8"].Value.ToString();
                    string registrationDateShipment = row.Cells["Column16"].Value.ToString();
                    string registrantShipment = row.Cells["Column9"].Value.ToString();
                    string progress1 = row.Cells["Column19"].Value.ToString();
                    string supplier = row.Cells["Column20"].Value.ToString();
                    string dueDate2 = row.Cells["Column21"].Value.ToString();

                    // MySQL 데이터베이스에 데이터 추가
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"INSERT INTO completed(progress, order_number, due_date, lot_no, company, product_code, product_name, quantity, registration_date_shipment, registrant_shipment) " +
                               $"VALUES ('{progress1}', '{progress}', '{dueDate2}','{orderNumber}', '{supplier}', '{dueDate}', '{lotNo}','{productName}', '{registrationDateShipment}','{registrantShipment}')";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    dataGridView1.Rows.Remove(row);
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void InitializeDeleteTimer()
        {
            /*
            deleteTimer = new Timer();
            deleteTimer.Interval = 3000; // 5초 간격으로 설정 (원하는 주기로 조정)
            deleteTimer.Tick += (s, args) => DeleteRowsWithCondition();
            deleteTimer.Start();
            */
        }

        private void DeleteRowsWithCondition()
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    rowsToRemove.Add(row);
                }
            }

            // 찾은 행들을 삭제
            foreach (DataGridViewRow row in rowsToRemove)
            {
                dataGridView1.Rows.Remove(row);
                deleteTimer.Stop();
            }
        }
    }

}
