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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuJinChemicalMES
{
    public partial class formInput : Form
    {
        public formInput()
        {
            InitializeComponent();
            this.Size = new Size(1400, 800);
            ShowGrid();
        }

        public void ShowGrid()
        {
            Input_grid.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=material;Uid=test;Pwd=123;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                //SQL 서버 연결

                string Query = "SELECT * from incoming1 ORDER BY registration_date_incoming ASC";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Input_grid.Rows.Add(reader["progress"], reader["company"], reader["product_code"],
                         reader["product_name"], reader["lot_no"], reader["quantity"],
                        reader["registration_date_incoming"], reader["registrant_incoming"], reader["location"]);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void formInput_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void InputOk_bt_Click(object sender, EventArgs e)
        {
            formInputOkay formInputOkay = new formInputOkay();
            formInputOkay.Show();
        }

        private void Re_bt_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void InputAsk_bt_Click(object sender, EventArgs e)
        {
            string company = (Company_com.SelectedItem != null) ? Company_com.SelectedItem.ToString() : "";
            string name = InName_txt.Text;
            string code = InCode_txt.Text;
            string warehouse = (InWarehouse_com.SelectedItem != null) ? InWarehouse_com.SelectedItem.ToString() : "";
            string k = null;

            // name, company, code 중 하나라도 빈 문자열이 아닌 경우 k에 해당 값을 할당
            if (!string.IsNullOrEmpty(name))
            {
                k = name;
            }
            else if (!string.IsNullOrEmpty(company))
            {
                k = company;
            }
            else if (!string.IsNullOrEmpty(code))
            {
                k = code;
            }
            else if (!string.IsNullOrEmpty(warehouse))
            {
                k = warehouse;
            }


            // 빈 문자열이 아닌 경우에만 ShowGrid 함수 호출
            if (!string.IsNullOrEmpty(k))
            {
                ShowGrid(k);
            }

        }
        /*
        // 예시 코드 (C#를 기반으로 함)
        (string k, string k1) GetValuesToDisplay(string name, string company, string code, string warehouse)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(company))
            {
                return (name, company);
            }
            else if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(code))
            {
                return (name, code);
            }
            else if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(warehouse))
            {
                return (name, warehouse);
            }


            // 기본값 반환
            return (null, null);
        
        }

        // 호출 부분
        var(k, k1) = GetValuesToDisplay(name, company, code, warehouse);
        ShowGrid(k, k1);
        */
        public void ShowGrid(string inquiry)
            {
                Input_grid.Rows.Clear();
            
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=material;Uid=test;Pwd=123;");
                connection.Open();

                // 동적 쿼리 생성
                string query = "SELECT * FROM incoming1 WHERE 1=1";

                if (!string.IsNullOrEmpty(inquiry))
                {
                    query += $" AND (company = '{inquiry}' OR product_name = '{inquiry}'" +
                        $" OR product_code = '{inquiry}' OR location = '{inquiry}' " +
                        $"OR registration_date_incoming = '{inquiry}')";
                }

                query += " ORDER BY registration_date_incoming ASC";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Input_grid.Rows.Add(reader["progress"], reader["company"], reader["product_code"],
                         reader["product_name"], reader["lot_no"], reader["quantity"],
                        reader["registration_date_incoming"], reader["registrant_incoming"], reader["location"]);
                }

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    
            public void ShowGrid(string inquiry1, string inquiry2)
            {
                Input_grid.Rows.Clear();
                try
                {
                    MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=material;Uid=test;Pwd=123;");
                    connection.Open();

                    // 동적 쿼리 생성
                    string query = "SELECT * FROM incoming1 WHERE 1=1";

                    if (!string.IsNullOrEmpty(inquiry1))
                    {
                        query += $" AND (company = '{inquiry1}' OR product_name = '{inquiry1}'  location = '{inquiry1}'" +
                        $" OR product_code = '{inquiry1}' OR registration_date_incoming = '{inquiry1}')";
                    }

                    if (!string.IsNullOrEmpty(inquiry2))
                    {
                        query += $" AND (company = '{inquiry2}' OR product_name = '{inquiry2}' OR location = '{inquiry2}'" +
                        $"OR product_code = '{inquiry2}' OR registration_date_incoming = '{inquiry2}')";
                    }

                    query += " ORDER BY registration_date_incoming ASC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                    Input_grid.Rows.Add(reader["progress"], reader["company"], reader["product_code"],
                     reader["product_name"], reader["lot_no"], reader["quantity"],
                    reader["registration_date_incoming"], reader["registrant_incoming"], reader["location"]);
                }

                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        private void InSerch_bt_Click(object sender, EventArgs e)
        {

        }

        private void InModify_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
