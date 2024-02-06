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
    public partial class formOutput : Form
    {
        public formOutput()
        {
            InitializeComponent();
            this.Size = new Size(1400, 800);
            ShowGrid();
        }

        private void formOutput_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowGrid()
        {
            Output_grid.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                //SQL 서버 연결

                string Query = "SELECT * from output ORDER BY output_date ASC";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Output_grid.Rows.Add(reader["company"], reader["product_code"], reader["product_name"],
                         reader["product_num"], reader["step"], reader["inspect"],
                         reader["output_date"], reader["output_location"], reader["output_register"],
                        reader["input_date"]);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OutInspection_bt_Click(object sender, EventArgs e)
        {
            formOutputOkay formOutputOkForm = new formOutputOkay();
            formOutputOkForm.ShowDialog();
        }

        private void OutRe_bt_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void OutInquiry_bt_Click(object sender, EventArgs e)
        {
            string company = (OutCompany_com.SelectedItem != null) ? OutCompany_com.SelectedItem.ToString() : "";
            string inspect = (Inspect_com.SelectedItem != null) ? Inspect_com.SelectedItem.ToString() : "";

            ShowGrid(company);
            ShowGrid(inspect);
            ShowGrid(company, inspect);
        }

        public void ShowGrid(string inquiry)
        {
            Output_grid.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                connection.Open();

                // 동적 쿼리 생성
                string query = "SELECT * FROM output WHERE 1=1";

                if (!string.IsNullOrEmpty(inquiry))
                {
                    query += $" AND (company = '{inquiry}' OR product_code = '{inquiry}' " +
                        $"OR product_name = '{inquiry}' OR input_date = '{inquiry}' OR inspect = '{inquiry}')";
                }

                query += " ORDER BY input_date ASC";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Output_grid.Rows.Add(reader["company"], reader["product_code"], reader["product_name"],
                         reader["product_num"], reader["step"], reader["inspect"],
                         reader["output_date"], reader["output_location"], reader["output_register"],
                        reader["input_date"]);
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
            Output_grid.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                connection.Open();

                // 동적 쿼리 생성
                string query = "SELECT * FROM output WHERE 1=1";

                if (!string.IsNullOrEmpty(inquiry1))
                {
                    query += $" AND (company = '{inquiry1}' OR product_code = '{inquiry1}' " +
                        $"OR product_name = '{inquiry1}' OR input_date = '{inquiry1}' OR inspect = '{inquiry1}')";
                }

                if (!string.IsNullOrEmpty(inquiry2))
                {
                    query += $" AND (company = '{inquiry2}' OR product_code = '{inquiry2}' " +
                        $"OR product_name = '{inquiry2}' OR input_date = '{inquiry2}' OR inspect = '{inquiry2}')";
                }

                query += " ORDER BY input_date ASC";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Output_grid.Rows.Add(reader["company"], reader["product_code"], reader["product_name"],
                         reader["product_num"], reader["step"], reader["inspect"],
                         reader["output_date"], reader["output_location"], reader["output_register"],
                        reader["input_date"]);

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
