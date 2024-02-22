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
using System.Text.RegularExpressions;

namespace SuJinChemicalMES
{
    public partial class formShipment : Form
    {
        private string selectedOrderNumber;
        private DataContainer dataContainer;
        public formShipment(DataContainer container)
        {
            InitializeComponent();
            ShowGridView1();
            ShowSHdatagridview();
            PrGridView.MultiSelect = false;
            SHdatagridview.MultiSelect = false;
            CompanyCb.SelectedIndexChanged += CompanyCb_SelectedIndexChanged;
            LoadCompanies();
            DefectcauseCb.Enabled = false;
            dataContainer = container;
        }

      private void ShowGridView1()
      {
            string connectionString = "Server=10.10.32.82;Database=production_management;Uid=team;Pwd=team1234;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT order_number,company, product_code, product_name, lot_no, quantity, due_date FROM completed";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable1 = new DataTable();
                    adapter.Fill(dataTable1);
                    PrGridView.DataSource = dataTable1;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            PrGridView.ClearSelection();
      }
        private void ShowSHdatagridview()
        {
            string connectionString = "Server = 10.10.32.82;Database=quality;User Id = team; Password = team1234;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT test_results, progress, company, product_code, product_name, lot_no, quantity, order_quantity, registration_date_inspection, registrant_inspection, cause_of_defect FROM shipping_inspection_results ORDER BY registration_date_inspection DESC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable1 = new DataTable();
                    adapter.Fill(dataTable1);

                    SHdatagridview.DataSource = dataTable1;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            SHdatagridview.ClearSelection();
        }
        private void formShipment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            SHdatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SHdatagridview.Columns[1].ReadOnly = true;
            SHdatagridview.Columns[2].ReadOnly = true;
            SHdatagridview.Columns[3].ReadOnly = true;
            SHdatagridview.Columns[4].ReadOnly = true;
            SHdatagridview.Columns[5].ReadOnly = true;
            SHdatagridview.Columns[6].ReadOnly = true;
            SHdatagridview.Columns[7].ReadOnly = true;
            SHdatagridview.Columns[8].ReadOnly = true;
            SHdatagridview.Columns[9].ReadOnly = true;
            SHdatagridview.Columns[10].ReadOnly = true;
            SHdatagridview.Columns[11].ReadOnly = true;
            SHdatagridview.ClearSelection();
            PrGridView.ClearSelection();
            SHdatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

     
        private void PrGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrGridView_SelectionChanged(object sender, EventArgs e)
        {
             if (PrGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PrGridView.SelectedRows[0];

                selectedOrderNumber = selectedRow.Cells["order_number"].Value.ToString();
                label15.Text = selectedOrderNumber;
                // 선택된 행에서 회사 이름 가져오기
                string companyname = selectedRow.Cells["company_name"].Value?.ToString();
                Company_Lb.Text = companyname;

                // 선택된 행에서 제품 이름 가져오기
                string productname = selectedRow.Cells["product_name"].Value.ToString();
                Name_Lb.Text = productname;

                // 선택된 행에서 제품 코드 가져오기
                string code = selectedRow.Cells["code"].Value.ToString();
                Code_Lb.Text = code;

                // 선택된 행에서 수량 가져오기
                string Quantity = selectedRow.Cells["Ex_Quantity"].Value.ToString();
             

                // 오더 번호에서 숫자만 가져오기
                string LOTNO = selectedRow.Cells["LOTNO"].Value.ToString();
                LOT_No_Lb.Text = LOTNO;
            }
            else
            {
                label15.Text = "";
                Company_Lb.Text = "";
                Name_Lb.Text = "";
                Code_Lb.Text = "";
                LOT_No_Lb.Text = "";

            }
        }

        private void ImportBt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=10.10.32.82;Database=quality;User Id=team;Password=team1234;";
            string connectionString1 = "Server=10.10.32.82;Database=production_management;User Id=team;Password=team1234;";
            string defectCause = (defectivequantity.Text != "0") ? DefectcauseCb.SelectedItem?.ToString() : "";

            if ( defectivequantity.Text == "" || standardproduct.Text == "")
            {
                MessageBox.Show("필수항목을 입력해주세요.");
                return;
            }
            if (defectivequantity.Text != "0" && DefectcauseCb.SelectedIndex == -1)
            {
                MessageBox.Show("결함원인을 선택해주세요.");
                return;
            }

            if (defectivequantity.Text != "0" && DefectLotno.Text == "")
            {
                MessageBox.Show("불량 순번을 입력해주세요");
                return;
            }
            if (PrGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("입력하고자 하는 데이터를 선택해주세요.");
                return;
            }
            DataGridViewRow selectedRow1 = PrGridView.SelectedRows[0];
            int Quantity = Convert.ToInt32(selectedRow1.Cells["Ex_Quantity"].Value);
            int Standardproduct = Convert.ToInt32(standardproduct.Text);
            int DefectiveQuantity = Convert.ToInt32(defectivequantity.Text);
            if (Standardproduct + DefectiveQuantity == Quantity)
            {
                DialogResult result = MessageBox.Show("등록하시겠습니까?", "등록 확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = PrGridView.SelectedRows[0];
                    string selectedOrderNumber = selectedRow.Cells["order_number"].Value.ToString();
                    string selectedCompanyName = selectedRow.Cells["company_name"].Value?.ToString();
                    string selectedProductName = selectedRow.Cells["product_name"].Value.ToString();
                    string selectedCode = selectedRow.Cells["code"].Value.ToString();
                    string selectedLOT_No = selectedRow.Cells["LOTNO"].Value.ToString();
                    string Duedate = selectedRow.Cells["due_date"].Value.ToString();
                    string OrderQuantity = selectedRow.Cells["Ex_Quantity"].Value.ToString();
                    string DefectLotNo = DefectLotno.Text;
                    DateTime today = DateTime.Today;

                  //  string formattedDate = today.ToString("yyyyMMdd");

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT due_date, order_quantity FROM shipping_inspection_results WHERE lot_no = @lot_no";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@lot_no", selectedLOT_No);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Duedate = reader["due_date"].ToString();
                                OrderQuantity = reader["order_quantity"].ToString();
                            }
                        }
                    }
                    using (MySqlConnection connection = new MySqlConnection(connectionString1)) //작은데이터그리드뷰 데이터 삭제
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM completed WHERE order_number = @orderNumber AND product_name = @productName AND product_code = @productCode";
                        MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@orderNumber", selectedOrderNumber);
                        deleteCommand.Parameters.AddWithValue("@productName", selectedProductName);
                        deleteCommand.Parameters.AddWithValue("@productCode", selectedCode);
                        deleteCommand.ExecuteNonQuery();
                    }
                    if (Standardproduct != 0)
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string checkQuery = "SELECT COUNT(*) FROM shipping_inspection_results WHERE lot_no = @lotNo";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No);
                            int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (rowCount > 0)
                            {
                                string updateQuery = "UPDATE shipping_inspection_results SET quantity = quantity + @quantity WHERE lot_no = @lotNo";
                                MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@quantity", Standardproduct);
                                updateCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No);
                                updateCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                string PQuery = "INSERT INTO shipping_inspection_results (progress, test_results, order_number, due_date, company, product_code, product_name, lot_no, quantity, order_quantity, registration_date_inspection, registrant_inspection) VALUES (@inspectionType, @data, @selectedOrderNumber, @Duedate, @companyName, @productCode, @productName, @lotNo, @quantity, @Orderquantity, @inspectionDate, @inspector)";
                                MySqlCommand insertCommand = new MySqlCommand(PQuery, connection);
                                insertCommand.Parameters.AddWithValue("@inspectionType", "출하검사");
                                insertCommand.Parameters.AddWithValue("@data", "PASS");
                                insertCommand.Parameters.AddWithValue("@selectedOrderNumber", selectedOrderNumber);
                                insertCommand.Parameters.AddWithValue("@Duedate", Duedate);
                                insertCommand.Parameters.AddWithValue("@companyName", selectedCompanyName);
                                insertCommand.Parameters.AddWithValue("@productCode", selectedCode);
                                insertCommand.Parameters.AddWithValue("@productName", selectedProductName);
                                insertCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No);
                                insertCommand.Parameters.AddWithValue("@quantity", Standardproduct);
                                insertCommand.Parameters.AddWithValue("@Orderquantity", OrderQuantity);
                                insertCommand.Parameters.AddWithValue("@inspectionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                                insertCommand.Parameters.AddWithValue("@inspector", dataContainer.Name);
                                
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        string connectionString2 = "Server=10.10.32.82;Database=accumulated_data;Uid=team;Pwd=team1234;";
                        using (MySqlConnection connection = new MySqlConnection(connectionString2))
                        {
                            connection.Open();

                            string PQuery = "INSERT INTO accumulated_data (progress, test_results, order_number, due_date, supplier, product_code, " +
                                "product_name, lot_no, quantity, request_quantity, registration_date, registrant) " +
                                "VALUES (@inspectionType, @data, @selectedOrderNumber, @Duedate, @companyName, @productCode, @productName, @lotNo, @quantity, @Orderquantity, @inspectionDate, @inspector )";
                            MySqlCommand insertCommand = new MySqlCommand(PQuery, connection);
                            insertCommand.Parameters.AddWithValue("@inspectionType", "출하검사");
                            insertCommand.Parameters.AddWithValue("@data", "PASS");
                            insertCommand.Parameters.AddWithValue("@selectedOrderNumber", selectedOrderNumber);
                            insertCommand.Parameters.AddWithValue("@Duedate", Duedate);
                            insertCommand.Parameters.AddWithValue("@companyName", selectedCompanyName);
                            insertCommand.Parameters.AddWithValue("@productCode", selectedCode);
                            insertCommand.Parameters.AddWithValue("@productName", selectedProductName);
                            insertCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No);
                            insertCommand.Parameters.AddWithValue("@quantity", Standardproduct);
                            insertCommand.Parameters.AddWithValue("@Orderquantity", OrderQuantity);
                            insertCommand.Parameters.AddWithValue("@inspectionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                            insertCommand.Parameters.AddWithValue("@inspector", dataContainer.Name);
                           
                            insertCommand.ExecuteNonQuery();
                        }

                    }
                    if (DefectiveQuantity != 0)
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string checkQuery = "SELECT COUNT(*) FROM shipping_inspection_results WHERE lot_no = @lotNo";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No + DefectLotNo);
                            int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (rowCount > 0)
                            {
                                string updateQuery = "UPDATE shipping_inspection_results SET quantity = quantity + @quantity WHERE lot_no = @lotNo";
                                MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                                updateCommand.Parameters.AddWithValue("@quantity", DefectiveQuantity);
                                updateCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No + DefectLotNo);
                                updateCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                string FQuery = "INSERT INTO shipping_inspection_results (progress, test_results, order_number, due_date, company, product_code, product_name, lot_no, quantity, order_quantity, registration_date_inspection, registrant_inspection, cause_of_defect) VALUES (@inspectionType, @data, @selectedOrderNumber, @Duedate, @companyName, @productCode, @productName, @lotNo, @quantity, @Orderquantity, @inspectionDate, @inspector, @defectCause)";
                                MySqlCommand insertCommand = new MySqlCommand(FQuery, connection);
                                insertCommand.Parameters.AddWithValue("@inspectionType", "출하검사");
                                insertCommand.Parameters.AddWithValue("@data", "FAIL");
                                insertCommand.Parameters.AddWithValue("@selectedOrderNumber", selectedOrderNumber);
                                insertCommand.Parameters.AddWithValue("@Duedate", Duedate);
                                insertCommand.Parameters.AddWithValue("@companyName", selectedCompanyName);
                                insertCommand.Parameters.AddWithValue("@productCode", selectedCode);
                                insertCommand.Parameters.AddWithValue("@productName", selectedProductName);
                                insertCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No + DefectLotNo);
                                insertCommand.Parameters.AddWithValue("@quantity", DefectiveQuantity);
                                insertCommand.Parameters.AddWithValue("@Orderquantity", OrderQuantity);
                                insertCommand.Parameters.AddWithValue("@inspectionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                                insertCommand.Parameters.AddWithValue("@inspector", dataContainer.Name);
                                insertCommand.Parameters.AddWithValue("@defectCause", defectCause);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        string connectionString2 = "Server=10.10.32.82;Database=accumulated_data;Uid=team;Pwd=team1234;";
                        using (MySqlConnection connection = new MySqlConnection(connectionString2))
                        {
                            connection.Open();

                            string FQuery = "INSERT INTO accumulated_data (progress, test_results, order_number, due_date, supplier, product_code, " +
                                "product_name, lot_no, quantity, request_quantity, registration_date, registrant, cause_of_defect) " +
                                "VALUES (@inspectionType, @data, @selectedOrderNumber, @Duedate, @companyName, @productCode, @productName, @lotNo, @quantity, @Orderquantity, @inspectionDate, @inspector, @defectCause)";
                            MySqlCommand insertCommand = new MySqlCommand(FQuery, connection);
                            insertCommand.Parameters.AddWithValue("@inspectionType", "출하검사");
                            insertCommand.Parameters.AddWithValue("@data", "FAIL");
                            insertCommand.Parameters.AddWithValue("@selectedOrderNumber", selectedOrderNumber);
                            insertCommand.Parameters.AddWithValue("@Duedate", Duedate);
                            insertCommand.Parameters.AddWithValue("@companyName", selectedCompanyName);
                            insertCommand.Parameters.AddWithValue("@productCode", selectedCode);
                            insertCommand.Parameters.AddWithValue("@productName", selectedProductName);
                            insertCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No + DefectLotNo);
                            insertCommand.Parameters.AddWithValue("@quantity", DefectiveQuantity);
                            insertCommand.Parameters.AddWithValue("@Orderquantity", OrderQuantity);
                            insertCommand.Parameters.AddWithValue("@inspectionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                            insertCommand.Parameters.AddWithValue("@inspector", dataContainer.Name);
                            insertCommand.Parameters.AddWithValue("@defectCause", defectCause);
                            insertCommand.ExecuteNonQuery();
                        }

                    }
                    // 선택 해제
                    PrGridView.Rows.RemoveAt(PrGridView.SelectedRows[0].Index);
                    SHdatagridview.ClearSelection();
                    MessageBox.Show("데이터가 등록되었습니다.");
                    ShowSHdatagridview();
                }

            }
            else
            {
                MessageBox.Show("정상제품 수량과 불량제품 수량의 합이 선택된 행의 수량과 같아야 합니다.");
            }


            
        }

            private void Search_Bt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=10.10.32.82;Database=quality;User Id=team;Password=team1234;";
            if (string.IsNullOrEmpty(product_nametb.Text) &&
                string.IsNullOrEmpty(product_codetb.Text) &&
                string.IsNullOrEmpty(CompanyCb.Text) &&
                string.IsNullOrEmpty(LotNo_tb.Text) &&
                    dateTimePicker1.Enabled == false)
            {
                MessageBox.Show("항목 중 하나 이상을 입력해주세요.", "입력 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = product_nametb.Text;
            string productCode = product_codetb.Text;
            string companyName = CompanyCb.Text;
            string lot_no = LotNo_tb.Text;
            string query = "SELECT progress, test_results, company, product_code, product_name, lot_no, quantity, order_quantity, registration_date_inspection,registrant_inspection, cause_of_defect FROM shipping_inspection_results WHERE 1=1 ";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            // 각 조건에 따라 쿼리와 파라미터 추가
            if (!string.IsNullOrEmpty(productName))
            {
                query += "AND product_name LIKE @productName ";
                parameters.Add(new MySqlParameter("@productName", $"%{productName}%"));
            }
            if (!string.IsNullOrEmpty(productCode))
            {
                query += "AND product_code LIKE @productCode ";
                parameters.Add(new MySqlParameter("@productCode", $"%{productCode}%"));
            }
            if (!string.IsNullOrEmpty(companyName))
            {
                query += "AND company LIKE @companyName ";
                parameters.Add(new MySqlParameter("@companyName", $"%{companyName}%"));
            }
            if (!string.IsNullOrEmpty(lot_no))
            {
                query += "AND lot_no LIKE @lot_no ";
                parameters.Add(new MySqlParameter("@lot_no", $"%{lot_no}%"));

            }
            if (dateTimePicker1.Enabled == true)
            {
                query += "AND registration_date_inspection = @Date ";
                parameters.Add(new MySqlParameter("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd")));
            }

            // 쿼리 마무리
            query += ";";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddRange(parameters.ToArray());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 결과가 없는 경우 메시지 표시
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("일치하는 항목이 없습니다.", "검색 결과 없음", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SHdatagridview.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
            SHdatagridview.ClearSelection();
        
    }

     
        private void Renewalbt_Click(object sender, EventArgs e)
        {
            ShowSHdatagridview();
            LoadCompanies();
            ShowGridView1();
            CompanyCb.SelectedIndex = -1;
            product_nametb.Text = "";
            product_codetb.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            LotNo_tb.Text = "";
            dateTimePicker1.Enabled = true;
        }
        private void LoadCompanies()
        {
            string connectionString = "Server = 10.10.32.82;Database=quality;User Id = team; Password = team1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT company FROM shipping_inspection_results"; // 중복 제거 쿼리
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string companyName = reader.GetString("company");
                        if (!CompanyCb.Items.Contains(companyName)) // 중복 검사
                        {
                            CompanyCb.Items.Add(companyName);
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void CompanyCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server = 10.10.32.82;Database=quality;User Id = team; Password = team1234;";
            if (CompanyCb.SelectedItem != null)
            {
                string selectedCompanyName = CompanyCb.SelectedItem.ToString();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM shipping_inspection_results WHERE company = @companyName";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@companyName", selectedCompanyName);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string companyInfo = $"Company Name: {reader["company"]}\n";

                        }

                        reader.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void DatecancelBt_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }

        private void DefectcauseCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void defectivequantity_TextChanged(object sender, EventArgs e)
        {
            if (defectivequantity.Text == "0")
            {
                DefectcauseCb.Enabled = false;
            }
            else
            {
                DefectcauseCb.Enabled = true;

            }
        }
    }
}
