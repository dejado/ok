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
    public partial class formImport : Form
    {
        private string selectedOrderNumber;
        private DataContainer dataContainer;
        public formImport(DataContainer container)
        {
            InitializeComponent();
            LoadDataIntoDataGridView(); //큰 그리드 데이터 로드
            LoadCompanies();
            LoadSmallDataGridView(); //작은 그리드 로드
            CompanyCb.SelectedIndexChanged += CompanyCb_SelectedIndexChanged;
            dataGridView1.MultiSelect = false; //한줄만 선택할 수 있게
            QCdatagridview.MultiSelect = false;
            DefectcauseCb.Enabled = false;
            
            dataContainer = container;
        }

        private void formImport_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            QCdatagridview.ClearSelection();
            QCdatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
            QCdatagridview.Columns[1].ReadOnly = true;
            QCdatagridview.Columns[2].ReadOnly = true;
            QCdatagridview.Columns[3].ReadOnly = true;
            QCdatagridview.Columns[4].ReadOnly = true;
            QCdatagridview.Columns[5].ReadOnly = true;
            QCdatagridview.Columns[6].ReadOnly = true;
            QCdatagridview.Columns[7].ReadOnly = true;
            QCdatagridview.Columns[8].ReadOnly = true;
            QCdatagridview.Columns[9].ReadOnly = true;
            QCdatagridview.Columns[10].ReadOnly = true;

            QCdatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ImportBt_Click(object sender, EventArgs e)
        {

            string defectCause = (ResultCb.SelectedIndex == 1) ? DefectcauseCb.SelectedItem?.ToString() : "";
            if (ResultCb.SelectedItem == null)
            {
                MessageBox.Show("필수항목을 입력해주세요.");
                return;
            }
            if (ResultCb.SelectedIndex == 1 && string.IsNullOrEmpty(defectCause))
            {
                MessageBox.Show("불량원인을 선택해주세요.");
                return;
            }

            string selectedData = (ResultCb.SelectedItem != null) ? ResultCb.SelectedItem.ToString() : "";

            if (!string.IsNullOrEmpty(selectedOrderNumber))
            {
                string connectionString = "Server=10.10.32.82;Database=quality;User Id=team;Password=team1234;";
                string connectionString1 = "Server=10.10.32.82;Database=managerproduct;User Id=team;Password=team1234;";
                string connectionString2 = "Server=10.10.32.82;Database=accumulated_data;Uid=team;Pwd=team1234;";
                DialogResult result = MessageBox.Show("등록하시겠습니까?", "등록 확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string selectedOrderNumber = selectedRow.Cells["order_number"].Value.ToString();
                    string selectedCompanyName = selectedRow.Cells["company_name"].Value?.ToString();
                    string selectedProductName = selectedRow.Cells["product_name"].Value.ToString();
                    string selectedCode = selectedRow.Cells["code"].Value.ToString();
                    string selectedQuantity = selectedRow.Cells["Ex_Quantity"].Value.ToString();
                    string selectedLOT_No = Regex.Replace(selectedOrderNumber, "[^0-9]", "");

                    using (MySqlConnection connection = new MySqlConnection(connectionString1))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM order_registration WHERE order_number = @orderNumber AND product_name = @productName AND product_code = @productCode";
                        MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@orderNumber", selectedOrderNumber);
                        deleteCommand.Parameters.AddWithValue("@productName", selectedProductName);
                        deleteCommand.Parameters.AddWithValue("@productCode", selectedCode);
                        deleteCommand.ExecuteNonQuery();
                    }
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO import_inspection (order_number, progress, test_results, company, product_code, product_name, lot_no, quantity, registration_date_import," +
                            " registrant_import, cause_of_defect) VALUES (@Order_number, @inspectionType, @data, @companyName, @productCode, @productName, " +
                            "@lotNo, @quantity, @inspectionDate, @inspector, @defectCause)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@Order_number", selectedOrderNumber);
                        insertCommand.Parameters.AddWithValue("@inspectionType", "수입검사");
                        insertCommand.Parameters.AddWithValue("@data", selectedData);
                        insertCommand.Parameters.AddWithValue("@companyName", selectedCompanyName);
                        insertCommand.Parameters.AddWithValue("@productCode", selectedCode);
                        insertCommand.Parameters.AddWithValue("@productName", selectedProductName);
                        insertCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No);
                        insertCommand.Parameters.AddWithValue("@quantity", selectedQuantity);
                        insertCommand.Parameters.AddWithValue("@inspectionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        insertCommand.Parameters.AddWithValue("@inspector", dataContainer.Name);
                        insertCommand.Parameters.AddWithValue("@defectCause", defectCause);
                        insertCommand.ExecuteNonQuery();
                    }
                    using (MySqlConnection connection = new MySqlConnection(connectionString2))
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO accumulated_data (order_number,progress, test_results, company, product_code, product_name, lot_no, quantity, registration_date," +
                                    " registrant, cause_of_defect) VALUES (@Order_number,@inspectionType, @data, @companyName, @productCode, @productName, " +
                                    "@lotNo, @quantity, @inspectionDate, @inspector, @defectCause)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@Order_number", selectedOrderNumber);
                        insertCommand.Parameters.AddWithValue("@inspectionType", "수입검사");
                        insertCommand.Parameters.AddWithValue("@data", selectedData);
                        insertCommand.Parameters.AddWithValue("@companyName", selectedCompanyName);
                        insertCommand.Parameters.AddWithValue("@productCode", selectedCode);
                        insertCommand.Parameters.AddWithValue("@productName", selectedProductName);
                        insertCommand.Parameters.AddWithValue("@lotNo", selectedLOT_No);
                        insertCommand.Parameters.AddWithValue("@quantity", selectedQuantity);
                        insertCommand.Parameters.AddWithValue("@inspectionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        insertCommand.Parameters.AddWithValue("@inspector", dataContainer.Name);
                        insertCommand.Parameters.AddWithValue("@defectCause", defectCause);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                else if (result == DialogResult.No)
                {
                   
                    return;
                }


                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    QCdatagridview.ClearSelection();
                    MessageBox.Show("데이터가 등록되었습니다.");
                    LoadDataIntoDataGridView();
                
            }


            else
            {
                MessageBox.Show("데이터를 선택하세요.");
            }
        }





        private void Search_Bt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=10.10.32.82;Database=quality;User Id=team;Password=team1234;";
            if (string.IsNullOrEmpty(product_nametb.Text) &&
                string.IsNullOrEmpty(product_codetb.Text) &&
                string.IsNullOrEmpty(CompanyCb.Text) &&
                string.IsNullOrEmpty(LotNo_tb.Text) &&
                Product_TypeCb.SelectedItem == null &&
                    dateTimePicker1.Enabled == false)
            {
                MessageBox.Show("항목 중 하나 이상을 입력해주세요.", "입력 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = product_nametb.Text;
            string productCode = product_codetb.Text;
            string companyName = CompanyCb.Text;
            string productType = Product_TypeCb.SelectedItem?.ToString();
            string lot_no = LotNo_tb.Text;
            string query = "SELECT progress, test_results, company, product_code, product_name, lot_no, quantity, registration_date_import, registrant_import,cause_of_defect FROM import_inspection WHERE 1=1 ";

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
            if (!string.IsNullOrEmpty(productType))
            {
                if (productType == "제품")
                {
                    query += "AND NOT (product_name LIKE '%황산%' OR product_name LIKE '알코올%' OR product_name LIKE '%염산%' OR product_name LIKE '%암모니아%' OR product_name LIKE '과산화%' OR product_name LIKE '%인산%' OR product_name LIKE '%알카리%' OR product_name LIKE '%불산%' OR product_name LIKE '%질산%') ";
                }
                else if (productType == "부자재")
                {
                    query += "AND (product_name LIKE '%황산%' OR product_name LIKE '알코올%' OR product_name LIKE '%염산%' OR product_name LIKE '%암모니아%' OR product_name LIKE '%인산%' OR product_name LIKE '%알카리%' OR product_name LIKE '과산화%' OR product_name LIKE '%불산%' OR product_name LIKE '%질산%') ";
                }
            }
            if (dateTimePicker1.Enabled == true)
            {
                query += "AND registration_date_import = @importDate ";
                parameters.Add(new MySqlParameter("@importDate", dateTimePicker1.Value.ToString("yyyy-MM-dd")));
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
                        QCdatagridview.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
            QCdatagridview.ClearSelection();
        }

        private void Renewalbt_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            LoadSmallDataGridView();
            LoadCompanies();
            CompanyCb.SelectedIndex = -1;
            Product_TypeCb.SelectedIndex = -1;
            product_nametb.Text = "";
            product_codetb.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            LotNo_tb.Text = "";
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Server = 10.10.32.82;Database=quality;User Id = team; Password = team1234;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT progress, test_results, company, product_code, product_name, lot_no, quantity, registration_date_import, registrant_import, cause_of_defect FROM import_inspection";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable1 = new DataTable();
                    adapter.Fill(dataTable1);

                    QCdatagridview.DataSource = dataTable1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            QCdatagridview.ClearSelection();

        }
        private void LoadSmallDataGridView()
        {
          
            string connectionString1 = "Server = 10.10.32.82; Database = managerproduct; User Id = team; Password = team1234";
            using (MySqlConnection connection = new MySqlConnection(connectionString1))
            {
                try
                {
                    connection.Open();
                    string query = @"
            SELECT orr.order_number, pr.company, pr.product_code, pr.product_name, orr.expected_production_quantity 
            FROM order_registration orr 
            INNER JOIN product_registration pr 
            ON orr.product_code = pr.product_code AND orr.product_name = pr.product_name";

                    MySqlCommand command = new MySqlCommand(query, connection);

                 
                    MySqlDataReader reader = command.ExecuteReader();

          
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("오류 발생: " + ex.Message);
                }
            }
            dataGridView1.ClearSelection();
        }

        private void LoadCompanies()
        {
            string connectionString = "Server = 10.10.32.82;Database=quality;User Id = team; Password = team1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT company FROM import_inspection"; // 중복 제거 쿼리
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
                        string query = "SELECT * FROM import_inspection WHERE company = @companyName";
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
      

        private void DefectcauseCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResultCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultCb.SelectedIndex == 1)
            {
                DefectcauseCb.Items.Add("파손");
                DefectcauseCb.Items.Add("크랙");
                DefectcauseCb.Items.Add("오염");
                DefectcauseCb.Items.Add("부식");
                DefectcauseCb.Enabled = true;
            }
            else
            {
                DefectcauseCb.Items.Clear();
                DefectcauseCb.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

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
                Quantity_Lb.Text = Quantity;

                // 오더 번호에서 숫자만 가져오기
                string orderNumberOnlyDigits = Regex.Replace(selectedOrderNumber, "[^0-9]", ""); // 숫자 이외의 문자 제거
                LOT_No_Lb.Text = orderNumberOnlyDigits;
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

        private void Product_TypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_Lb_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QCdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
