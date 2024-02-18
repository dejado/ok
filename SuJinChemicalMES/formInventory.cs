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
    public partial class formInventory : Form
    {
        private string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

        public formInventory()
        {
            InitializeComponent();

        }

        private void formInventory_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 데이터그리드뷰에 MySQL 데이터 바인딩
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // MySQL 데이터베이스 연결
                    connection.Open();

                    // 쿼리 작성
                    string query = "SELECT * FROM medicine";

                    // 쿼리 실행
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // DataGridView에 데이터 추가
                            while (reader.Read())
                            {
                                dataGridView2.Rows.Add(
                                    reader["company"].ToString(),
                                    reader["code"].ToString(),
                                    reader["name"].ToString(),
                                    reader["quantity"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 오류 처리
                MessageBox.Show("데이터 로드 중 오류 발생: " + ex.Message);
            }
        }


        string medicienText;
        private void Registrant_bt_Click(object sender, EventArgs e)
        {
            // 모든 콤보박스의 선택 여부 확인
            if (BathNum_com.SelectedItem != null &&
                 Acidity_com.SelectedItem != null &&
                MedicineNum_com.SelectedItem != null &&
                Medicine_com.SelectedItem != null)
            {
                // 콤보박스에서 선택된 값 가져오기
                string bathNum = BathNum_com.SelectedItem.ToString();
                string acidity = Acidity_com.SelectedItem.ToString();
                string medicineNum = MedicineNum_com.SelectedItem.ToString();

                // DataGridView의 각 행을 순회하면서 체크된 행의 데이터를 MySQL 테이블로 전송합니다.
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 현재 순회 중인 행의 0번째 열의 값을 가져오기
                    string cellValue = row.Cells[0].Value?.ToString();
                    if (BathNum_com.Text.Equals(cellValue))
                    {
                        MessageBox.Show("이미 사용된 베스입니다.");
                        return;
                    }
                }

                dataGridView1.Rows.Add(bathNum, medicienText, medicineNum, acidity, "1.2 ph", "99", "1", "가동중", "김서진");
                DataStorage.MinusMedicine(medicienText,medicineNum);

                Company_lb.Text = "";
                Code_lb.Text = "";
                ProductName_lb.Text = "";
                Acidity_com.SelectedItem = null;
                MedicineNum_com.SelectedItem = null;
                Medicine_com.SelectedItem = null;
                BathNum_com.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("콤보박스 값을 모두 선택하세요.");
            }
        }



        

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            Company_lb.Text = selectedRow.Cells["Column310"].Value.ToString();
            Code_lb.Text = selectedRow.Cells["Column312"].Value.ToString();
            ProductName_lb.Text = selectedRow.Cells["Column313"].Value.ToString();
        }

        private void Medicine_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스의 선택된 항목과 다른 텍스트 박스의 텍스트를 비교
            if (Medicine_com.SelectedItem != null)
            {
                string comboBoxValue = Medicine_com.SelectedItem.ToString();
                string textBoxValue = ProductName_lb.Text;

                if (comboBoxValue == textBoxValue)
                {
                    medicienText = Medicine_com.Text;
                }
                else
                {
                    MessageBox.Show("적합한 약품이 아닙니다.");
                }
            }
        }
    }
}
