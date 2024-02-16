using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace SuJinChemicalMES
{
    public partial class formOrderOkay2 : Form
    {
        // MySQL 연결 문자열
        private string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";

        private formOrderOkay formOrderOkayInstance; // formOrderOkay 인스턴스를 저장하기 위한 변수

        public formOrderOkay2()
        {
            InitializeComponent();
            formOrderOkayInstance = new formOrderOkay(); // formOrderOkay 인스턴스 생성
        }


        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT product_code, product_name FROM managerproduct.product_registration";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    DataTable dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());

                    // 데이터 그리드 뷰에 데이터를 설정합니다.
                    dataGridView2.Rows.Clear(); // 기존에 행이 있을 경우를 대비하여 행을 모두 지웁니다.

                    foreach (DataRow row in dataTable.Rows)
                    {
                        dataGridView2.Rows.Add(row["product_code"].ToString(), row["product_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string productCode = row.Cells["product_code"].Value.ToString();
                string productName = row.Cells["product_name"].Value.ToString();

                // formOrderOkay 폼의 인스턴스를 가져옵니다.
                formOrderOkay formOrderOkayInstance = Application.OpenForms.OfType<formOrderOkay>().FirstOrDefault();

                // formOrderOkay 폼의 인스턴스가 존재하지 않으면 새로 생성합니다.
                if (formOrderOkayInstance == null)
                {
                    formOrderOkayInstance = new formOrderOkay();
                }

                // formOrderOkay 폼의 텍스트박스에 값을 설정합니다.
                formOrderOkayInstance.TextBox3.Text = productCode;
                formOrderOkayInstance.TextBox4.Text = productName;

                // formOrderOkay 폼을 보여줍니다.
                formOrderOkayInstance.Show();

                // 현재 폼(formOrderOkay2)을 닫습니다.
                this.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 텍스트박스4가 비어 있는지 확인합니다.
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                // 텍스트박스4가 비어 있으면 전체 데이터를 조회합니다.
                LoadDataIntoDataGridView();
            }
            else
            {
                // 텍스트박스4에 데이터가 있는 경우, 해당 데이터를 이용하여 조회합니다.
                SearchData(textBox4.Text);
            }
        }

        private void SearchData(string productName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT product_code, product_name FROM managerproduct.product_registration WHERE product_name = @productName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productName", productName);

                    DataTable dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());

                    // 데이터 그리드 뷰에 데이터를 설정합니다.
                    dataGridView2.Rows.Clear(); // 기존에 행이 있을 경우를 대비하여 행을 모두 지웁니다.

                    foreach (DataRow row in dataTable.Rows)
                    {
                        dataGridView2.Rows.Add(row["product_code"].ToString(), row["product_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터그리드뷰에서 선택한 행을 가져옵니다.
            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

            // 선택한 행의 데이터를 가져와서 텍스트박스에 설정합니다.
            string productCode = selectedRow.Cells[0].Value.ToString(); // 첫 번째 칸의 데이터는 인덱스 0에 위치합니다.
            string productName = selectedRow.Cells[1].Value.ToString(); // 두 번째 칸의 데이터는 인덱스 1에 위치합니다.

            // 이미 열려 있는 formOrderOkay 폼의 인스턴스를 찾습니다.
            formOrderOkay formOrderOkayInstance = Application.OpenForms.OfType<formOrderOkay>().FirstOrDefault();

            // formOrderOkay 폼의 인스턴스가 존재하지 않으면 새로 생성합니다.
            if (formOrderOkayInstance == null)
            {
                formOrderOkayInstance = new formOrderOkay();
                formOrderOkayInstance.Show();
            }

            // formOrderOkay 폼의 텍스트박스에 값을 설정합니다.
            formOrderOkayInstance.TextBox3.Text = productCode;
            formOrderOkayInstance.TextBox4.Text = productName;

            // 현재 폼을 닫습니다.
            this.Close();
        }
    }
}
