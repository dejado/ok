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





        public Form1()
        {
            InitializeComponent();
            mdiProp();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown); // 이 부분을 추가
            panel1.MouseDown += new MouseEventHandler(Form1_MouseDown); // 페널에도 동일한 이벤트 핸들러를 추가

            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
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
                plan = new formPlan();
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

        private void Qc_Click(object sender, EventArgs e)
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

        private void Qc_FormClosed(object sender, FormClosedEventArgs e)
        {
            input = null;
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new formInventory();
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

        private void Chart_FormClosed(object sender, FormClosedEventArgs e)
        {
            chart = null;
        }

        private void Systemmain_Click(object sender, EventArgs e)
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
            workview.Activate();
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
                import = new formImport();
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
                input = new formInput();
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
                shipment = new formShipment();
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
                output = new formOutput();
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
        }
        private void Input_FormClosed(object sender, FormClosedEventArgs e)
        {
            input.Activate();
        }

        private void Output_Click_1(object sender, EventArgs e)
        {
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
        }
        private void Output_FormClosed(object sender, FormClosedEventArgs e)
        {
            output.Activate();
        }
    }
}
