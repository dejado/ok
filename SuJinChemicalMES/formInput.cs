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
                MySqlConnection connection = new MySqlConnection("Server=10.10.32.82;Database=kim;Uid=MES;Pwd=kim123!;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                //SQL 서버 연결

                string Query = "SELECT * from inpu";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Input_grid.Rows.Add(reader["output_date"], reader["company"],
                        reader["product_code"], reader["product_name"], reader["product_num"],
                        reader["step"], reader["input_register"], reader["input_date"],
                        reader["input_location"]);
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
            string name = (ProductName_com.SelectedItem != null) ? ProductName_com.SelectedItem.ToString() : "";

            ShowGrid(company);
            ShowGrid(company, name);
        }

        public void ShowGrid(string inquiry)
        {
            Input_grid.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                connection.Open();

                // 동적 쿼리 생성
                string query = "SELECT * FROM input WHERE 1=1";

                if (!string.IsNullOrEmpty(inquiry))
                {
                    query += $" AND (company = '{inquiry}' OR product_code = '{inquiry}' " +
                        $"OR product_name = '{inquiry}' OR input_date = '{inquiry}')";
                }

                query += " ORDER BY input_date ASC";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Input_grid.Rows.Add(reader["output_date"], reader["company"],
                        reader["product_code"], reader["product_name"], reader["product_num"],
                        reader["step"], reader["input_register"], reader["input_date"],
                        reader["input_location"]);
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
                    MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                    connection.Open();

                    // 동적 쿼리 생성
                    string query = "SELECT * FROM input WHERE 1=1";

                    if (!string.IsNullOrEmpty(inquiry1))
                    {
                        query += $" AND (company = '{inquiry1}' OR product_code = '{inquiry1}' " +
                            $"OR product_name = '{inquiry1}' OR input_date = '{inquiry1}')";
                    }

                    if (!string.IsNullOrEmpty(inquiry2))
                    {
                        query += $" AND (company = '{inquiry2}' OR product_code = '{inquiry2}' " +
                            $"OR product_name = '{inquiry2}' OR input_date = '{inquiry2}')";
                    }

                    query += " ORDER BY input_date ASC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Input_grid.Rows.Add(reader["output_date"], reader["company"],
                            reader["product_code"], reader["product_name"], reader["product_num"],
                            reader["step"], reader["input_register"], reader["input_date"],
                            reader["input_location"]);
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        private void Input_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
