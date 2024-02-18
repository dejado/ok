using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuJinChemicalMES;

namespace SuJinChemicalMES
{
    public partial class formProductAsk : Form
    {

        // MySQL 연결 문자열
        private string connectionString = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";


        public formProductAsk()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
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




        private void Ask_Click(object sender, EventArgs e)
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

        private void SearchData(string partialProductName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // 부분 일치하는 제품명을 검색하는 SQL 쿼리를 작성합니다.
                    string query = "SELECT product_code, product_name FROM managerproduct.product_registration WHERE product_name LIKE @partialProductName";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // 부분 일치하는 제품명을 파라미터로 전달합니다.
                    command.Parameters.AddWithValue("@partialProductName", "%" + partialProductName + "%");

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

        private void Choose_bt_Click(object sender, EventArgs e)
        {
            // DataGridView에서 선택한 행을 가져옵니다. 선택한 행이 없으면 함수를 종료합니다.
            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

            // 선택한 행의 데이터를 가져와서 텍스트박스에 설정합니다.
            DataStorage.ProductCode = selectedRow.Cells[0].Value.ToString(); // 첫 번째 칸의 데이터는 인덱스 0에 위치합니다.
            DataStorage.ProductName = selectedRow.Cells[1].Value.ToString(); // 두 번째 칸의 데이터는 인덱스 1에 위치합니다.



            // 현재 폼을 닫습니다.
            this.Close();
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridView2.Rows[e.RowIndex];
                clickedRow.Selected = true;
            }
        }
    }

}
