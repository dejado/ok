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
    public partial class formInventory : Form
    {
        private string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

        public formInventory()
        {
            InitializeComponent();
        }

        private void formInventory_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 데이터그리드뷰에 MySQL 데이터 바인딩
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // MySQL 데이터베이스 연결
                    connection.Open();

                    // 쿼리 작성
                    string query = "SELECT company, lot_no, product_code, product_name, quantity FROM incoming WHERE location = '부자재IB'";

                    // 쿼리 실행
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // DataGridView에 데이터 추가
                            while (reader.Read())
                            {
                                dataGridView2.Rows.Add(
                                    reader["company"].ToString(),
                                    reader["lot_no"].ToString(),
                                    reader["product_code"].ToString(),
                                    reader["product_name"].ToString(),
                                    reader["quantity"].ToString()
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
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            // DataGridView에서 선택한 행의 인덱스를 확인합니다.
            int selectedRowIndex = e.RowIndex;

            // 선택한 행의 데이터를 가져옵니다.
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            // 각 셀의 값을 가져와서 텍스트박스에 할당합니다.
            textBox10.Text = selectedRow.Cells["Column10"].Value.ToString();
            textBox11.Text = selectedRow.Cells["Column11"].Value.ToString();
            // 필요에 따라 추가적인 텍스트박스에 대한 할당을 진행합니다.
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add(textBox10.Text);

            // 데이터 입력 후 TextBox를 초기화합니다.
            //textBox10.Text = "ddddddddd";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("토리콤", "235555", "NHO3", "질산", "90L");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("토리콤", "230207001", "H2SO4", "황산", "120L");
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("토리콤", "235555", "NHO3", "질산", "90L");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("토리콤", "230207001", "H2SO4", "황산", "120L");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string comboBox1Text = comboBox1.Text;
            string combobox4Text = comboBox4.Text;
            string combobox3Text = comboBox3.Text;
            string combobox6Text = comboBox6.Text;
            string combobox5Text = comboBox5.Text;
            string combobox2Text = comboBox2.Text;

            // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // 현재 순회 중인 행의 0번째 열의 값을 가져오기
                string cellValue = row.Cells[0].Value?.ToString();
                if (comboBox1.Text.Equals(cellValue))
                {
                    MessageBox.Show("이미 사용된 베스입니다.");
                    return;
                }
            }

            dataGridView1.Rows.Add(comboBox1Text, combobox4Text, combobox3Text, combobox6Text, "1.2 ph", "99%", "1%", combobox5Text, combobox2Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)     // [1-1] 버튼 클릭시 dataGrid 0열에 베스번호를 formPlan으로 보내준다
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    string valueToAdd = row.Cells[0].Value.ToString();
                    FormDataShare.AddData(valueToAdd);
                }
            }
        }





        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            label310.Text = selectedRow.Cells["Column310"].Value.ToString();
            label311.Text = selectedRow.Cells["Column311"].Value.ToString();
            label312.Text = selectedRow.Cells["Column312"].Value.ToString();
            label313.Text = selectedRow.Cells["Column313"].Value.ToString();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
