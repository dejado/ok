
namespace SuJinChemicalMES
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_tlpn = new System.Windows.Forms.TableLayoutPanel();
            this.MainMoni_lb = new System.Windows.Forms.Label();
            this.Calendar_pn = new System.Windows.Forms.Panel();
            this.Calendar_dtp = new System.Windows.Forms.DateTimePicker();
            this.Calendar_lb = new System.Windows.Forms.Label();
            this.Mainright_tlpn = new System.Windows.Forms.TableLayoutPanel();
            this.Achieve_lb = new System.Windows.Forms.Label();
            this.CalendarControl_pn = new System.Windows.Forms.Panel();
            this.CalendarPick_bt = new System.Windows.Forms.Button();
            this.Calendar_cal = new Calendar.NET.Calendar();
            this.Main_tlpn.SuspendLayout();
            this.Calendar_pn.SuspendLayout();
            this.Mainright_tlpn.SuspendLayout();
            this.CalendarControl_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tlpn
            // 
            this.Main_tlpn.ColumnCount = 2;
            this.Main_tlpn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.46661F));
            this.Main_tlpn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.53339F));
            this.Main_tlpn.Controls.Add(this.MainMoni_lb, 0, 0);
            this.Main_tlpn.Controls.Add(this.Calendar_pn, 1, 0);
            this.Main_tlpn.Controls.Add(this.Mainright_tlpn, 1, 1);
            this.Main_tlpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tlpn.Location = new System.Drawing.Point(0, 0);
            this.Main_tlpn.Name = "Main_tlpn";
            this.Main_tlpn.RowCount = 2;
            this.Main_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 725F));
            this.Main_tlpn.Size = new System.Drawing.Size(1263, 758);
            this.Main_tlpn.TabIndex = 1;
            // 
            // MainMoni_lb
            // 
            this.MainMoni_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainMoni_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMoni_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMoni_lb.Location = new System.Drawing.Point(3, 0);
            this.MainMoni_lb.Name = "MainMoni_lb";
            this.MainMoni_lb.Size = new System.Drawing.Size(505, 33);
            this.MainMoni_lb.TabIndex = 4;
            this.MainMoni_lb.Text = "생산 현황";
            // 
            // Calendar_pn
            // 
            this.Calendar_pn.Controls.Add(this.Calendar_dtp);
            this.Calendar_pn.Controls.Add(this.Calendar_lb);
            this.Calendar_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar_pn.Location = new System.Drawing.Point(514, 3);
            this.Calendar_pn.Name = "Calendar_pn";
            this.Calendar_pn.Size = new System.Drawing.Size(746, 27);
            this.Calendar_pn.TabIndex = 6;
            // 
            // Calendar_dtp
            // 
            this.Calendar_dtp.Dock = System.Windows.Forms.DockStyle.Right;
            this.Calendar_dtp.Location = new System.Drawing.Point(511, 0);
            this.Calendar_dtp.Name = "Calendar_dtp";
            this.Calendar_dtp.Size = new System.Drawing.Size(235, 27);
            this.Calendar_dtp.TabIndex = 8;
            this.Calendar_dtp.ValueChanged += new System.EventHandler(this.Calendar_dtp_ValueChanged);
            // 
            // Calendar_lb
            // 
            this.Calendar_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Calendar_lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.Calendar_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_lb.Location = new System.Drawing.Point(0, 0);
            this.Calendar_lb.Name = "Calendar_lb";
            this.Calendar_lb.Size = new System.Drawing.Size(565, 27);
            this.Calendar_lb.TabIndex = 7;
            this.Calendar_lb.Text = "일정표";
            // 
            // Mainright_tlpn
            // 
            this.Mainright_tlpn.BackColor = System.Drawing.Color.White;
            this.Mainright_tlpn.ColumnCount = 1;
            this.Mainright_tlpn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83766F));
            this.Mainright_tlpn.Controls.Add(this.Achieve_lb, 0, 1);
            this.Mainright_tlpn.Controls.Add(this.CalendarControl_pn, 0, 0);
            this.Mainright_tlpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainright_tlpn.Location = new System.Drawing.Point(514, 36);
            this.Mainright_tlpn.Name = "Mainright_tlpn";
            this.Mainright_tlpn.RowCount = 3;
            this.Mainright_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.85343F));
            this.Mainright_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146572F));
            this.Mainright_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.Mainright_tlpn.Size = new System.Drawing.Size(746, 719);
            this.Mainright_tlpn.TabIndex = 0;
            // 
            // Achieve_lb
            // 
            this.Achieve_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Achieve_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Achieve_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achieve_lb.Location = new System.Drawing.Point(3, 427);
            this.Achieve_lb.Name = "Achieve_lb";
            this.Achieve_lb.Size = new System.Drawing.Size(740, 28);
            this.Achieve_lb.TabIndex = 5;
            this.Achieve_lb.Text = "일일 달성률";
            // 
            // CalendarControl_pn
            // 
            this.CalendarControl_pn.Controls.Add(this.CalendarPick_bt);
            this.CalendarControl_pn.Controls.Add(this.Calendar_cal);
            this.CalendarControl_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarControl_pn.Location = new System.Drawing.Point(3, 3);
            this.CalendarControl_pn.Name = "CalendarControl_pn";
            this.CalendarControl_pn.Size = new System.Drawing.Size(740, 421);
            this.CalendarControl_pn.TabIndex = 6;
            // 
            // CalendarPick_bt
            // 
            this.CalendarPick_bt.BackColor = System.Drawing.Color.LightCyan;
            this.CalendarPick_bt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CalendarPick_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarPick_bt.Location = new System.Drawing.Point(389, 3);
            this.CalendarPick_bt.Name = "CalendarPick_bt";
            this.CalendarPick_bt.Size = new System.Drawing.Size(109, 36);
            this.CalendarPick_bt.TabIndex = 4;
            this.CalendarPick_bt.Text = "생산계획";
            this.CalendarPick_bt.UseVisualStyleBackColor = false;
            this.CalendarPick_bt.Click += new System.EventHandler(this.CalendarPick_bt_Click);
            // 
            // Calendar_cal
            // 
            this.Calendar_cal.AllowEditingEvents = true;
            this.Calendar_cal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calendar_cal.CalendarDate = new System.DateTime(2024, 2, 14, 23, 10, 54, 584);
            this.Calendar_cal.CalendarView = Calendar.NET.CalendarViews.Month;
            this.Calendar_cal.DateHeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DayOfWeekFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DaysFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DayViewTimeFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DimDisabledEvents = true;
            this.Calendar_cal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar_cal.HighlightCurrentDay = true;
            this.Calendar_cal.LoadPresetHolidays = true;
            this.Calendar_cal.Location = new System.Drawing.Point(0, 0);
            this.Calendar_cal.Name = "Calendar_cal";
            this.Calendar_cal.ShowArrowControls = true;
            this.Calendar_cal.ShowDashedBorderOnDisabledEvents = true;
            this.Calendar_cal.ShowDateInHeader = true;
            this.Calendar_cal.ShowDisabledEvents = false;
            this.Calendar_cal.ShowEventTooltips = true;
            this.Calendar_cal.ShowTodayButton = true;
            this.Calendar_cal.Size = new System.Drawing.Size(740, 421);
            this.Calendar_cal.TabIndex = 3;
            this.Calendar_cal.TodayFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 758);
            this.Controls.Add(this.Main_tlpn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMain";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Main_tlpn.ResumeLayout(false);
            this.Calendar_pn.ResumeLayout(false);
            this.Mainright_tlpn.ResumeLayout(false);
            this.CalendarControl_pn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_tlpn;
        private System.Windows.Forms.Label MainMoni_lb;
        private System.Windows.Forms.Panel Calendar_pn;
        private System.Windows.Forms.DateTimePicker Calendar_dtp;
        private System.Windows.Forms.Label Calendar_lb;
        private System.Windows.Forms.TableLayoutPanel Mainright_tlpn;
        private System.Windows.Forms.Label Achieve_lb;
        private System.Windows.Forms.Panel CalendarControl_pn;
        private System.Windows.Forms.Button CalendarPick_bt;
        private Calendar.NET.Calendar Calendar_cal;
    }
}