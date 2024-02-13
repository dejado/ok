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
        formQc qc;
        formWork workview;
        formPlan plan;
        formInventory inventory;
        formOutput output;
        formChart chart;
        formSystem systemmain;





        public Form1()
        {
            InitializeComponent();
            mdiProp();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown); // 이 부분을 추가
            panel1.MouseDown += new MouseEventHandler(Form1_MouseDown); // 페널에도 동일한 이벤트 핸들러를 추가

            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }
        bool menuExpand = false;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }




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
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 45)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void Workview_FormClosed(object sender, FormClosedEventArgs e)
        {
            workview.Activate();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnMain.Width = sidebar.Width;
                    pnIn.Width = sidebar.Width;
                    pnQC.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                    pnOut.Width = sidebar.Width;
                    pnChart.Width = sidebar.Width;
                    pnSystem.Width = sidebar.Width;
                }
            }


            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 237)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnMain.Width = sidebar.Width;
                    pnIn.Width = sidebar.Width;
                    pnQC.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                    pnOut.Width = sidebar.Width;
                    pnChart.Width = sidebar.Width;
                    pnSystem.Width = sidebar.Width;
                }
            }

        }

        private void btnham_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
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
            input = null;
        }

        private void Qc_Click(object sender, EventArgs e)
        {
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
            output = null;
        }

        private void Chart_Click(object sender, EventArgs e)
        {
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
        }

        private void Systemmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            systemmain = null;
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
    }
}
