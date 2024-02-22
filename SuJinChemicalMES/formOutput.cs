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

namespace SuJinChemicalMES
{
    public partial class formOutput : Form
    {
        private DataContainer dataContainer;

        public formOutput(DataContainer container)
        {
            InitializeComponent();
            ShowGrid();
            Output_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutOk_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataContainer = container;

        }

        public void ShowGrid()
        {
            Output_grid.Rows.Clear();
            OutOk_grid.Rows.Clear();

            // 첫 번째 MySQL 연결
            string connectionIncoming = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection1 = new MySqlConnection(connectionIncoming))
            {
                connection1.Open();

                string Query = "SELECT * from shipment";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection1);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                    comboBoxCell.Items.AddRange("A", "B", "C", "D", "E"); // 콤보박스 아이템 설정

                    Output_grid.Rows.Add(false, reader["progress"], reader["order_number"], reader["due_date"],
                        reader["company"], reader["product_code"],
                         reader["product_name"], reader["lot_no"], reader["quantity"], reader["order_quantity"],
                        reader["registration_date_shipment"], reader["registrant_shipment"], reader["location"]);
                }

                // 두 번째 MySQL 연결
                string connectionInspection = "Server=10.10.32.82;Database=quality;Uid=team;Pwd=team1234;";
                using (MySqlConnection connection2 = new MySqlConnection(connectionInspection))
                {
                    connection2.Open();

                    string Query2 = "SELECT * from shipping_inspection_results";
                    //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                    MySqlCommand command2 = new MySqlCommand(Query2, connection2);
                    MySqlDataReader reader2 = command2.ExecuteReader();

                    while (reader2.Read())
                    {
                        OutOk_grid.Rows.Add(false, null, reader2["test_results"], reader2["order_number"], reader2["due_date"],
                            reader2["progress"], reader2["company"], reader2["product_code"],
                             reader2["product_name"], reader2["lot_no"], reader2["quantity"], reader2["order_quantity"],
                            reader2["registration_date_inspection"], reader2["registrant_inspection"], reader2["cause_of_defect"]);
                    }
                }
            }
            // DataGridView의 초기 데이터를 저장할 Tag를 설정
            foreach (DataGridViewRow row in Output_grid.Rows)
            {
                row.Tag = row.Cells[12].Value;
            }
        }


        private void OutRe_bt_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void OutInquiry_bt_Click(object sender, EventArgs e)
        {
            string company = (OutCompany_com.SelectedItem != null) ? OutCompany_com.SelectedItem.ToString() : "";
            string name = OutName_txt.Text;
            string code = OutCode_txt.Text;
            string warehouse = (OutWarehouse_com.SelectedItem != null) ? OutWarehouse_com.SelectedItem.ToString() : "";
            string date1 = (OutDate1.Value != DateTime.MinValue) ? OutDate1.Value.ToString("yyyyMMdd") : null;



        }

        private void OutOkRe_bt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
                    foreach (DataGridViewRow row in OutOk_grid.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                        // 체크된 행인지 확인하고 체크된 경우에만 MySQL 테이블로 데이터를 전송합니다.
                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                        {
                            // MySQL 데이터베이스로 전송할 데이터 추출
                            string Outlocation = row.Cells[1].Value.ToString();
                            string order_num = row.Cells[3].Value.ToString();
                            string due_date = row.Cells[4].Value.ToString();
                            string progress = "출고";
                            string company = row.Cells[6].Value.ToString();
                            string productCode = row.Cells[7].Value.ToString();
                            string productName = row.Cells[8].Value.ToString();
                            string lotNo = row.Cells[9].Value.ToString();
                            string quantity = row.Cells[10].Value.ToString();
                            string order_quantity = row.Cells[11].Value.ToString();
                            string date = DateTime.Now.ToString("yyyy-MM-dd");
                            string registrant = dataContainer.Name; 
                            string result = row.Cells[2].Value.ToString();
                          


                            // MySQL 데이터베이스로 데이터 전송을 위한 SQL 쿼리 작성
                            string query = $"INSERT INTO shipment (progress,order_number,due_date," +
                                $"company,product_code,product_name,lot_no,quantity,order_quantity,registration_date_shipment," +
                                $"registrant_shipment,location,test_results) VALUES ('{progress}', '{order_num}','{due_date}', '{company}', " +
                                $"'{productCode}', '{productName}', '{lotNo}', '{quantity}','{order_quantity}',  '{date}', '{registrant}'," +
                                $" '{Outlocation}','{result}')";

                            // 쿼리 실행
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            DeleteInsert(lotNo);
                        }
                    }

                    // 데이터 전송 후 작업 완료 메시지 표시
                    MessageBox.Show("데이터 전송이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    // MySQL 예외가 발생한 경우 중복된 데이터가 있음을 사용자에게 알림
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("중복된 데이터가 있습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            string connectionString2 = "Server=10.10.32.82;Database=accumulated_data;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString2))
            {
                try
                {
                    connection.Open();

                    // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
                    foreach (DataGridViewRow row in OutOk_grid.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                        // 체크된 행인지 확인하고 체크된 경우에만 MySQL 테이블로 데이터를 전송합니다.
                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                        {
                            // MySQL 데이터베이스로 전송할 데이터 추출
                            string Outlocation = row.Cells[1].Value.ToString();
                            string order_num = row.Cells[3].Value.ToString();
                            string due_date = row.Cells[4].Value.ToString();
                            string progress = "출고";
                            string company = row.Cells[6].Value.ToString();
                            string productCode = row.Cells[7].Value.ToString();
                            string productName = row.Cells[8].Value.ToString();
                            string lotNo = row.Cells[9].Value.ToString();
                            string quantity = row.Cells[10].Value.ToString();
                            string order_quantity = row.Cells[11].Value.ToString();
                            string date = DateTime.Now.ToString("yyyy-MM-dd");
                            string registrant = dataContainer.Name;
                            string result = row.Cells[2].Value.ToString();
                        //    string reason = row.Cells[12].Value.ToString();


                            // MySQL 데이터베이스로 데이터 전송을 위한 SQL 쿼리 작성
                            string query = $"INSERT INTO accumulated_data (progress,order_number,due_date," +
                                $"supplier,product_code,product_name,lot_no,quantity,production_plan_quantity,registration_date," +
                                $"registrant,warehouse_location,test_results) VALUES ('{progress}', '{order_num}','{due_date}', '{company}', " +
                                $"'{productCode}', '{productName}', '{lotNo}', '{quantity}','{order_quantity}',  '{date}', '{registrant}'," +
                                $" '{Outlocation}','{result}')";

                            // 쿼리 실행
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 데이터 전송 후 작업 완료 메시지 표시
               //     MessageBox.Show("데이터 전송이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ShowGrid();
        }

        public void DeleteInsert(string LotNum)
        {
            string cnn = "Server=10.10.32.82;Database=quality;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                // SQL 서버와 연결, database=스키마 이름
                connection.Open();

                // 입력할 문자 받아옴
                string insertQuery = "DELETE FROM shipping_inspection_results WHERE lot_no=@LotNum";

                // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                // 위 정보를 command 변수에 저장
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@LotNum", LotNum);

                command.ExecuteNonQuery();
               
                connection.Close();
            }
        }

        private void OutRe_bt_Click_1(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void OutModify_bt_Click(object sender, EventArgs e)
        {
            // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
            foreach (DataGridViewRow row in Output_grid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    // MySQL 데이터베이스로 전송할 데이터 추출
                    string Lot = row.Cells[7].Value.ToString();
                    string Inlocation = row.Cells[12].Value.ToString();

                    ChangeLocation(Lot, Inlocation);
                }
            }
            ShowGrid();
        }

        public void ChangeLocation(string Lot, string Location)
        {
            MySqlConnection connection = new MySqlConnection("Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();

            string update = string.Format("UPDATE shipment SET location= '{0}' WHERE lot_no='{1}'", Location, Lot);


            MySqlCommand command = new MySqlCommand(update, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("수정되었습니다.");
            connection.Close();
        }


        private void OutDateX_bt_Click(object sender, EventArgs e)
        {
            OutDate1.Value = new DateTime(1989, 01, 01);
        }

        private void Output_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int targetColumnIndex = 12;

            if (e.RowIndex >= 0 && e.ColumnIndex == targetColumnIndex)
            {
                DataGridViewCell currentCell = Output_grid.Rows[e.RowIndex].Cells[targetColumnIndex];
                DataGridViewCheckBoxCell checkBoxCell = Output_grid.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;

                // 현재 값과 기존 값이 다를 때 체크박스를 활성화
                if (!object.Equals(currentCell.Value, currentCell.OwningRow.Tag))
                {
                    checkBoxCell.Value = true;
                }
            }
        }

        private void OutputAsk_bt_Click(object sender, EventArgs e)
        {
            string company = (OutCompany_com.SelectedItem != null) ? OutCompany_com.SelectedItem.ToString() : "";
            string name = OutName_txt.Text;
            string code = OutCode_txt.Text;
            string warehouse = (OutWarehouse_com.SelectedItem != null) ? OutWarehouse_com.SelectedItem.ToString() : "";
            string date = (OutDate1.Value != new DateTime(1989, 01, 01)) ? OutDate1.Value.ToString("yyyy-MM-dd") : null;

            ShowGrid(company, name, code, warehouse, date);
        }

        public void ShowGrid(string company, string name, string code, string warehouse, string date)
        {
            Output_grid.Rows.Clear();

            try
            {
                MySqlConnection connection = new MySqlConnection("Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;");
                connection.Open();

                // 데이터베이스에서 필요한 정보를 가져올 SQL 쿼리 작성
                string query = "SELECT * FROM shipment WHERE 1=1";

                if (!string.IsNullOrEmpty(company))
                    query += " AND company = @company";
                if (!string.IsNullOrEmpty(name))
                    query += " AND product_name = @name";
                if (!string.IsNullOrEmpty(code))
                    query += " AND product_code = @code";
                if (!string.IsNullOrEmpty(warehouse))
                    query += " AND location = @warehouse";
                if (!string.IsNullOrEmpty(date))
                    query += " AND registration_date_shipment= @date";

                MySqlCommand command = new MySqlCommand(query, connection);

                // 매개변수 추가
                command.Parameters.AddWithValue("@company", company);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@warehouse", warehouse);
                command.Parameters.AddWithValue("@date", date);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Output_grid.Rows.Add(false, reader["progress"], reader["order_number"], reader["due_date"],
                        reader["company"], reader["product_code"],
                         reader["product_name"], reader["lot_no"], reader["quantity"], reader["order_quantity"],
                        reader["registration_date_shipment"], reader["registrant_shipment"], reader["location"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OutDelete_bt_Click(object sender, EventArgs e)
        {
            // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
            foreach (DataGridViewRow row in Output_grid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    // MySQL 데이터베이스로 전송할 데이터 추출
                    string Lot = row.Cells[7].Value.ToString();

                    DeleteInput(Lot);

                }
            }
            ShowGrid();
        }
        public void DeleteInput(string LotNum)
        {
            string cnn = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                // SQL 서버와 연결, database=스키마 이름
                connection.Open();

                // 입력할 문자 받아옴
                string insertQuery = "DELETE FROM shipment WHERE lot_no=@LotNum";

                // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                // 위 정보를 command 변수에 저장
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@LotNum", LotNum);

                command.ExecuteNonQuery();
                
                connection.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formOutput_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            OutOk_grid.ClearSelection();
            Output_grid.ClearSelection();
        }
    }
}
