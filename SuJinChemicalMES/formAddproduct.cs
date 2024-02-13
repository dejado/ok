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
    public partial class formAddproduct : Form
    {
        public formAddproduct()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            formAddproductOkay formAddproductOkay = new formAddproductOkay();

            // 만약 ShowDialog()를 사용하면 해당 폼이 닫힐 때까지 현재 폼은 사용할 수 없습니다.
            // managerProductForm.ShowDialog();

            // Show()를 사용하면 해당 폼이 닫히더라도 현재 폼은 계속 사용할 수 있습니다.
            formAddproductOkay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MySQL 연결 문자열 설정
            string connectionString = "Server=localhost;Database=managerproduct;User Id=root;Password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 텍스트박스 1, 4, 5, 6 및 콤보박스1의 값을 가져옴
                string companyToSearch = textBox1.Text;
                string productCodeToSearch = textBox6.Text;
                string productNameToSearch = textBox5.Text;
                string itemTypeToSearch = comboBox1.SelectedItem?.ToString();

                // 중복된 데이터를 검색하는 SQL 쿼리 작성
                string query = "SELECT null as CheckColumn, company, Item_Type, product_code, product_name, Test_Method, Specification, Standard_Unit, Registration_Date FROM dfd WHERE 1 = 0";

                if (!string.IsNullOrEmpty(companyToSearch))
                    query += $" OR company = '{companyToSearch}'";

                if (!string.IsNullOrEmpty(productCodeToSearch))
                    query += $" OR product_code = '{productCodeToSearch}'";

                if (!string.IsNullOrEmpty(productNameToSearch))
                    query += $" OR product_name = '{productNameToSearch}'";

                if (!string.IsNullOrEmpty(itemTypeToSearch))
                    query += $" OR Item_Type = '{itemTypeToSearch}'";

                // 모든 텍스트박스와 콤보박스가 비어있는 경우 모든 데이터를 불러오도록 수정
                if (string.IsNullOrEmpty(companyToSearch) && string.IsNullOrEmpty(productCodeToSearch) && string.IsNullOrEmpty(productNameToSearch) && string.IsNullOrEmpty(itemTypeToSearch))
                    query = "SELECT null as CheckColumn, company, Item_Type, product_code, product_name, Test_Method, Specification, Standard_Unit, Registration_Date FROM dfd";

                // 먼저 DataGridView2의 데이터를 모두 지워줍니다.
                dataGridView2.Rows.Clear();

                // 쿼리 실행
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 결과를 확인
                        while (reader.Read())
                        {
                            int index = dataGridView2.Rows.Add();
                            for (int i = 1; i < reader.FieldCount; i++)
                            {
                                if (bool.TryParse(reader[i].ToString(), out _))
                                {
                                    dataGridView2.Rows[index].Cells[i].ValueType = typeof(string);
                                }
                                dataGridView2.Rows[index].Cells[i].Value = reader[i].ToString();
                            }
                        }

                        // 중복 데이터가 존재하지 않으면 알림창을 띄움
                        if (dataGridView2.Rows.Count == 0)
                        {
                            MessageBox.Show("조건에 해당하는 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                // 체크된 행인지 확인
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            formAddproductOkay formAddproductOkay = new formAddproductOkay();
            formAddproductOkay.Show();
        }

        private void formAddproduct_Load(object sender, EventArgs e)
        {
            1
        }
    }
}
