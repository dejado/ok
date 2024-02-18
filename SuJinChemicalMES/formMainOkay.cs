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

            CalendarPick_tlpn.Controls.Add(CalendarPick_gv, 0, 1);
            CalendarPick_gv.Dock = DockStyle.Fill;
            CalendarPick_gv.Parent = CalendarPick_tlpn;

            CalendarPick_gv.AutoGenerateColumns = true;
        }

        private void formMainOkay_Load(object sender, EventArgs e)
        {
            CalendarPickList_lb.Text = CalendarPick_st + "생산일정";
            DayListLoad();
        }

        private void DayListLoad()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = production_management; User id = team; Password = team1234");
                //SQL 서버와 연결, database=스키마 이름
                con.Open();
                //SQL 서버 연결

                string Query = "SELECT * FROM register_work_order WHERE order_number LIKE @orderNumber";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand com = new MySqlCommand(Query, con);

                com.Parameters.AddWithValue("@orderNumber", "%" + CalendarPick_st + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable CalendarDT = new DataTable();
                //어뎁터 이용해서 끌어오기

                adapter.Fill(CalendarDT);
                CalendarPick_gv.DataSource = CalendarDT;

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