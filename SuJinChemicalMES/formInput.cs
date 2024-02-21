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
using System.Xml.Linq;
using SuJinChemicalMES;

namespace SuJinChemicalMES
{
    public partial class formInput : Form
    {
        private DataContainer dataContainer;

        public formInput(DataContainer dataContainer)
        {
            InitializeComponent();
            ShowGrid();
            Input_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InputOk_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Input_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataContainer = dataContainer;
        }

        public void ShowGrid()
        {
            Input_grid.Rows.Clear();
            InputOk_grid.Rows.Clear();

            // 첫 번째 MySQL 연결
            string connectionIncoming = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection1 = new MySqlConnection(connectionIncoming))
            {
                connection1.Open();

                string Query = "SELECT * from incoming ORDER BY lot_no ASC";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection1);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {


                    Input_grid.Rows.Add(false, reader["progress"], reader["company"], reader["product_code"],
                         reader["product_name"], reader["lot_no"], reader["quantity"],
                        reader["registration_date_incoming"], reader["registrant_incoming"], reader["location"]);
                }

                // 두 번째 MySQL 연결
                string connectionInspection = "Server=10.10.32.82;Database=quality;Uid=team;Pwd=team1234;";
                using (MySqlConnection connection2 = new MySqlConnection(connectionInspection))
                {
                    connection2.Open();

                    string Query2 = "SELECT * from import_inspection";
                    //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                    MySqlCommand command2 = new MySqlCommand(Query2, connection2);
                    MySqlDataReader reader2 = command2.ExecuteReader();

                    while (reader2.Read())
                    {
                        DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                        comboBoxCell.Items.AddRange("양품IA", "부자재IB", "반품"); // 콤보박스 아이템 설정

                        InputOk_grid.Rows.Add(false, null, reader2["progress"], reader2["test_results"], reader2["company"],
                            reader2["product_code"], reader2["product_name"], reader2["lot_no"], reader2["quantity"],
                            reader2["registration_date_import"], reader2["registrant_import"]);
                    }
                }
            }
            
            // DataGridView의 초기 데이터를 저장할 Tag를 설정
            foreach (DataGridViewRow row in Input_grid.Rows)
            {
                row.Tag = row.Cells[9].Value;
            }
        }

        private void formInput_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            InputOk_grid.ClearSelection();
            Input_grid.ClearSelection();
            
        }


        private void Re_bt_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void InputAsk_bt_Click(object sender, EventArgs e)
        {
            string company = (InCompany_com.SelectedItem != null) ? InCompany_com.SelectedItem.ToString() : "";
            string name = InName_txt.Text;
            string code = InCode_txt.Text;
            string warehouse = (InWarehouse_com.SelectedItem != null) ? InWarehouse_com.SelectedItem.ToString() : "";
            string date = (InDate1.Value != new DateTime(1989, 01, 01)) ? InDate1.Value.ToString("yyyy-MM-dd") : null;

            ShowGrid(company, name, code, warehouse, date);
        }




        public void ShowGrid(string company, string name, string code, string warehouse, string date)
        {
            Input_grid.Rows.Clear();

            try
            {
                MySqlConnection connection = new MySqlConnection("Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;");
                connection.Open();

                // 데이터베이스에서 필요한 정보를 가져올 SQL 쿼리 작성
                string query = "SELECT * FROM incoming WHERE 1=1";

                if (!string.IsNullOrEmpty(company))
                    query += " AND company = @company";
                if (!string.IsNullOrEmpty(name))
                    query += " AND product_name = @name";
                if (!string.IsNullOrEmpty(code))
                    query += " AND product_code = @code";
                if (!string.IsNullOrEmpty(warehouse))
                    query += " AND location = @warehouse";
                if (!string.IsNullOrEmpty(date))
                    query += " AND registration_date_incoming = @date";

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
                    Input_grid.Rows.Add(false, reader["progress"], reader["company"], reader["product_code"],
                         reader["product_name"], reader["lot_no"], reader["quantity"],
                        reader["registration_date_incoming"], reader["registrant_incoming"], reader["location"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InDelete_bt_Click(object sender, EventArgs e)
        {
            // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
            foreach (DataGridViewRow row in Input_grid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    // MySQL 데이터베이스로 전송할 데이터 추출
                    string Lot = row.Cells[5].Value.ToString();
                    string productName = row.Cells[4].Value.ToString();
                    string quantity = row.Cells[6].Value.ToString();
                    MinusMedicine(productName, quantity);
                    DeleteInput(Lot);
                }
            }
        }
        private void MinusMedicine(string name, string quantityToMinus)
        {
            string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 데이터베이스에서 동일한 이름의 데이터가 이미 있는지 확인합니다.
                string selectQuery = $"SELECT * FROM medicine WHERE name = '{name}'";

                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 동일한 이름의 데이터가 이미 존재하면 수량(quantity)을 업데이트합니다.
                            string currentQuantity = reader.GetString("quantity");
                            int newQuantity = int.Parse(currentQuantity) - int.Parse(quantityToMinus);

                            reader.Close();
                            string updateQuery = $"UPDATE medicine SET quantity = '{newQuantity}' WHERE name = '{name}'";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                                Console.WriteLine("약품 수량이 수정되었습니다.");
                            }
                        }
                    }
                }
            }
        }

        public void DeleteInput(string LotNum)
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
                connection.Close();
            }
        }

        private void Input_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int targetColumnIndex = 9;

            if (e.RowIndex >= 0 && e.ColumnIndex == targetColumnIndex)
            {
                DataGridViewCell currentCell = Input_grid.Rows[e.RowIndex].Cells[targetColumnIndex];
                DataGridViewCheckBoxCell checkBoxCell = Input_grid.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;

                // 현재 값과 기존 값이 다를 때 체크박스를 활성화
                if (!object.Equals(currentCell.Value, currentCell.OwningRow.Tag))
                {
                    checkBoxCell.Value = true;
                }
            }
        }

        private void InputOk_grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int targetColumnIndex = 1;

            if (e.RowIndex >= 0 && e.ColumnIndex == targetColumnIndex)
            {
                DataGridViewCell currentCell = InputOk_grid.Rows[e.RowIndex].Cells[targetColumnIndex];
                DataGridViewCheckBoxCell checkBoxCell = InputOk_grid.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;

                // 빈값이 아닐때 다를 때 체크박스를 활성화
                if (!string.IsNullOrEmpty(currentCell.Value?.ToString()))
                {
                    checkBoxCell.Value = true;
                }
            }

        }

        private void InputRe_bt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
                    foreach (DataGridViewRow row in InputOk_grid.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                        // 체크된 행인지 확인하고 체크된 경우에만 MySQL 테이블로 데이터를 전송합니다.
                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                        {
                            // MySQL 데이터베이스로 전송할 데이터 추출
                            string Inlocation = row.Cells[1].Value.ToString();
                            string progress = "입고";
                            string company = row.Cells[4].Value.ToString();
                            string productCode = row.Cells[5].Value.ToString();
                            string productName = row.Cells[6].Value.ToString();
                            string lotNo = row.Cells[7].Value.ToString();
                            string quantity = row.Cells[8].Value.ToString();
                            string date = DateTime.Now.ToString("yyyy-MM-dd");
                            string registrant = dataContainer.Name;

                            // InsertData 함수 호출
                            InsertData(connection, progress, company, productCode, productName, lotNo, quantity, date, registrant, Inlocation);
                            if (Inlocation.Equals("부자재IB"))
                                InsertMedicine(company, productCode, productName, quantity);
                            DeleteInsert(lotNo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}");
                }
            }
            string connectionString2 = "Server=10.10.32.82;Database=accumulated_data;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString2))
            {
                try
                {
                    connection.Open();

                    // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
                    foreach (DataGridViewRow row in InputOk_grid.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                        // 체크된 행인지 확인하고 체크된 경우에만 MySQL 테이블로 데이터를 전송합니다.
                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                        {
                            // MySQL 데이터베이스로 전송할 데이터 추출
                            string Inlocation = row.Cells[1].Value.ToString();
                            string progress = "입고";
                            string company = row.Cells[4].Value.ToString();
                            string productCode = row.Cells[5].Value.ToString();
                            string productName = row.Cells[6].Value.ToString();
                            string lotNo = row.Cells[7].Value.ToString();
                            string quantity = row.Cells[8].Value.ToString();
                            string date = DateTime.Now.ToString("yyyy-MM-dd");
                            string registrant = dataContainer.Name;

                            // InsertData 함수 호출
                            InsertData2(connection, progress, company, productCode, productName, lotNo, quantity, date, registrant, Inlocation);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}");
                }
            }
            ShowGrid();
        }

        


        static void InsertMedicine(string company,string code,string name, string quantityToAdd)
            {
                string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // 데이터베이스에서 동일한 이름의 데이터가 이미 있는지 확인합니다.
                    string selectQuery = $"SELECT * FROM medicine WHERE name = '{name}'";

                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 동일한 이름의 데이터가 이미 존재하면 수량(quantity)을 업데이트합니다.
                                string currentQuantity = reader.GetString("quantity");
                                int newQuantity = int.Parse(currentQuantity) + int.Parse(quantityToAdd);

                                reader.Close(); // reader를 닫고
                                string updateQuery = $"UPDATE medicine SET quantity = '{newQuantity}' WHERE name = '{name}'";

                                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                {
                                    updateCommand.ExecuteNonQuery();
                                    Console.WriteLine("부자재로 데이터가 저장되었습니다.");
                                }
                            }
                            else
                            {
                                reader.Close(); // reader를 닫고

                                 // 동일한 이름의 데이터가 존재하지 않으면 InsertMedicine 함수를 호출하여 데이터를 삽입합니다.
                                 DoInsertMedicine(connection, company, code, name, quantityToAdd);

                            }
                        }
                    }

                    connection.Close();
                }
            }

        static void DoInsertMedicine(MySqlConnection connection, string company, string code, string name, string quantityToAdd)
        {
            // 동일한 이름의 데이터가 존재하지 않으면 데이터를 삽입합니다.
            string insertQuery = $"INSERT INTO medicine (company,code,name, quantity) VALUES ('{company}','{code}','{name}', '{quantityToAdd}')";

            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
            {
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("새로운 약품이 성공적으로 삽입되었습니다.");
            }
        }


    // InsertData 함수 정의
    private void InsertData(MySqlConnection connection, string progress, string company, string productCode, string productName,
            string lotNo, string quantity, string date, string registrant, string location)
        {
            // MySQL 데이터베이스로 데이터 전송을 위한 SQL 쿼리 작성
            string query = $"INSERT INTO incoming (progress,company,product_code,product_name,lot_no,quantity," +
                $"registration_date_incoming,registrant_incoming,location) VALUES ('{progress}', '{company}', " +
                $"'{productCode}', '{productName}', '{lotNo}', '{quantity}', '{date}', '{registrant}', '{location}')";

            // 쿼리 실행
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        private void InsertData2(MySqlConnection connection, string progress, string company, string productCode, string productName,
            string lotNo, string quantity, string date, string registrant, string location)
        {
            // MySQL 데이터베이스로 데이터 전송을 위한 SQL 쿼리 작성
            string query = $"INSERT INTO accumulated_data(progress,company,product_code,product_name,lot_no,quantity," +
            $"registration_date,registrant,warehouse_location) VALUES ('{progress}', '{company}', " +
            $"'{productCode}', '{productName}', '{lotNo}', '{quantity}', '{date}', '{registrant}', '{location}')";

            // 쿼리 실행
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }

        }
        public void DeleteInsert(string LotNum)
        {
            string cnn = "Server=10.10.32.82;Database=quality;Uid=team;Pwd=team1234;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                // SQL 서버와 연결, database=스키마 이름
                connection.Open();

                // 입력할 문자 받아옴
                string insertQuery = "DELETE FROM import_inspection WHERE lot_no=@LotNum";

                // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                // 위 정보를 command 변수에 저장
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@LotNum", LotNum);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void InModify_bt_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in Input_grid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    // MySQL 데이터베이스로 전송할 데이터 추출
                    string Lot = row.Cells[5].Value.ToString();
                    string locationAfter = row.Cells[9].Value.ToString();
                    string locationBefore= row.Cells[9].OwningRow.Tag.ToString();
                    string company = row.Cells[2].Value.ToString();
                    string productCode= row.Cells[3].Value.ToString();
                    string productName = row.Cells[4].Value.ToString();
                    string quantity = row.Cells[6].Value.ToString();
                    if (locationAfter != locationBefore)
                    {
                        ChangeLocation(Lot, locationAfter);
                        if (locationAfter == "부자재IB")
                        {
                            InsertMedicine(company, productCode, productName, quantity);
                        }
                        if (locationBefore == "부자재IB")
                        {
                            MinusMedicine(productName, quantity);
                        }
                    }
                    else
                    {
                        MessageBox.Show("위치가 변경되지 않았습니다.");
                    }
                }
                row.Tag = row.Cells[9].Value;
            }

        }

        public void ChangeLocation(string Lot, string Location)
        {
            MySqlConnection connection = new MySqlConnection("Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();

            string update = string.Format("UPDATE incoming SET location= '{0}' WHERE lot_no='{1}'", Location, Lot);


            MySqlCommand command = new MySqlCommand(update, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("수정되었습니다.");
            connection.Close();
        }

        private void InDateX_bt_Click(object sender, EventArgs e)
        {
            InDate1.Value = new DateTime(1989, 01, 01);
        }


    }

}
