
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
            this.UserCheck_tlpn = new System.Windows.Forms.TableLayoutPanel();
            this.UserList_dgv = new System.Windows.Forms.DataGridView();
            this.checkCB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserList_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UserCheck_pn = new System.Windows.Forms.Panel();
            this.UserDelet_bt = new System.Windows.Forms.Button();
            this.UserCorrect_bt = new System.Windows.Forms.Button();
            this.UserCheck_bt = new System.Windows.Forms.Button();
            this.CheUserRank_tb = new System.Windows.Forms.TextBox();
            this.CheUserDepartment_tb = new System.Windows.Forms.TextBox();
            this.CheUserRank_lb = new System.Windows.Forms.Label();
            this.CheUserDepartment_lb = new System.Windows.Forms.Label();
            this.CheUserID_tb = new System.Windows.Forms.TextBox();
            this.CheUserName_tb = new System.Windows.Forms.TextBox();
            this.CheUserID_lb = new System.Windows.Forms.Label();
            this.CheUserName_lb = new System.Windows.Forms.Label();
            this.UserCheck_lb = new System.Windows.Forms.Label();
            this.UserCheck_tlpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dgv)).BeginInit();
            this.UserCheck_pn.SuspendLayout();
            this.SuspendLayout();
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
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37868F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.067321F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.05063F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.797468F));
            this.UserCheck_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0872F));
            this.UserCheck_tlpn.Size = new System.Drawing.Size(1263, 758);
            this.UserCheck_tlpn.TabIndex = 1;
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
            this.UserList_dgv.Location = new System.Drawing.Point(3, 320);
            this.UserList_dgv.Name = "UserList_dgv";
            this.UserList_dgv.RowHeadersWidth = 51;
            this.UserList_dgv.RowTemplate.Height = 27;
            this.UserList_dgv.Size = new System.Drawing.Size(1257, 435);
            this.UserList_dgv.TabIndex = 25;
            // 
            // checkCB
            // 
            this.checkCB.HeaderText = "선택";
            this.checkCB.MinimumWidth = 6;
            this.checkCB.Name = "checkCB";
            this.checkCB.Width = 125;
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
            // UserList_lb
            // 
            this.UserList_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserList_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserList_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList_lb.Location = new System.Drawing.Point(3, 289);
            this.UserList_lb.Name = "UserList_lb";
            this.UserList_lb.Size = new System.Drawing.Size(1257, 28);
            this.UserList_lb.TabIndex = 24;
            this.UserList_lb.Text = "사용자 목록";
            this.UserList_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1078, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 70);
            this.button1.TabIndex = 23;
            this.button1.Text = "사용자 등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserCheck_pn
            // 
            this.UserCheck_pn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserCheck_pn.Controls.Add(this.UserDelet_bt);
            this.UserCheck_pn.Controls.Add(this.UserCorrect_bt);
            this.UserCheck_pn.Controls.Add(this.UserCheck_bt);
            this.UserCheck_pn.Controls.Add(this.CheUserRank_tb);
            this.UserCheck_pn.Controls.Add(this.CheUserDepartment_tb);
            this.UserCheck_pn.Controls.Add(this.CheUserRank_lb);
            this.UserCheck_pn.Controls.Add(this.CheUserDepartment_lb);
            this.UserCheck_pn.Controls.Add(this.CheUserID_tb);
            this.UserCheck_pn.Controls.Add(this.CheUserName_tb);
            this.UserCheck_pn.Controls.Add(this.CheUserID_lb);
            this.UserCheck_pn.Controls.Add(this.CheUserName_lb);
            this.UserCheck_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCheck_pn.Location = new System.Drawing.Point(3, 112);
            this.UserCheck_pn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCheck_pn.Name = "UserCheck_pn";
            this.UserCheck_pn.Size = new System.Drawing.Size(1257, 173);
            this.UserCheck_pn.TabIndex = 14;
            // 
            // UserDelet_bt
            // 
            this.UserDelet_bt.BackColor = System.Drawing.Color.White;
            this.UserDelet_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDelet_bt.Location = new System.Drawing.Point(1124, 93);
            this.UserDelet_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserDelet_bt.Name = "UserDelet_bt";
            this.UserDelet_bt.Size = new System.Drawing.Size(106, 48);
            this.UserDelet_bt.TabIndex = 22;
            this.UserDelet_bt.Text = "삭제";
            this.UserDelet_bt.UseVisualStyleBackColor = false;
            this.UserDelet_bt.Click += new System.EventHandler(this.UserDelet_bt_Click);
            // 
            // UserCorrect_bt
            // 
            this.UserCorrect_bt.BackColor = System.Drawing.Color.White;
            this.UserCorrect_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCorrect_bt.Location = new System.Drawing.Point(1012, 93);
            this.UserCorrect_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCorrect_bt.Name = "UserCorrect_bt";
            this.UserCorrect_bt.Size = new System.Drawing.Size(106, 48);
            this.UserCorrect_bt.TabIndex = 21;
            this.UserCorrect_bt.Text = "수정";
            this.UserCorrect_bt.UseVisualStyleBackColor = false;
            this.UserCorrect_bt.Click += new System.EventHandler(this.UserCorrect_bt_Click);
            // 
            // UserCheck_bt
            // 
            this.UserCheck_bt.BackColor = System.Drawing.Color.White;
            this.UserCheck_bt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCheck_bt.Location = new System.Drawing.Point(900, 95);
            this.UserCheck_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCheck_bt.Name = "UserCheck_bt";
            this.UserCheck_bt.Size = new System.Drawing.Size(106, 48);
            this.UserCheck_bt.TabIndex = 20;
            this.UserCheck_bt.Text = "조회";
            this.UserCheck_bt.UseVisualStyleBackColor = false;
            this.UserCheck_bt.Click += new System.EventHandler(this.UserCheck_bt_Click);
            // 
            // CheUserRank_tb
            // 
            this.CheUserRank_tb.Location = new System.Drawing.Point(315, 93);
            this.CheUserRank_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserRank_tb.Name = "CheUserRank_tb";
            this.CheUserRank_tb.Size = new System.Drawing.Size(180, 27);
            this.CheUserRank_tb.TabIndex = 19;
            // 
            // CheUserDepartment_tb
            // 
            this.CheUserDepartment_tb.Location = new System.Drawing.Point(315, 40);
            this.CheUserDepartment_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserDepartment_tb.Name = "CheUserDepartment_tb";
            this.CheUserDepartment_tb.Size = new System.Drawing.Size(180, 27);
            this.CheUserDepartment_tb.TabIndex = 18;
            // 
            // CheUserRank_lb
            // 
            this.CheUserRank_lb.BackColor = System.Drawing.Color.LightCyan;
            this.CheUserRank_lb.Location = new System.Drawing.Point(270, 88);
            this.CheUserRank_lb.Name = "CheUserRank_lb";
            this.CheUserRank_lb.Size = new System.Drawing.Size(40, 40);
            this.CheUserRank_lb.TabIndex = 17;
            this.CheUserRank_lb.Text = "직급";
            this.CheUserRank_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheUserDepartment_lb
            // 
            this.CheUserDepartment_lb.BackColor = System.Drawing.Color.LightCyan;
            this.CheUserDepartment_lb.Location = new System.Drawing.Point(270, 36);
            this.CheUserDepartment_lb.Name = "CheUserDepartment_lb";
            this.CheUserDepartment_lb.Size = new System.Drawing.Size(40, 40);
            this.CheUserDepartment_lb.TabIndex = 16;
            this.CheUserDepartment_lb.Text = "부서";
            this.CheUserDepartment_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheUserID_tb
            // 
            this.CheUserID_tb.Location = new System.Drawing.Point(68, 95);
            this.CheUserID_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserID_tb.Name = "CheUserID_tb";
            this.CheUserID_tb.Size = new System.Drawing.Size(180, 27);
            this.CheUserID_tb.TabIndex = 14;
            // 
            // CheUserName_tb
            // 
            this.CheUserName_tb.Location = new System.Drawing.Point(68, 40);
            this.CheUserName_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserName_tb.Name = "CheUserName_tb";
            this.CheUserName_tb.Size = new System.Drawing.Size(180, 27);
            this.CheUserName_tb.TabIndex = 13;
            // 
            // CheUserID_lb
            // 
            this.CheUserID_lb.BackColor = System.Drawing.Color.LightCyan;
            this.CheUserID_lb.Location = new System.Drawing.Point(22, 93);
            this.CheUserID_lb.Name = "CheUserID_lb";
            this.CheUserID_lb.Size = new System.Drawing.Size(40, 40);
            this.CheUserID_lb.TabIndex = 11;
            this.CheUserID_lb.Text = "ID";
            this.CheUserID_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheUserName_lb
            // 
            this.CheUserName_lb.BackColor = System.Drawing.Color.LightCyan;
            this.CheUserName_lb.Location = new System.Drawing.Point(22, 40);
            this.CheUserName_lb.Name = "CheUserName_lb";
            this.CheUserName_lb.Size = new System.Drawing.Size(40, 40);
            this.CheUserName_lb.TabIndex = 10;
            this.CheUserName_lb.Text = "이름";
            this.CheUserName_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserCheck_lb
            // 
            this.UserCheck_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserCheck_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCheck_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCheck_lb.Location = new System.Drawing.Point(3, 78);
            this.UserCheck_lb.Name = "UserCheck_lb";
            this.UserCheck_lb.Size = new System.Drawing.Size(1257, 30);
            this.UserCheck_lb.TabIndex = 9;
            this.UserCheck_lb.Text = "사용자 조회";
            this.UserCheck_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formSystem4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 758);
            this.Controls.Add(this.UserCheck_tlpn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSystem4";
            this.Text = "formSystem4";
            this.Load += new System.EventHandler(this.formSystem4_Load);
            this.UserCheck_tlpn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dgv)).EndInit();
            this.UserCheck_pn.ResumeLayout(false);
            this.UserCheck_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UserCheck_tlpn;
        private System.Windows.Forms.DataGridView UserList_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrank;
        private System.Windows.Forms.Label UserList_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel UserCheck_pn;
        private System.Windows.Forms.Button UserDelet_bt;
        private System.Windows.Forms.Button UserCorrect_bt;
        private System.Windows.Forms.Button UserCheck_bt;
        private System.Windows.Forms.TextBox CheUserRank_tb;
        private System.Windows.Forms.TextBox CheUserDepartment_tb;
        private System.Windows.Forms.Label CheUserRank_lb;
        private System.Windows.Forms.Label CheUserDepartment_lb;
        private System.Windows.Forms.TextBox CheUserID_tb;
        private System.Windows.Forms.TextBox CheUserName_tb;
        private System.Windows.Forms.Label CheUserID_lb;
        private System.Windows.Forms.Label CheUserName_lb;
        private System.Windows.Forms.Label UserCheck_lb;
    }
}