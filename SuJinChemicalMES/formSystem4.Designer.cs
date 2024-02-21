
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CheUserDepartment_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheUserName_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserDelet_bt = new System.Windows.Forms.Button();
            this.UserCheck_bt = new System.Windows.Forms.Button();
            this.CheUserRank_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserCorrect_bt = new System.Windows.Forms.Button();
            this.UserList_dgv = new System.Windows.Forms.DataGridView();
            this.checkCB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheUserID_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UserCheck_pn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dgv)).BeginInit();
            this.UserCheck_pn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheUserDepartment_tb
            // 
            this.CheUserDepartment_tb.Location = new System.Drawing.Point(124, 61);
            this.CheUserDepartment_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserDepartment_tb.Multiline = true;
            this.CheUserDepartment_tb.Name = "CheUserDepartment_tb";
            this.CheUserDepartment_tb.Size = new System.Drawing.Size(120, 21);
            this.CheUserDepartment_tb.TabIndex = 18;
            this.CheUserDepartment_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // CheUserName_tb
            // 
            this.CheUserName_tb.Location = new System.Drawing.Point(124, 21);
            this.CheUserName_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserName_tb.Multiline = true;
            this.CheUserName_tb.Name = "CheUserName_tb";
            this.CheUserName_tb.Size = new System.Drawing.Size(120, 21);
            this.CheUserName_tb.TabIndex = 13;
            this.CheUserName_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // UserDelet_bt
            // 
            this.UserDelet_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDelet_bt.BackColor = System.Drawing.Color.White;
            this.UserDelet_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDelet_bt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.UserDelet_bt.Location = new System.Drawing.Point(962, 34);
            this.UserDelet_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserDelet_bt.Name = "UserDelet_bt";
            this.UserDelet_bt.Size = new System.Drawing.Size(93, 38);
            this.UserDelet_bt.TabIndex = 22;
            this.UserDelet_bt.Text = "삭제";
            this.UserDelet_bt.UseVisualStyleBackColor = false;
            this.UserDelet_bt.Click += new System.EventHandler(this.UserDelet_bt_Click);
            // 
            // UserCheck_bt
            // 
            this.UserCheck_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserCheck_bt.BackColor = System.Drawing.Color.White;
            this.UserCheck_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserCheck_bt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.UserCheck_bt.Location = new System.Drawing.Point(768, 34);
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
            this.CheUserRank_tb.Multiline = true;
            this.CheUserRank_tb.Name = "CheUserRank_tb";
            this.CheUserRank_tb.Size = new System.Drawing.Size(120, 21);
            this.CheUserRank_tb.TabIndex = 19;
            this.CheUserRank_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // UserCorrect_bt
            // 
            this.UserCorrect_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserCorrect_bt.BackColor = System.Drawing.Color.White;
            this.UserCorrect_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserCorrect_bt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.UserCorrect_bt.Location = new System.Drawing.Point(865, 34);
            this.UserCorrect_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCorrect_bt.Name = "UserCorrect_bt";
            this.UserCorrect_bt.Size = new System.Drawing.Size(93, 38);
            this.UserCorrect_bt.TabIndex = 21;
            this.UserCorrect_bt.Text = "수정";
            this.UserCorrect_bt.UseVisualStyleBackColor = false;
            this.UserCorrect_bt.Click += new System.EventHandler(this.UserCorrect_bt_Click);
            // 
            // UserList_dgv
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserList_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserList_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkCB,
            this.username,
            this.userID,
            this.userPW,
            this.userdepartment,
            this.userrank});
            this.UserList_dgv.Location = new System.Drawing.Point(22, 206);
            this.UserList_dgv.Margin = new System.Windows.Forms.Padding(23, 3, 23, 23);
            this.UserList_dgv.Name = "UserList_dgv";
            this.UserList_dgv.RowHeadersWidth = 4;
            this.UserList_dgv.RowTemplate.Height = 27;
            this.UserList_dgv.Size = new System.Drawing.Size(1059, 386);
            this.UserList_dgv.TabIndex = 30;
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
            // CheUserID_tb
            // 
            this.CheUserID_tb.Location = new System.Drawing.Point(361, 21);
            this.CheUserID_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheUserID_tb.Multiline = true;
            this.CheUserID_tb.Name = "CheUserID_tb";
            this.CheUserID_tb.Size = new System.Drawing.Size(120, 21);
            this.CheUserID_tb.TabIndex = 14;
            this.CheUserID_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(923, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 30, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "사용자 등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserCheck_pn
            // 
            this.UserCheck_pn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.UserCheck_pn.Location = new System.Drawing.Point(22, 76);
            this.UserCheck_pn.Margin = new System.Windows.Forms.Padding(23, 2, 23, 2);
            this.UserCheck_pn.Name = "UserCheck_pn";
            this.UserCheck_pn.Size = new System.Drawing.Size(1059, 92);
            this.UserCheck_pn.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(22, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 24);
            this.panel1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "사용자 조회";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(22, 183);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 24);
            this.panel3.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "사용자 목록";
            // 
            // formSystem4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserList_dgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserCheck_pn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSystem4";
            this.Text = "formSystem4";
            this.Load += new System.EventHandler(this.formSystem4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dgv)).EndInit();
            this.UserCheck_pn.ResumeLayout(false);
            this.UserCheck_pn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CheUserDepartment_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CheUserName_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UserDelet_bt;
        private System.Windows.Forms.Button UserCheck_bt;
        private System.Windows.Forms.TextBox CheUserRank_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserCorrect_bt;
        private System.Windows.Forms.DataGridView UserList_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrank;
        private System.Windows.Forms.TextBox CheUserID_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel UserCheck_pn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
    }
}