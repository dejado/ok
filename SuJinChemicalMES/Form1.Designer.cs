
namespace SuJinChemicalMES
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnham = new FontAwesome.Sharp.IconButton();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.Main = new FontAwesome.Sharp.IconButton();
            this.pnIn = new System.Windows.Forms.Panel();
            this.Input = new FontAwesome.Sharp.IconButton();
            this.pnQC = new System.Windows.Forms.Panel();
            this.Qc = new FontAwesome.Sharp.IconButton();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Wokrview = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Plan = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Inventory = new FontAwesome.Sharp.IconButton();
            this.pnOut = new System.Windows.Forms.Panel();
            this.Output = new FontAwesome.Sharp.IconButton();
            this.pnChart = new System.Windows.Forms.Panel();
            this.Chart = new FontAwesome.Sharp.IconButton();
            this.pnSystem = new System.Windows.Forms.Panel();
            this.Systemmain = new FontAwesome.Sharp.IconButton();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnIn.SuspendLayout();
            this.pnQC.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnOut.SuspendLayout();
            this.pnChart.SuspendLayout();
            this.pnSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(1408, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 33);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(1436, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 33);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1467, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.mesclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEAM4 | SUJIN CHAMICAL | MES";
            // 
            // btnham
            // 
            this.btnham.FlatAppearance.BorderSize = 0;
            this.btnham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnham.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnham.IconColor = System.Drawing.Color.Black;
            this.btnham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnham.IconSize = 30;
            this.btnham.Location = new System.Drawing.Point(14, 3);
            this.btnham.Name = "btnham";
            this.btnham.Size = new System.Drawing.Size(46, 36);
            this.btnham.TabIndex = 2;
            this.btnham.UseVisualStyleBackColor = true;
            this.btnham.Click += new System.EventHandler(this.btnham_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnMain);
            this.sidebar.Controls.Add(this.pnIn);
            this.sidebar.Controls.Add(this.pnQC);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnOut);
            this.sidebar.Controls.Add(this.pnChart);
            this.sidebar.Controls.Add(this.pnSystem);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 42);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(237, 758);
            this.sidebar.TabIndex = 1;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.Main);
            this.pnMain.Location = new System.Drawing.Point(3, 33);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(233, 45);
            this.pnMain.TabIndex = 3;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Main.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.ForeColor = System.Drawing.Color.White;
            this.Main.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Main.IconColor = System.Drawing.Color.White;
            this.Main.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Main.IconSize = 32;
            this.Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main.Location = new System.Drawing.Point(-4, -17);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Main.Size = new System.Drawing.Size(253, 84);
            this.Main.TabIndex = 4;
            this.Main.Text = "           메인";
            this.Main.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pnIn
            // 
            this.pnIn.Controls.Add(this.Input);
            this.pnIn.Location = new System.Drawing.Point(3, 84);
            this.pnIn.Name = "pnIn";
            this.pnIn.Size = new System.Drawing.Size(233, 45);
            this.pnIn.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Input.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.Input.IconColor = System.Drawing.Color.White;
            this.Input.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Input.IconSize = 32;
            this.Input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Input.Location = new System.Drawing.Point(-4, -19);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Input.Size = new System.Drawing.Size(253, 84);
            this.Input.TabIndex = 4;
            this.Input.Text = "           자재";
            this.Input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Input.UseVisualStyleBackColor = false;
            this.Input.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // pnQC
            // 
            this.pnQC.Controls.Add(this.Qc);
            this.pnQC.Location = new System.Drawing.Point(3, 135);
            this.pnQC.Name = "pnQC";
            this.pnQC.Size = new System.Drawing.Size(233, 45);
            this.pnQC.TabIndex = 3;
            // 
            // Qc
            // 
            this.Qc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Qc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qc.ForeColor = System.Drawing.Color.White;
            this.Qc.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.Qc.IconColor = System.Drawing.Color.White;
            this.Qc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Qc.IconSize = 32;
            this.Qc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qc.Location = new System.Drawing.Point(-4, -19);
            this.Qc.Name = "Qc";
            this.Qc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Qc.Size = new System.Drawing.Size(253, 84);
            this.Qc.TabIndex = 4;
            this.Qc.Text = "           품질";
            this.Qc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qc.UseVisualStyleBackColor = false;
            this.Qc.Click += new System.EventHandler(this.Qc_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Location = new System.Drawing.Point(0, 183);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(233, 144);
            this.menuContainer.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Wokrview);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 45);
            this.panel3.TabIndex = 3;
            // 
            // Wokrview
            // 
            this.Wokrview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Wokrview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wokrview.ForeColor = System.Drawing.Color.White;
            this.Wokrview.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.Wokrview.IconColor = System.Drawing.Color.White;
            this.Wokrview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wokrview.IconSize = 32;
            this.Wokrview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wokrview.Location = new System.Drawing.Point(-4, -19);
            this.Wokrview.Name = "Wokrview";
            this.Wokrview.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Wokrview.Size = new System.Drawing.Size(253, 84);
            this.Wokrview.TabIndex = 4;
            this.Wokrview.Text = "           생산";
            this.Wokrview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wokrview.UseVisualStyleBackColor = false;
            this.Wokrview.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Plan);
            this.panel6.Location = new System.Drawing.Point(0, 45);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 45);
            this.panel6.TabIndex = 3;
            // 
            // Plan
            // 
            this.Plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Plan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plan.ForeColor = System.Drawing.Color.White;
            this.Plan.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.Plan.IconColor = System.Drawing.Color.White;
            this.Plan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Plan.IconSize = 25;
            this.Plan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plan.Location = new System.Drawing.Point(-4, -19);
            this.Plan.Name = "Plan";
            this.Plan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Plan.Size = new System.Drawing.Size(253, 84);
            this.Plan.TabIndex = 4;
            this.Plan.Text = "           생산 계획";
            this.Plan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plan.UseVisualStyleBackColor = false;
            this.Plan.Click += new System.EventHandler(this.Plan_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Inventory);
            this.panel7.Location = new System.Drawing.Point(0, 90);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 45);
            this.panel7.TabIndex = 4;
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Inventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.ForeColor = System.Drawing.Color.White;
            this.Inventory.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.Inventory.IconColor = System.Drawing.Color.White;
            this.Inventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Inventory.IconSize = 25;
            this.Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.Location = new System.Drawing.Point(-4, -19);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Inventory.Size = new System.Drawing.Size(253, 84);
            this.Inventory.TabIndex = 4;
            this.Inventory.Text = "           베스/약품 관리";
            this.Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // pnOut
            // 
            this.pnOut.Controls.Add(this.Output);
            this.pnOut.Location = new System.Drawing.Point(3, 330);
            this.pnOut.Name = "pnOut";
            this.pnOut.Size = new System.Drawing.Size(233, 45);
            this.pnOut.TabIndex = 5;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.Output.IconColor = System.Drawing.Color.White;
            this.Output.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Output.IconSize = 32;
            this.Output.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Output.Location = new System.Drawing.Point(-4, -19);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Output.Size = new System.Drawing.Size(253, 84);
            this.Output.TabIndex = 4;
            this.Output.Text = "           출고";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.Chart);
            this.pnChart.Location = new System.Drawing.Point(3, 381);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(233, 45);
            this.pnChart.TabIndex = 6;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Chart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.ForeColor = System.Drawing.Color.White;
            this.Chart.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.Chart.IconColor = System.Drawing.Color.White;
            this.Chart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Chart.IconSize = 32;
            this.Chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart.Location = new System.Drawing.Point(-4, -19);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Chart.Size = new System.Drawing.Size(253, 84);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "           통계";
            this.Chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart.UseVisualStyleBackColor = false;
            this.Chart.Click += new System.EventHandler(this.Chart_Click);
            // 
            // pnSystem
            // 
            this.pnSystem.Controls.Add(this.Systemmain);
            this.pnSystem.Location = new System.Drawing.Point(3, 432);
            this.pnSystem.Name = "pnSystem";
            this.pnSystem.Size = new System.Drawing.Size(233, 45);
            this.pnSystem.TabIndex = 7;
            // 
            // Systemmain
            // 
            this.Systemmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Systemmain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Systemmain.ForeColor = System.Drawing.Color.White;
            this.Systemmain.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Systemmain.IconColor = System.Drawing.Color.White;
            this.Systemmain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Systemmain.IconSize = 32;
            this.Systemmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Systemmain.Location = new System.Drawing.Point(-4, -19);
            this.Systemmain.Name = "Systemmain";
            this.Systemmain.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Systemmain.Size = new System.Drawing.Size(253, 84);
            this.Systemmain.TabIndex = 4;
            this.Systemmain.Text = "           관리";
            this.Systemmain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Systemmain.UseVisualStyleBackColor = false;
            this.Systemmain.Click += new System.EventHandler(this.Systemmain_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnIn.ResumeLayout(false);
            this.pnQC.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnOut.ResumeLayout(false);
            this.pnChart.ResumeLayout(false);
            this.pnSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconButton Main;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Wokrview;
        private System.Windows.Forms.Panel pnIn;
        private FontAwesome.Sharp.IconButton Input;
        private System.Windows.Forms.Panel pnQC;
        private FontAwesome.Sharp.IconButton Qc;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton Plan;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton Inventory;
        private System.Windows.Forms.Panel pnOut;
        private FontAwesome.Sharp.IconButton Output;
        private System.Windows.Forms.Panel pnChart;
        private FontAwesome.Sharp.IconButton Chart;
        private System.Windows.Forms.Panel pnSystem;
        private FontAwesome.Sharp.IconButton Systemmain;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
    }
}

