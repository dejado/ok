
namespace SuJinChemicalMES
{
    partial class formSystem4
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
            this.UserCheck_pn = new System.Windows.Forms.Panel();
            this.UserDelet_bt = new System.Windows.Forms.Button();
            this.UserCorrect_bt = new System.Windows.Forms.Button();
            this.UserCheck_bt = new System.Windows.Forms.Button();
            this.CheUserRank_tb = new System.Windows.Forms.TextBox();
            this.CheUserDepartment_tb = new System.Windows.Forms.TextBox();
            this.CheUserID_tb = new System.Windows.Forms.TextBox();
            this.CheUserName_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UserList_lb = new System.Windows.Forms.Label();
            this.UserList_dgv = new System.Windows.Forms.DataGridView();
            this.checkCB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCheck_tlpn = new System.Windows.Forms.TableLayoutPanel();
            this.UserCheck_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserCheck_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dgv)).BeginInit();
            this.UserCheck_tlpn.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserCheck_pn
            // 
            this.UserCheck_pn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserCheck_pn.Controls.Add(this.CheUserRank_tb);
            this.UserCheck_pn.Controls.Add(this.CheUserID_tb);
            this.UserCheck_pn.Controls.Add(this.label3);
            this.UserCheck_pn.Controls.Add(this.label2);
            this.UserCheck_pn.Controls.Add(this.CheUserDepartment_tb);
            this.UserCheck_pn.Controls.Add(this.label1);
            this.UserCheck_pn.Controls.Add(this.CheUserName_tb);
            this.UserCheck_pn.Controls.Add(this.label4);
            this.UserCheck_pn.Controls.Add(this.UserDelet_bt);
            this.UserCheck_pn.Controls.Add(this.UserCorrect_bt);
            this.UserCheck_pn.Controls.Add(this.UserCheck_bt);
            this.UserCheck_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCheck_pn.Location = new System.Drawing.Point(23, 70);
            this.UserCheck_pn.Margin = new System.Windows.Forms.Padding(23, 2, 23, 2);
            this.UserCheck_pn.Name = "UserCheck_pn";
            this.UserCheck_pn.Size = new System.Drawing.Size(1059, 98);
            this.UserCheck_pn.TabIndex = 14;
            // 
            // UserDelet_bt
            // 
            this.UserDelet_bt.BackColor = System.Drawing.Color.White;
            this.UserDelet_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDelet_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDelet_bt.Location = new System.Drawing.Point(962, 34);
            this.UserDelet_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserDelet_bt.Name = "UserDelet_bt";
            this.UserDelet_bt.Size = new System.Drawing.Size(93, 38);
            this.UserDelet_bt.TabIndex = 22;
            this.UserDelet_bt.Text = "삭제";
            this.UserDelet_bt.UseVisualStyleBackColor = false;
            this.UserDelet_bt.Click += new System.EventHandler(this.UserDelet_bt_Click);
            // 
            // UserCorrect_bt
            // 
            this.UserCorrect_bt.BackColor = System.Drawing.Color.White;
            this.UserCorrect_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserCorrect_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCorrect_bt.Location = new System.Drawing.Point(864, 34);
            this.UserCorrect_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCorrect_bt.Name = "UserCorrect_bt";
            this.UserCorrect_bt.Size = new System.Drawing.Size(93, 38);
            this.UserCorrect_bt.TabIndex = 21;
            this.UserCorrect_bt.Text = "수정";
            this.UserCorrect_bt.UseVisualStyleBackColor = false;
            this.UserCorrect_bt.Click += new System.EventHandler(this.UserCorrect_bt_Click);
            // 
            // UserCheck_bt
            // 
            this.UserCheck_bt.BackColor = System.Drawing.Color.White;
            this.UserCheck_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserCheck_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCheck_bt.Location = new System.Drawing.Point(767, 34);
            this.UserCheck_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCheck_bt.Name = "UserCheck_bt";
            this.UserCheck_bt.Size = new System.Drawing.Size(93, 38);
            this.UserCheck_bt.TabIndex = 20;
            this.UserCheck_bt.Text = "조회";
            this.UserCheck_bt.UseVisualStyleBackColor = false;
            this.UserCheck_bt.Click += new System.EventHandler(this.UserCheck_bt_Click);
            // 
            // CheUserRank_tb
            // 
            this.CheUserRank_tb.Location = new System.Drawing.Point(361, 61);
            this.CheUserRank_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserRank_tb.Name = "CheUserRank_tb";
            this.CheUserRank_tb.Size = new System.Drawing.Size(120, 23);
            this.CheUserRank_tb.TabIndex = 19;
            this.CheUserRank_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheUserDepartment_tb
            // 
            this.CheUserDepartment_tb.Location = new System.Drawing.Point(124, 61);
            this.CheUserDepartment_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserDepartment_tb.Name = "CheUserDepartment_tb";
            this.CheUserDepartment_tb.Size = new System.Drawing.Size(120, 23);
            this.CheUserDepartment_tb.TabIndex = 18;
            this.CheUserDepartment_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheUserID_tb
            // 
            this.CheUserID_tb.Location = new System.Drawing.Point(361, 21);
            this.CheUserID_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserID_tb.Name = "CheUserID_tb";
            this.CheUserID_tb.Size = new System.Drawing.Size(120, 23);
            this.CheUserID_tb.TabIndex = 14;
            this.CheUserID_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheUserName_tb
            // 
            this.CheUserName_tb.Location = new System.Drawing.Point(124, 21);
            this.CheUserName_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserName_tb.Name = "CheUserName_tb";
            this.CheUserName_tb.Size = new System.Drawing.Size(120, 23);
            this.CheUserName_tb.TabIndex = 13;
            this.CheUserName_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(916, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 30, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "사용자 등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserList_lb
            // 
            this.UserList_lb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserList_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserList_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList_lb.Location = new System.Drawing.Point(23, 170);
            this.UserList_lb.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.UserList_lb.Name = "UserList_lb";
            this.UserList_lb.Size = new System.Drawing.Size(1059, 24);
            this.UserList_lb.TabIndex = 24;
            this.UserList_lb.Text = "사용자 목록";
            this.UserList_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserList_dgv
            // 
            this.UserList_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkCB,
            this.username,
            this.userID,
            this.userPW,
            this.userdepartment,
            this.userrank});
            this.UserList_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserList_dgv.Location = new System.Drawing.Point(23, 197);
            this.UserList_dgv.Margin = new System.Windows.Forms.Padding(23, 3, 23, 23);
            this.UserList_dgv.Name = "UserList_dgv";
            this.UserList_dgv.RowHeadersWidth = 4;
            this.UserList_dgv.RowTemplate.Height = 27;
            this.UserList_dgv.Size = new System.Drawing.Size(1059, 386);
            this.UserList_dgv.TabIndex = 25;
            // 
            // checkCB
            // 
            this.checkCB.HeaderText = "선택";
            this.checkCB.MinimumWidth = 6;
            this.checkCB.Name = "checkCB";
            this.checkCB.Width = 60;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "이름";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "ID";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            this.userID.Width = 125;
            // 
            // userPW
            // 
            this.userPW.DataPropertyName = "userPW";
            this.userPW.HeaderText = "PW";
            this.userPW.MinimumWidth = 6;
            this.userPW.Name = "userPW";
            this.userPW.Width = 125;
            // 
            // userdepartment
            // 
            this.userdepartment.DataPropertyName = "userdepartment";
            this.userdepartment.HeaderText = "부서";
            this.userdepartment.MinimumWidth = 6;
            this.userdepartment.Name = "userdepartment";
            this.userdepartment.Width = 125;
            // 
            // userrank
            // 
            this.userrank.DataPropertyName = "userrank";
            this.userrank.HeaderText = "직급";
            this.userrank.MinimumWidth = 6;
            this.userrank.Name = "userrank";
            this.userrank.Width = 125;
            // 
            // UserCheck_tlpn
            // 
            this.UserCheck_tlpn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserCheck_tlpn.ColumnCount = 1;
            this.UserCheck_tlpn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserCheck_tlpn.Controls.Add(this.UserList_dgv, 0, 4);
            this.UserCheck_tlpn.Controls.Add(this.UserList_lb, 0, 3);
            this.UserCheck_tlpn.Controls.Add(this.button1, 0, 0);
            this.UserCheck_tlpn.Controls.Add(this.UserCheck_pn, 0, 2);
            this.UserCheck_tlpn.Controls.Add(this.UserCheck_lb, 0, 1);
            this.UserCheck_tlpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCheck_tlpn.Location = new System.Drawing.Point(0, 0);
            this.UserCheck_tlpn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCheck_tlpn.Name = "UserCheck_tlpn";
            this.UserCheck_tlpn.RowCount = 5;
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.519789F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.960396F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.9967F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.125412F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.82178F));
            this.UserCheck_tlpn.Size = new System.Drawing.Size(1105, 606);
            this.UserCheck_tlpn.TabIndex = 1;
            // 
            // UserCheck_lb
            // 
            this.UserCheck_lb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserCheck_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCheck_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCheck_lb.Location = new System.Drawing.Point(23, 45);
            this.UserCheck_lb.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.UserCheck_lb.Name = "UserCheck_lb";
            this.UserCheck_lb.Size = new System.Drawing.Size(1059, 23);
            this.UserCheck_lb.TabIndex = 9;
            this.UserCheck_lb.Text = "사용자 조회";
            this.UserCheck_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "이름";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "부서";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "직급";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formSystem4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 606);
            this.Controls.Add(this.UserCheck_tlpn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSystem4";
            this.Text = "formSystem4";
            this.Load += new System.EventHandler(this.formSystem4_Load);
            this.UserCheck_pn.ResumeLayout(false);
            this.UserCheck_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dgv)).EndInit();
            this.UserCheck_tlpn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel UserCheck_pn;
        private System.Windows.Forms.Button UserDelet_bt;
        private System.Windows.Forms.Button UserCorrect_bt;
        private System.Windows.Forms.Button UserCheck_bt;
        private System.Windows.Forms.TextBox CheUserRank_tb;
        private System.Windows.Forms.TextBox CheUserDepartment_tb;
        private System.Windows.Forms.TextBox CheUserID_tb;
        private System.Windows.Forms.TextBox CheUserName_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserList_lb;
        private System.Windows.Forms.DataGridView UserList_dgv;
        private System.Windows.Forms.TableLayoutPanel UserCheck_tlpn;
        private System.Windows.Forms.Label UserCheck_lb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}