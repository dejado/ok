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
    public partial class formMainOkay : Form
    {
        private DataGridView CalendarPick_gv;

        //Main에서 데이터 받아오기
        public string CalendarPick_st
        {
            get;
            set;
        }

        public formMainOkay(string selectedDate)
        {
            InitializeComponent();

            CalendarPick_tlpn.Dock = DockStyle.Fill;
            this.Controls.Add(CalendarPick_tlpn);

            CalendarPick_st = selectedDate;

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            CalendarPick_gv = new DataGridView();
            CalendarPick_gv.BackgroundColor = System.Drawing.Color.White;
            CalendarPick_gv.ColumnHeadersHeight = 50;

            CalendarPick_gv.Columns.Add("order_number", "주문번호");
            CalendarPick_gv.Columns.Add("due_date", "납기일");
            CalendarPick_gv.Columns.Add("lot_no", "Lot No.");
            CalendarPick_gv.Columns.Add("supplier", "회사명");
            CalendarPick_gv.Columns.Add("product_code", "제품코드");
            CalendarPick_gv.Columns.Add("product_code", "제품이름");
            CalendarPick_gv.Columns.Add("quantity", "제품수량");

            CalendarPick_tlpn.Controls.Add(CalendarPick_gv, 0, 1);
            CalendarPick_gv.Dock = DockStyle.Fill;
            CalendarPick_gv.Parent = CalendarPick_tlpn;

            CalendarPick_gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CalendarPick_gv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            CalendarPick_gv.AutoGenerateColumns = true;
        }

        private void formMainOkay_Load(object sender, EventArgs e)
        {
            CalendarPickList_lb.Text = CalendarPick_st + "생산 로그";
            DayListLoad();
        }

        private void DayListLoad()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = accumulated_data; User id = team; Password = team1234");
                //SQL 서버와 연결, database=스키마 이름
                con.Open();
                //SQL 서버 연결

                string Query = "SELECT order_number, DATE_FORMAT(due_date, '%Y-%m-%d') AS due_date_formatted, lot_no, supplier, product_code, product_name, quantity FROM accumulated_data WHERE  registration_date = @CalendarPickday AND progress = '생산완료'";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);

                com.Parameters.AddWithValue("@CalendarPickday", CalendarPick_st);

                //MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable CalendarDT = new DataTable();
                //어뎁터 이용해서 끌어오기

                //adapter.Fill(CalendarDT);
                //CalendarPick_gv.DataSource = CalendarDT;

                MySqlDataReader reader = com.ExecuteReader();

                // 데이터를 읽어서 DataGridView에 추가
                while (reader.Read())
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    // 각 열에 대한 데이터 매핑
                    for (int i = 0; i < CalendarPick_gv.ColumnCount; i++)
                    {
                        dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = reader[i] });
                    }

                    CalendarPick_gv.Rows.Add(dgvRow);
                }

                /*
                foreach (DataRow row in CalendarDT.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    // 각 열에 대한 데이터 매핑
                    foreach (DataGridViewColumn column in CalendarPick_gv.Columns)
                    {
                        dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row[column.Name] });
                    }

                    CalendarPick_gv.Rows.Add(dgvRow);
                }
                */

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}