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
        private Timer timer2;
        private Timer timer4;
        private Timer timer5;
        private Timer timer6;
        private Timer timer7;
        private Timer timer8;
        private Timer timer9;
        private Timer timer10;
        private Timer timer11;
        private Timer timer12;

        private DataContainer dataContainer;

        public formPlan(DataContainer dataContainer)
        {
            InitializeComponent();

            dataGridView2.MouseClick += dataGridView2_MouseClick;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            InitializeTimer(); // 타이머 초기화
            InitializeTimer2();
            InitializeTimer3();
            InitializeTimer4();
            InitializeTimer5();
            InitializeTimer6();
            this.dataContainer = dataContainer;
        }

        private void formPlan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            BindDataGridView();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView2.Rows.Clear();
            string connectionString = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // MySQL 데이터베이스 연결
                    connection.Open();

                    // 쿼리 작성
                    string query = "SELECT order_number AS '발주서번호', lot_no AS 'Lot No.', product_code AS '제품코드', product_name AS '제품명', expected_production_quantity AS '수량', DATE_FORMAT(due_date, '%Y-%m-%d') AS '납기일', supplier AS '회사명' FROM order_registration1";

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

                dataGridView1.Rows.Add(label15Text, label16Text, label17Text, label18Text, combobox1Text, label19Text, textbox1Text, state, workingtime, currentDate, dataContainer.Name, progress, label10Text, duedate2);
                dataGridView1.CurrentCell = null; // 현재 선택된 셀 해제
                Insert(label15Text, label16Text, label17Text, label18Text, combobox1Text, label19Text, textbox1Text, workingtime, currentDate, dataContainer.Name);
                DeleteInput(label16Text);
                DeleteOrder(label15Text);
            }
            else
            {
                MessageBox.Show("빈 칸을 채워주세요.");
            }
            BindDataGridView();
            comboBox1.Text = "";
            textBox1.Text = "";
            label15.Text = "";
            label16.Text = "";
            label21.Text = "";
            label18.Text = "";
            label19.Text = "";
            label17.Text = "";
            label10.Text = "";
        }

        public void DeleteInput(string LotNum)
        {
            try
            {
                string cnn = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";
                using (MySqlConnection connection = new MySqlConnection(cnn))
                {
                    // SQL 서버와 연결, database=스키마 이름
                    connection.Open();

                    // 입력할 문자 받아옴
                    string insertQuery = "DELETE FROM incoming WHERE lot_no=@LotNum";

                    // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                    // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                    // 위 정보를 command 변수에 저장
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@LotNum", LotNum);

                    command.ExecuteNonQuery();
                    MessageBox.Show("성공");
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteOrder(string OrderNum)
        {
            try
            {
                string cnn = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";
                using (MySqlConnection connection = new MySqlConnection(cnn))
                {
                    // SQL 서버와 연결, database=스키마 이름
                    connection.Open();

                    // 입력할 문자 받아옴
                    string insertQuery = "DELETE FROM order_registration1 WHERE order_number=@OrderNum";

                    // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                    // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                    // 위 정보를 command 변수에 저장
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@OrderNum", OrderNum);

                    command.ExecuteNonQuery();
                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Insert(string order_num, string lot, string code, string name, string bath, string quantity, string real_quantity, string time, string date, string registant)
        {
            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // MySQL 데이터베이스로 데이터 전송을 위한 SQL 쿼리 작성
                    string query = $"INSERT INTO working (order_num, lot_no, code, name, bath, quantity, real_quantity, time, date, registant) " +
                $"VALUES ('{order_num}', '{lot}', '{code}', '{name}', '{bath}', '{quantity}', '{real_quantity}', " +
                $"'{time}', '{date}', '{registant}')";

                    // 쿼리 실행
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // 데이터 전송 후 작업 완료 메시지 표시
                    MessageBox.Show("데이터 전송이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


       

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
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
        //베스1호
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 300; // 1초 간격으로 설정
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
                    row.Cells[7].Style.BackColor = Color.LimeGreen;
                    row.Cells[8].Style.BackColor = Color.Yellow;
                    // 소요시간 10씩 감소
                    remainingTime -= 1;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime;

                    if (remainingTime <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime = 0;
                        row.Cells[7].Value = "운행종료";
                        //row.Cells[7].Style.ForeColor = Color.Red;
                        row.Cells[7].Style.BackColor = Color.Red;
                        timer.Stop(); // 타이머 중지

                        timer2 = new Timer();
                        timer2.Interval = 2500; // 1초 간격으로 설정
                        timer2.Tick += timer2_Tick_1;
                        timer2.Start();
                    }
                }
            }
        }
        //베스1호 bath 데이터 삭제
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine("Timer2 Tick Event");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    timer2.Stop();
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
                    string connectionString1 = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                    {
                        connection1.Open();

                        // MySQL 쿼리 작성
                        string query1 = $"DELETE FROM working WHERE bath = '베스1호'";

                        using (MySqlCommand command = new MySqlCommand(query1, connection1))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
        }
        //베스2호
        private void InitializeTimer2()
        {
            timer3 = new Timer();
            timer3.Interval = 300; // 1초 간격으로 설정
            timer3.Tick += timer3_Tick;
            timer3.Start();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            // DataGridView1에서 베스번호가 '베스1호'인 행 찾기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value?.ToString() == "베스2호")
                {
                    int remainingTime2 = Convert.ToInt32(row.Cells[8].Value);
                    row.Cells[7].Style.BackColor = Color.LimeGreen;
                    row.Cells[8].Style.BackColor = Color.Yellow;

                    // 소요시간 10씩 감소
                    remainingTime2 -= 1;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime2;

                    if (remainingTime2 <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime2 = 0;
                        row.Cells[7].Value = "운행종료";
                        row.Cells[7].Style.BackColor = Color.Red;
                        timer3.Stop(); // 타이머 중지

                        timer4 = new Timer();
                        timer4.Interval = 2500; // 1초 간격으로 설정
                        timer4.Tick += timer4_Tick;
                        timer4.Start();
                    }
                }
            }
        }
        //bath 데이터 삭제
        private void timer4_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer4 Tick Event");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    timer4.Stop();
                    aaa();
                    // MySQL 데이터베이스에서 해당 행 삭제
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"DELETE FROM bath WHERE bath_num = '베스2호'";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    string connectionString1 = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                    {
                        connection1.Open();

                        // MySQL 쿼리 작성
                        string query1 = $"DELETE FROM working WHERE bath = '베스2호'";

                        using (MySqlCommand command = new MySqlCommand(query1, connection1))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
        }
        //베스3호
        private void InitializeTimer3()
        {
            timer5 = new Timer();
            timer5.Interval = 300; // 1초 간격으로 설정
            timer5.Tick += timer5_Tick;
            timer5.Start();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            // DataGridView1에서 베스번호가 '베스1호'인 행 찾기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value?.ToString() == "베스3호")
                {
                    int remainingTime3 = Convert.ToInt32(row.Cells[8].Value);
                    row.Cells[7].Style.BackColor = Color.LimeGreen;
                    row.Cells[8].Style.BackColor = Color.Yellow;

                    // 소요시간 10씩 감소
                    remainingTime3 -= 1;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime3;

                    if (remainingTime3 <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime3 = 0;
                        row.Cells[7].Value = "운행종료";
                        row.Cells[7].Style.BackColor = Color.Red;
                        timer5.Stop(); // 타이머 중지

                        timer6 = new Timer();
                        timer6.Interval = 2500; // 1초 간격으로 설정
                        timer6.Tick += timer6_Tick;
                        timer6.Start();
                    }
                }
            }
        }
        //bath 데이터 삭제
        private void timer6_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer6 Tick Event");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    timer6.Stop();
                    aaa();
                    // MySQL 데이터베이스에서 해당 행 삭제
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"DELETE FROM bath WHERE bath_num = '베스3호'";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    string connectionString1 = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                    {
                        connection1.Open();

                        // MySQL 쿼리 작성
                        string query1 = $"DELETE FROM working WHERE bath = '베스3호'";

                        using (MySqlCommand command = new MySqlCommand(query1, connection1))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
        }
        //베스4호
        private void InitializeTimer4()
        {
            timer7 = new Timer();
            timer7.Interval = 300; // 1초 간격으로 설정
            timer7.Tick += timer7_Tick;
            timer7.Start();
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            // DataGridView1에서 베스번호가 '베스1호'인 행 찾기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value?.ToString() == "베스4호")
                {
                    int remainingTime4 = Convert.ToInt32(row.Cells[8].Value);
                    row.Cells[7].Style.BackColor = Color.LimeGreen;
                    row.Cells[8].Style.BackColor = Color.Yellow;

                    // 소요시간 10씩 감소
                    remainingTime4 -= 1;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime4;

                    if (remainingTime4 <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime4 = 0;
                        row.Cells[7].Value = "운행종료";
                        row.Cells[7].Style.BackColor = Color.Red;
                        timer7.Stop(); // 타이머 중지

                        timer8 = new Timer();
                        timer8.Interval = 2500; // 1초 간격으로 설정
                        timer8.Tick += timer8_Tick;
                        timer8.Start();
                    }
                }
            }
        }
        //bath 데이터 삭제
        private void timer8_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer9 Tick Event");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    timer8.Stop();
                    aaa();
                    // MySQL 데이터베이스에서 해당 행 삭제
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"DELETE FROM bath WHERE bath_num = '베스4호'";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    string connectionString1 = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                    {
                        connection1.Open();

                        // MySQL 쿼리 작성
                        string query1 = $"DELETE FROM working WHERE bath = '베스4호'";

                        using (MySqlCommand command = new MySqlCommand(query1, connection1))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
        }
        //베스5호
        private void InitializeTimer5()
        {
            timer9 = new Timer();
            timer9.Interval = 300; // 1초 간격으로 설정
            timer9.Tick += timer9_Tick;
            timer9.Start();
        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            // DataGridView1에서 베스번호가 '베스1호'인 행 찾기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value?.ToString() == "베스5호")
                {
                    int remainingTime5 = Convert.ToInt32(row.Cells[8].Value);
                    row.Cells[7].Style.BackColor = Color.LimeGreen;
                    row.Cells[8].Style.BackColor = Color.Yellow;

                    // 소요시간 10씩 감소
                    remainingTime5 -= 1;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime5;

                    if (remainingTime5 <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime5 = 0;
                        row.Cells[7].Value = "운행종료";
                        row.Cells[7].Style.BackColor = Color.Red;
                        timer9.Stop(); // 타이머 중지

                        timer10 = new Timer();
                        timer10.Interval = 2500; // 1초 간격으로 설정
                        timer10.Tick += timer10_Tick;
                        timer10.Start();
                    }
                }
            }
        }
        //bath 데이터 삭제
        private void timer10_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer10 Tick Event");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    timer10.Stop();
                    aaa();
                    // MySQL 데이터베이스에서 해당 행 삭제
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"DELETE FROM bath WHERE bath_num = '베스5호'";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    string connectionString1 = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                    {
                        connection1.Open();

                        // MySQL 쿼리 작성
                        string query1 = $"DELETE FROM working WHERE bath = '베스5호'";

                        using (MySqlCommand command = new MySqlCommand(query1, connection1))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
        }
        //베스6호
        private void InitializeTimer6()
        {
            timer11 = new Timer();
            timer11.Interval = 300; // 1초 간격으로 설정
            timer11.Tick += timer11_Tick;
            timer11.Start();
        }
        private void timer11_Tick(object sender, EventArgs e)
        {
            // DataGridView1에서 베스번호가 '베스1호'인 행 찾기
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value?.ToString() == "베스6호")
                {
                    int remainingTime6 = Convert.ToInt32(row.Cells[8].Value);
                    row.Cells[7].Style.BackColor = Color.LimeGreen;
                    row.Cells[8].Style.BackColor = Color.Yellow;

                    // 소요시간 10씩 감소
                    remainingTime6 -= 1;

                    // DataGridView 업데이트
                    row.Cells[8].Value = remainingTime6;

                    if (remainingTime6 <= 0) // 소요시간이 0 이하인 경우, 베스가동상태를 '운행종료'로 변경
                    {
                        remainingTime6 = 0;
                        row.Cells[7].Value = "운행종료";
                        row.Cells[7].Style.BackColor = Color.Red;
                        timer11.Stop(); // 타이머 중지

                        timer12 = new Timer();
                        timer12.Interval = 2500; // 1초 간격으로 설정
                        timer12.Tick += timer12_Tick;
                        timer12.Start();
                    }
                }
            }
        }
        //bath 데이터 삭제
        private void timer12_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer12 Tick Event");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // DataGridView1의 8번째 열에서 '운행종료'인 행을 찾음
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    timer12.Stop();
                    aaa();
                    // MySQL 데이터베이스에서 해당 행 삭제
                    string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // MySQL 쿼리 작성
                        string query = $"DELETE FROM bath WHERE bath_num = '베스6호'";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    string connectionString1 = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                    {
                        connection1.Open();

                        // MySQL 쿼리 작성
                        string query1 = $"DELETE FROM working WHERE bath = '베스6호'";

                        using (MySqlCommand command = new MySqlCommand(query1, connection1))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
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


        //completed로 데이터 전송, 그리드뷰 해당 행 삭제
        private void aaa()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value?.ToString() == "운행종료")
                {
                    //DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string progress = row.Cells["Column1"].Value.ToString(); //발주서넘버인듯?
                    string orderNumber = row.Cells["Column2"].Value.ToString();
                    string dueDate = row.Cells["Column3"].Value.ToString();
                    string lotNo = row.Cells["Column4"].Value.ToString();
                    //string company = selectedRow.Cells["Column5"].Value.ToString();
                    //string productCode = selectedRow.Cells["Column6"].Value.ToString();
                    string productName = row.Cells["Column7"].Value.ToString();
                    //string quantity = selectedRow.Cells["Column8"].Value.ToString();
                    string registrationDateShipment = row.Cells["Column16"].Value.ToString();
                    string registrantShipment = dataContainer.Name;
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

                    string connectionString2 = "Server=10.10.32.82;Database=accumulated_data;Uid=team;Pwd=team1234;";
                    using (MySqlConnection connection2 = new MySqlConnection(connectionString2))
                    {
                        connection2.Open();
                        string accumulatedQuery = $"INSERT INTO accumulated_data(progress, order_number, due_date, lot_no, supplier, product_code, product_name, quantity, registration_date, registrant) " +
                               $"VALUES ('{progress1}', '{progress}', '{dueDate2}','{orderNumber}', '{supplier}', '{dueDate}', '{lotNo}','{productName}', '{registrationDateShipment}','{registrantShipment}')";

                        using (MySqlCommand command = new MySqlCommand(accumulatedQuery, connection2))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
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

        private void Re_bt_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }
    }

}
