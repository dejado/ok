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
        public formPlan()
        {
            InitializeComponent();

            dataGridView2.MouseClick += dataGridView2_MouseClick;
            dataGridView2.AllowUserToAddRows = false;

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
                    string query = "SELECT order_number AS '발주서번호', lot_no AS 'Lot No.', product_code AS '제품코드', product_name AS '제품명', expected_production_quantity AS '수량', due_date AS '납기일' FROM order_registration1";

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
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

            }
            */
            // DataGridView의 현재 선택된 행을 가져옵니다.
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            label15.Text = selectedRow.Cells["Column10"].Value.ToString();
            label16.Text = selectedRow.Cells["Column11"].Value.ToString();
            label17.Text = selectedRow.Cells["Column12"].Value.ToString();
            label18.Text = selectedRow.Cells["Column13"].Value.ToString();
            label19.Text = selectedRow.Cells["Column14"].Value.ToString();
            // 필요에 따라 추가적인 TextBox에 대한 할당을 진행합니다.
            //recipe();
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
            // 라벨에서 데이터 가져오기
            string label15Text = label15.Text;
            string label16Text = label16.Text;
            string label17Text = label17.Text;
            string label18Text = label18.Text;
            string combobox1Text = comboBox1.Text;
            string label19Text = label19.Text;
            string textbox1Text = textBox1.Text;
            string combobox2Text = comboBox2.Text;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string state = "운행중";
            string workingtime = "";


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

            dataGridView1.Rows.Add(label15Text, label16Text, label17Text, label18Text, combobox1Text, label19Text, textbox1Text, state, workingtime, currentDate, combobox2Text);
            //FormDataShare.AddData(combobox1Text);
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
            comboBox1.Items.Clear();
            foreach (string data in FormDataShare.GetData())        //[1-2] combobox1 클릭시 데이터갱신
            {
                comboBox1.Items.Add(data);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// 콤보박스 핸들러 이벤트
        {
            string connectionString = "Server=10.10.32.82;Database=beth_chemical_management;Uid=team;Pwd=team1234;";
            // 콤보박스에서 선택한 값을 가져오기
            string selectedValue = comboBox1.SelectedItem.ToString();

            // MySQL 데이터베이스 연결 및 쿼리 수행
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // MySQL 쿼리 작성
                    string query = $"SELECT chemical_type FROM beth_operation_status WHERE beth_number = '{selectedValue}'";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // chemical_type 열의 데이터를 가져와서 라벨에 출력
                                string chemicalType = reader["chemical_type"].ToString();
                                label10.Text = $"{chemicalType}";
                            }
                            else
                            {
                                label10.Text = "해당하는 데이터가 없습니다.";
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
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
            /*
            else
            {
                // 숫자로 변환할 수 없는 경우 또는 예외 처리가 필요한 경우
                MessageBox.Show("숫자로 변환할 수 없거나 예외 처리가 필요합니다.");
            }
            */
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public static class FormDataShare   //[1-3] 다른폼 그리드뷰 데이터를 현재폼 콤보박스로 가져오는 관련 함수
    {
        private static List<string> dataList = new List<string>();

        public static void AddData(string data)
        {
            // 데이터가 중복되지 않는 경우에만 추가
            if (!dataList.Contains(data))
            {
                dataList.Add(data);
            }

            // 추가된 데이터를 확인하기 위해 출력
            Console.WriteLine("FormDataShare 데이터 수: " + dataList.Count);
            foreach (string d in dataList)
            {
                Console.WriteLine(d);
            }
        }

        public static List<string> GetData()
        {
            return dataList;
        }
    }
}
