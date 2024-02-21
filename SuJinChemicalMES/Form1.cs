using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace SuJinChemicalMES
{
    public partial class Form1 : Form
    {
        formMain main;
        formInput input;
        formWork workview;
        formPlan plan;
        formInventory inventory;
        formOutput output;
        formChart chart;
        formOrder system1;
        formAddproduct system2;
        formRecipe system3;
        formSystem4 system4;
        formImport import;
        formShipment shipment;

        //formSystem systemmain;

        //***************************************************************************************************//
        bool MeterialOK = false;
        bool QcOK = false;
        bool WokrviewOK = false;
        bool ChartOK = false;
        bool SystemmainOK = false;
        //*****************************************************************************************************//

        private DataContainer dataContainer;

        public Form1()
        {
            InitializeComponent();
            mdiProp();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown); // 이 부분을 추가
            panel1.MouseDown += new MouseEventHandler(Form1_MouseDown); // 페널에도 동일한 이벤트 핸들러를 추가

            this.MouseMove += new MouseEventHandler(Form1_MouseMove);

            //***********************************************************************************************//
            
            Loginpw_tb.PasswordChar = '*'; //비밀번호

            Login_pn.BackColor = Color.FromArgb(232, 234, 237);

            Login_pn.Parent = this;
            Loginid_lb.Parent = Login_pn;
            Loginpw_lb.Parent = Login_pn;

            Logout_bt.BringToFront();
            Logout_pn.BringToFront();

            Main_pb.BackColor = Color.FromArgb(232, 234, 237);
            //Main_pb.Size = Properties.Resources.SeojinChemical_Logo_sq.Size;
            //Main_pb.Image = Properties.Resources.SeojinChemical_Logo_sq;
            //Properties.Resources.SeojinChemical_Logo_sq.Size.Width = 1000;

            Loginpw_tb.KeyDown += Loginpw_tb_KeyDown;
            //**********************************************************************************************//

            dataContainer = new DataContainer();

        }

        private void Loginpw_tb_KeyDown(object sender, KeyEventArgs e)
        {
            // 만약 눌린 키가 Enter 키인지 확인합니다.
            if (e.KeyCode == Keys.Enter)
            {
                // 버튼1을 클릭합니다.
                Login_bt.PerformClick();
            }
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }



        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 176)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {

                if (menuContainer.Height <= 45)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
                else menuContainer.Height -= 10;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (WokrviewOK == true)
            {
                menuExpand2 = true;
                menuExpand3 = true;
                menuExpand4 = true;
                sidebarExpand = false;
                menuTransition.Start();
                menuTransition2.Start();
                menuTransition3.Start();
                menuTransition4.Start();
                sidebarTransition.Start();
            }
            else if (WokrviewOK == false)
            {
                MessageBox.Show("생산에 접근권한이 없습니다.", "권한경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //sidebar.Width -= 5;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    /*
                    pnMain.Width = sidebar.Width;
                    pnMeterial.Width = sidebar.Width;
                    pnQC.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                    
                    pnChart.Width = sidebar.Width;
                    pnSystem.Width = sidebar.Width;
                    */

                }
                else
                {

                    sidebar.Width -= 5;

                    pnMain.Width -= 5;
                    pnMeterial.Width -= 5;
                    pnQC.Width -= 5;
                    menuContainer.Width -= 5;
                    pnChart.Width -= 5;
                    pnSystem.Width -= 5;

                }
            }


            else
            {
                if (sidebar.Width >= 237)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    /*
                    pnMain.Width = sidebar.Width;
                    pnMeterial.Width = sidebar.Width;
                    pnQC.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                    pnChart.Width = sidebar.Width;
                    pnSystem.Width = sidebar.Width;
                    */

                }
                else
                {

                    sidebar.Width += 5;

                    pnMain.Width += 5;
                    pnMeterial.Width += 5;
                    pnQC.Width += 5;
                    menuContainer.Width += 5;
                    pnChart.Width += 5;
                    pnSystem.Width += 5;

                }
            }

        }

        private void btnham_Click(object sender, EventArgs e)
        {
            menuExpand = true;
            menuExpand2 = true;
            menuExpand3 = true;
            menuExpand4 = true;
            menuTransition.Start();
            menuTransition2.Start();
            menuTransition3.Start();
            menuTransition4.Start();
            sidebarTransition.Start();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
                //menuTransition10.Start();
                menuExpand = true;
                menuExpand2 = true;
                menuExpand3 = true;
                menuExpand4 = true;
                sidebarExpand = false;
                menuTransition.Start();
                menuTransition2.Start();
                menuTransition3.Start();
                menuTransition4.Start();
                sidebarTransition.Start();

                if (main == null)
                {
                    main = new formMain();
                    main.FormClosed += Main_FormClosed;
                    main.MdiParent = this;
                    main.Dock = DockStyle.Fill;
                    main.Show();
                }
                else
                {
                    main.Activate();
                }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            main = null;
        }

        private void Plan_Click(object sender, EventArgs e)
        {
            if (plan == null)
            {
                plan = new formPlan(dataContainer);
                plan.FormClosed += Plan_FormClosed;
                plan.MdiParent = this;
                plan.Dock = DockStyle.Fill;
                plan.Show();
            }
            else
            {
                plan.Activate();
            }
        }

        private void Plan_FormClosed(object sender, FormClosedEventArgs e)
        {
            plan = null;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (MeterialOK == true)
            {
                menuExpand = true;
                menuExpand2 = true;
                menuExpand3 = true;
                sidebarExpand = false;
                menuTransition.Start();
                menuTransition2.Start();
                menuTransition3.Start();
                menuTransition4.Start();
                sidebarTransition.Start();

                /*
                if (input == null)
                {
                    input = new formInput();
                    input.FormClosed += Input_FormClosed;
                    input.MdiParent = this;
                    input.Dock = DockStyle.Fill;
                    input.Show();
                }
                else
                {
                    input.Activate();
                }
                */
            }

            else if (MeterialOK == false)
            {
                MessageBox.Show("자재에 접근권한이 없습니다.", "권한경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Qc_Click(object sender, EventArgs e)
        {
            if (QcOK == true)
            {
                menuExpand = true;
                menuExpand2 = true;
                menuExpand4 = true;
                sidebarExpand = false;
                menuTransition.Start();
                menuTransition2.Start();
                menuTransition3.Start();
                menuTransition4.Start();
                sidebarTransition.Start();

                /*
                if (qc == null)
                {
                    qc = new formQc();
                    qc.FormClosed += Qc_FormClosed;
                    qc.MdiParent = this;
                    qc.Dock = DockStyle.Fill;
                    qc.Show();
                }
                else
                {
                    qc.Activate();
                }
                */
            }

            else if (QcOK == false)
            {
                MessageBox.Show("품질에 접근권한이 없습니다.", "권한경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Qc_FormClosed(object sender, FormClosedEventArgs e)
        {
            input = null;
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new formInventory(dataContainer);
                inventory.FormClosed += Inventory_FormClosed;
                inventory.MdiParent = this;
                inventory.Dock = DockStyle.Fill;
                inventory.Show();
            }
            else
            {
                inventory.Activate();
            }
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void Output_Click(object sender, EventArgs e)
        {
            /*
            if (output == null)
            {
                output = new formOutput();
                output.FormClosed += Output_FormClosed;
                output.MdiParent = this;
                output.Dock = DockStyle.Fill;
                output.Show();
            
            }
            else
            {
                output.Activate();
            }
            */
        }

        private void Chart_Click(object sender, EventArgs e)
        {
            if (ChartOK == true)
            {
                menuExpand = true;
                menuExpand2 = true;
                menuExpand3 = true;
                menuExpand4 = true;
                sidebarExpand = false;
                menuTransition.Start();
                menuTransition2.Start();
                menuTransition3.Start();
                menuTransition4.Start();
                sidebarTransition.Start();

                if (chart == null)
                {
                    chart = new formChart();
                    chart.FormClosed += Chart_FormClosed;
                    chart.MdiParent = this;
                    chart.Dock = DockStyle.Fill;
                    chart.Show();
                }
                else
                {
                    chart.Activate();
                }
            }
            else if (ChartOK == false)
            {
                MessageBox.Show("통계에 접근권한이 없습니다.", "권한경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chart_FormClosed(object sender, FormClosedEventArgs e)
        {
            chart = null;
        }

        private void Systemmain_Click(object sender, EventArgs e)
        {
            if (SystemmainOK == true)
            {
                menuExpand = true;
                menuExpand3 = true;
                menuExpand4 = true;
                sidebarExpand = false;
                menuTransition.Start();
                menuTransition2.Start();
                menuTransition3.Start();
                menuTransition4.Start();
                sidebarTransition.Start();

                /*
                if (systemmain == null)
                {
                    systemmain = new formSystem();
                    systemmain.FormClosed += Systemmain_FormClosed;
                    systemmain.MdiParent = this;
                    systemmain.Dock = DockStyle.Fill;
                    systemmain.Show();
                }
                else
                {
                    systemmain.Activate();
                }
                */
            }
            else if (SystemmainOK == false)
            {
                MessageBox.Show("관리에 접근권한이 없습니다.", "권한경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Systemmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //systemmain = null;
        }

        private void mesclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Workmain_Click(object sender, EventArgs e)
        {
            if (workview == null)
            {
                workview = new formWork();
                workview.FormClosed += Workview_FormClosed;
                workview.MdiParent = this;
                workview.Dock = DockStyle.Fill;
                workview.Show();
            }
            else
            {
                workview.Activate();
            }
        }

        private void Workview_FormClosed(object sender, FormClosedEventArgs e)
        {
            //workview.Activate();
            if (workview != null)
            {
                workview.Dispose(); // 폼을 닫고 메모리에서 해제합니다.
                workview = null; // 변수를 null로 설정합니다.
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        //const int WM_SYSCOMMAND = 0x0112;
        //const int SC_SIZE = 0xF000;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAllControls(this);
        }

        bool menuExpand2 = false;
        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                pnSystem.Height += 10;
                if (pnSystem.Height >= 225)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                if (pnSystem.Height <= 45)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
                else pnSystem.Height -= 10;
            }
        }

        private void System1_Click(object sender, EventArgs e)
        {
            if (system1 == null)
            {
                system1 = new formOrder();
                system1.FormClosed += Workview_FormClosed;
                system1.MdiParent = this;
                system1.Dock = DockStyle.Fill;
                system1.Show();
            }
            else
            {
                system1.Activate();
            }

        }
        private void System1_FormClosed(object sender, FormClosedEventArgs e)
        {
            system1 = null;
        }

        private void System2_Click(object sender, EventArgs e)
        {
            if (system2 == null)
            {
                system2 = new formAddproduct();
                system2.FormClosed += Workview_FormClosed;
                system2.MdiParent = this;
                system2.Dock = DockStyle.Fill;
                system2.Show();
            }
            else
            {
                system2.Activate();
            }
        }
        private void System2_FormClosed(object sender, FormClosedEventArgs e)
        {
            system2 = null;
        }

        private void System3_Click(object sender, EventArgs e)
        {
            if (system3 == null)
            {
                system3 = new formRecipe();
                system3.FormClosed += Workview_FormClosed;
                system3.MdiParent = this;
                system3.Dock = DockStyle.Fill;
                system3.Show();
            }
            else
            {
                system3.Activate();
            }
        }
        private void System3_FormClosed(object sender, FormClosedEventArgs e)
        {
            system3 = null;
        }

        private void System4_Click(object sender, EventArgs e)
        {
            if (system4 == null)
            {
                system4 = new formSystem4();
                system4.FormClosed += Workview_FormClosed;
                system4.MdiParent = this;
                system4.Dock = DockStyle.Fill;
                system4.Show();
            }
            else
            {
                system4.Activate();
            }
        }
        private void System4_FormClosed(object sender, FormClosedEventArgs e)
        {
            system4 = null;
        }

        bool menuExpand3 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpand3 == false)
            {
                pnQC.Height += 10;
                if (pnQC.Height >= 135)
                {
                    menuTransition3.Stop();
                    menuExpand3 = true;
                }
            }
            else
            {
                if (pnQC.Height <= 45)
                {
                    menuTransition3.Stop();
                    menuExpand3 = false;
                }
                else pnQC.Height -= 10;
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            if (import == null)
            {
                import = new formImport(dataContainer);
                import.FormClosed += Import_FormClosed;
                import.MdiParent = this;
                import.Dock = DockStyle.Fill;
                import.Show();
            }
            else
            {
                import.Activate();
            }
        }
        private void Import_FormClosed(object sender, FormClosedEventArgs e)
        {
            import.Activate();
        }

        bool menuExpand4 = false;
        private void menuTransition4_Tick(object sender, EventArgs e)
        {
            if (menuExpand4 == false)
            {
                pnMeterial.Height += 10;
                if (pnMeterial.Height >= 135
                    )
                {
                    menuTransition4.Stop();
                    menuExpand4 = true;
                }
            }
            else
            {
                if (pnMeterial.Height <= 45)
                {
                    menuTransition4.Stop();
                    menuExpand4 = false;
                }
                else pnMeterial.Height -= 10;
            }
        }

        private void Store_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                input = new formInput(dataContainer);
                input.FormClosed += Store_FormClosed;
                input.MdiParent = this;
                input.Dock = DockStyle.Fill;
                input.Show();
            }
            else
            {
                input.Activate();
            }
        }
        private void Store_FormClosed(object sender, FormClosedEventArgs e)
        {
            input.Activate();
        }

        private void Shipment_Click(object sender, EventArgs e)
        {
            if (shipment == null)
            {
                shipment = new formShipment(dataContainer);
                shipment.FormClosed += Shipment_FormClosed;
                shipment.MdiParent = this;
                shipment.Dock = DockStyle.Fill;
                shipment.Show();
            }
            else
            {
                shipment.Activate();
            }
        }
        private void Shipment_FormClosed(object sender, FormClosedEventArgs e)
        {
            shipment.Activate();
        }

        private void Release_Click(object sender, EventArgs e)
        {
            if (output == null)
            {
                output = new formOutput(dataContainer);
                output.FormClosed += Release_FormClosed;
                output.MdiParent = this;
                output.Dock = DockStyle.Fill;
                output.Show();
            }
            else
            {
                output.Activate();
            }
        }
        private void Release_FormClosed(object sender, FormClosedEventArgs e)
        {
            output.Activate();
        }


        private void menuTransition10_Tick(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Input_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                input = new formInput(dataContainer);
                input.FormClosed += Input_FormClosed;
                input.MdiParent = this;
                input.Dock = DockStyle.Fill;
                input.Show();
            }
            else
            {
                input.Activate();
            }
        }
        private void Input_FormClosed(object sender, FormClosedEventArgs e)
        {
            input.Activate();
        }

        private void Output_Click_1(object sender, EventArgs e)
        {
            if (output == null)
            {
                output = new formOutput(dataContainer);
                output.FormClosed += Output_FormClosed;
                output.MdiParent = this;
                output.Dock = DockStyle.Fill;
                output.Show();
            }
            else
            {
                output.Activate();
            }
        }
        private void Output_FormClosed(object sender, FormClosedEventArgs e)
        {
            output.Activate();
        }

        //***********************************************************************************************//

        string department; //user_registration의 department 권한부여
        int login_status; //로그인 확인

        private void Login_bt_Click_1(object sender, EventArgs e)
        {
            if (Loginid_tb.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Loginid_tb.Focus();
            }
            else if (Loginpw_tb.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Loginpw_tb.Focus();
            }

            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("Server = 10.10.32.82; Database = managerproduct; Uid = team; Pwd = team1234");

                    con.Open();

                    login_status = 0; //로그인 확인지수

                    string Loginid = Loginid_tb.Text;
                    string Loginpw = Loginpw_tb.Text;

                    string selectQuery = "SELECT * FROM user_registration WHERE id = \'" + Loginid + "\'";
                    //데이터베이스 쿼리 선택

                    MySqlCommand SelectCom = new MySqlCommand(selectQuery, con);
                    MySqlDataReader reader = SelectCom.ExecuteReader();

                    while (reader.Read())
                    {
                        if (Loginid == (string)reader["id"] && Loginpw == (string)reader["password"])
                        {
                            login_status = 1;
                            department = reader["department"].ToString();
                            dataContainer.Name = reader["name"].ToString();
                        }
                     
                    }
                    reader.Close();
                    con.Close(); //데이터베이스 연결 닫음

                    if (login_status == 1)
                    {
                        //로그인 가능!
                        EnableAllControls(this);

                        Login_pn.Hide();
                        Main_pb.Hide();

                        Main.PerformClick();
                        //메인폼 실행
                    }

                    else if (login_status == 0)
                        MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AuthorityDepartment();
                Loginid_tb.Clear();
                Loginpw_tb.Clear();
            }
            name_lb.Text = "사용자: "+ dataContainer.Name;
        }

        private void AuthorityDepartment()
        {
            if (department == "자재")
            {
                MeterialOK = true;
            }

            else if (department == "품질")
            {
                QcOK = true;
            }

            else if (department == "생산")
            {
                WokrviewOK = true;
            }

            else if (department == "관리")
            {
                ChartOK = true;
                SystemmainOK = true;
            }

            else if (department == "master")
            {
                MeterialOK = true;
                QcOK = true;
                WokrviewOK = true;
                ChartOK = true;
                SystemmainOK = true;
            }
        }

        private void DisableAllControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // 로그인 기능 외 비활성화
                if (c != Login_bt && c != Loginid_tb && c != Loginpw_tb && c != Login_pn && c != Loginid_lb && c != Loginpw_lb && c != panel1 && c != btnExit)
                    c.Enabled = false;

                // 만약 컨트롤이 다른 컨테이너 컨트롤인 경우, 하위 컨트롤 재귀적 처리
                if (c.HasChildren)
                {
                    DisableAllControls(c);
                }
            }
        }

        private void EnableAllControls(Control control)
        {
            //주어진 Control의 모든 하위 컨트롤 활성화
            foreach (Control c in control.Controls)
            {
                c.Enabled = true;

                // 컨트롤이 다른 컨테이너 컨트롤인 경우, 해당 컨테이너 하위 컨트롤 처리
                if (c.HasChildren)
                {
                    EnableAllControls(c);
                }
            }
        }

        private void Login_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_bt_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Close();
                main = null; // 인스턴스 초기화
            }
            if (input != null)
            {
                input.Close();
                input = null;
            }

            if (workview != null)
            {
                workview.Close();
                workview = null;
            }

            if (plan != null)
            {
                plan.Close();
                plan = null;
            }

            if (inventory != null)
            {
                inventory.Close();
                inventory = null;
            }

            if (output != null)
            {
                output.Close();
                output = null;
            }

            if (chart != null)
            {
                chart.Close();
                chart = null;
            }

            if (system1 != null)
            {
                system1.Close();
                system1 = null;
            }

            if (system2 != null)
            {
                system2.Close();
                system2 = null;
            }

            if (system3 != null)
            {
                system3.Close();
                system3 = null;
            }

            if (system4 != null)
            {
                system4.Close();
                system4 = null;
            }

            if (import != null)
            {
                import.Close();
                import = null;
            }

            if (shipment != null)
            {
                shipment.Close();
                shipment = null;
            }

            DisableAllControls(this);
            login_status = 0;
            Login_pn.Show();
            Main_pb.Show();
        }

        private void Logout_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginpw_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
