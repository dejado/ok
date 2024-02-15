﻿using System;
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
    public partial class formPlan : Form
    {
        private string connectionString = "Server=10.10.32.82;Database=managerproduct;Uid=team;Pwd=team1234;";

        public formPlan()
        {
            InitializeComponent();

            dataGridView2.MouseClick += dataGridView2_MouseClick;
            dataGridView2.AllowUserToAddRows = false;

        }

        private void formPlan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            BindDataGridView();
            //this.dataGridView1.Font = new Font("SegoeUI", 10, FontStyle.Bold);
        }

        static void ConsolSize(string[] args)
        {
            // 콘솔 창의 너비와 높이를 설정
            Console.WindowWidth = 50;  // 원하는 너비 값으로 변경
            Console.WindowHeight = 20; // 원하는 높이 값으로 변경

            // 다른 작업 수행
            Console.WriteLine("콘솔 창 크기를 조절했습니다.");

            // 콘솔 창이 닫히지 않도록 대기
            Console.ReadLine();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    string query = "SELECT order_number AS '발주서번호', lot_no AS 'Lot No.', product_code AS '제품코드', product_name AS '제품명', expected_production_quantity AS '수량', due_date AS '납기일' FROM order_registration";

                    // 쿼리 실행
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // DataGridView에 데이터 추가
                            while (reader.Read())
                            {
                                dataGridView2.Rows.Add(
                                    reader["발주서번호"].ToString(),
                                    reader["Lot No."].ToString(),
                                    reader["제품코드"].ToString(),
                                    reader["제품명"].ToString(),
                                    reader["수량"].ToString(),
                                    reader["납기일"].ToString()
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
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("B20230207001", "230207001", "UPS_30", "Upper shield (업퍼 쉴드)", "120", "2023-02-21");
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

            }
            */
            // DataGridView의 현재 선택된 행을 가져옵니다.
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex];

            // 선택된 행의 각 셀의 데이터를 TextBox에 할당합니다.
            label15.Text = selectedRow.Cells["Column10"].Value.ToString();
            label16.Text = selectedRow.Cells["Column11"].Value.ToString();
            label17.Text = selectedRow.Cells["Column12"].Value.ToString();
            label18.Text = selectedRow.Cells["Column13"].Value.ToString();
            label19.Text = selectedRow.Cells["Column14"].Value.ToString();
            // 필요에 따라 추가적인 TextBox에 대한 할당을 진행합니다.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("A20230207001", "235555", "UPS_31", "Target guide (타켓 가이드)", "90", "2023-02-21");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("B20230207001", "230207001", "UPS_30", "Upper shield (업퍼 쉴드)", "120", "2023-02-21");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("A20230207001", "235555", "UPS_31", "Target guide (타켓 가이드)", "90", "2023-02-21");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // 라벨에서 데이터 가져오기
            string label15Text = label15.Text;
            string label16Text = label16.Text;
            string label17Text = label17.Text;
            string label18Text = label18.Text;
            string combobox1Text = comboBox1.Text;
            string label19Text = label19.Text;
            string textbox1Text = textBox1.Text;
            string combobox2Text = comboBox2.Text;

            // 그리드뷰에 행 추가
            dataGridView1.Rows.Add(label15Text, label16Text, label17Text, label18Text, combobox1Text, label19Text, textbox1Text, "가동중", combobox2Text);
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
