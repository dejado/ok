
namespace SuJinChemicalMES
{
    partial class formSystem4Okay
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
            this.System4Ok_tlpn = new System.Windows.Forms.TableLayoutPanel();
            this.UserRegistration_pn = new System.Windows.Forms.Panel();
            this.IDCheck_lb = new System.Windows.Forms.Label();
            this.UserRegistration_bt = new System.Windows.Forms.Button();
            this.UserRank_tb = new System.Windows.Forms.TextBox();
            this.UserDepartment_tb = new System.Windows.Forms.TextBox();
            this.UserRank_lb = new System.Windows.Forms.Label();
            this.UserDepartment_lb = new System.Windows.Forms.Label();
            this.UserPW_tb = new System.Windows.Forms.TextBox();
            this.UserID_tb = new System.Windows.Forms.TextBox();
            this.UserName_tb = new System.Windows.Forms.TextBox();
            this.UserPW_lb = new System.Windows.Forms.Label();
            this.UserID_lb = new System.Windows.Forms.Label();
            this.UserName_lb = new System.Windows.Forms.Label();
            this.UserRegistration_lb = new System.Windows.Forms.Label();
            this.RegiUserList_lb = new System.Windows.Forms.Label();
            this.RegiUserList_dgv = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.System4Ok_tlpn.SuspendLayout();
            this.UserRegistration_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegiUserList_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // System4Ok_tlpn
            // 
            this.System4Ok_tlpn.ColumnCount = 1;
            this.System4Ok_tlpn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.System4Ok_tlpn.Controls.Add(this.UserRegistration_pn, 0, 1);
            this.System4Ok_tlpn.Controls.Add(this.UserRegistration_lb, 0, 0);
            this.System4Ok_tlpn.Controls.Add(this.RegiUserList_lb, 0, 2);
            this.System4Ok_tlpn.Controls.Add(this.RegiUserList_dgv, 0, 3);
            this.System4Ok_tlpn.Location = new System.Drawing.Point(-1, -1);
            this.System4Ok_tlpn.Name = "System4Ok_tlpn";
            this.System4Ok_tlpn.RowCount = 4;
            this.System4Ok_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67924F));
            this.System4Ok_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.32076F));
            this.System4Ok_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.System4Ok_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 473F));
            this.System4Ok_tlpn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.System4Ok_tlpn.Size = new System.Drawing.Size(1246, 712);
            this.System4Ok_tlpn.TabIndex = 1;
            // 
            // UserRegistration_pn
            // 
            this.UserRegistration_pn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserRegistration_pn.Controls.Add(this.IDCheck_lb);
            this.UserRegistration_pn.Controls.Add(this.UserRegistration_bt);
            this.UserRegistration_pn.Controls.Add(this.UserRank_tb);
            this.UserRegistration_pn.Controls.Add(this.UserDepartment_tb);
            this.UserRegistration_pn.Controls.Add(this.UserRank_lb);
            this.UserRegistration_pn.Controls.Add(this.UserDepartment_lb);
            this.UserRegistration_pn.Controls.Add(this.UserPW_tb);
            this.UserRegistration_pn.Controls.Add(this.UserID_tb);
            this.UserRegistration_pn.Controls.Add(this.UserName_tb);
            this.UserRegistration_pn.Controls.Add(this.UserPW_lb);
            this.UserRegistration_pn.Controls.Add(this.UserID_lb);
            this.UserRegistration_pn.Controls.Add(this.UserName_lb);
            this.UserRegistration_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserRegistration_pn.Location = new System.Drawing.Point(3, 32);
            this.UserRegistration_pn.Name = "UserRegistration_pn";
            this.UserRegistration_pn.Size = new System.Drawing.Size(1240, 177);
            this.UserRegistration_pn.TabIndex = 17;
            // 
            // IDCheck_lb
            // 
            this.IDCheck_lb.AutoSize = true;
            this.IDCheck_lb.Location = new System.Drawing.Point(94, 131);
            this.IDCheck_lb.Name = "IDCheck_lb";
            this.IDCheck_lb.Size = new System.Drawing.Size(0, 20);
            this.IDCheck_lb.TabIndex = 21;
            // 
            // UserRegistration_bt
            // 
            this.UserRegistration_bt.BackColor = System.Drawing.Color.White;
            this.UserRegistration_bt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegistration_bt.Location = new System.Drawing.Point(1015, 30);
            this.UserRegistration_bt.Name = "UserRegistration_bt";
            this.UserRegistration_bt.Size = new System.Drawing.Size(137, 101);
            this.UserRegistration_bt.TabIndex = 20;
            this.UserRegistration_bt.Text = "등록";
            this.UserRegistration_bt.UseVisualStyleBackColor = false;
            this.UserRegistration_bt.Click += new System.EventHandler(this.UserRegistration_bt_Click);
            // 
            // UserRank_tb
            // 
            this.UserRank_tb.Location = new System.Drawing.Point(767, 101);
            this.UserRank_tb.Name = "UserRank_tb";
            this.UserRank_tb.Size = new System.Drawing.Size(180, 27);
            this.UserRank_tb.TabIndex = 19;
            // 
            // UserDepartment_tb
            // 
            this.UserDepartment_tb.Location = new System.Drawing.Point(767, 32);
            this.UserDepartment_tb.Name = "UserDepartment_tb";
            this.UserDepartment_tb.Size = new System.Drawing.Size(180, 27);
            this.UserDepartment_tb.TabIndex = 18;
            // 
            // UserRank_lb
            // 
            this.UserRank_lb.BackColor = System.Drawing.Color.LightCyan;
            this.UserRank_lb.Location = new System.Drawing.Point(721, 101);
            this.UserRank_lb.Name = "UserRank_lb";
            this.UserRank_lb.Size = new System.Drawing.Size(40, 30);
            this.UserRank_lb.TabIndex = 17;
            this.UserRank_lb.Text = "직급";
            this.UserRank_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserDepartment_lb
            // 
            this.UserDepartment_lb.BackColor = System.Drawing.Color.LightCyan;
            this.UserDepartment_lb.Location = new System.Drawing.Point(721, 30);
            this.UserDepartment_lb.Name = "UserDepartment_lb";
            this.UserDepartment_lb.Size = new System.Drawing.Size(40, 30);
            this.UserDepartment_lb.TabIndex = 16;
            this.UserDepartment_lb.Text = "부서";
            this.UserDepartment_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPW_tb
            // 
            this.UserPW_tb.Location = new System.Drawing.Point(451, 101);
            this.UserPW_tb.Name = "UserPW_tb";
            this.UserPW_tb.Size = new System.Drawing.Size(180, 27);
            this.UserPW_tb.TabIndex = 15;
            // 
            // UserID_tb
            // 
            this.UserID_tb.Location = new System.Drawing.Point(451, 36);
            this.UserID_tb.Name = "UserID_tb";
            this.UserID_tb.Size = new System.Drawing.Size(180, 27);
            this.UserID_tb.TabIndex = 14;
            // 
            // UserName_tb
            // 
            this.UserName_tb.Location = new System.Drawing.Point(168, 36);
            this.UserName_tb.Name = "UserName_tb";
            this.UserName_tb.Size = new System.Drawing.Size(180, 27);
            this.UserName_tb.TabIndex = 13;
            // 
            // UserPW_lb
            // 
            this.UserPW_lb.BackColor = System.Drawing.Color.LightCyan;
            this.UserPW_lb.Location = new System.Drawing.Point(405, 101);
            this.UserPW_lb.Name = "UserPW_lb";
            this.UserPW_lb.Size = new System.Drawing.Size(40, 30);
            this.UserPW_lb.TabIndex = 12;
            this.UserPW_lb.Text = "PW";
            this.UserPW_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserID_lb
            // 
            this.UserID_lb.BackColor = System.Drawing.Color.LightCyan;
            this.UserID_lb.Location = new System.Drawing.Point(405, 33);
            this.UserID_lb.Name = "UserID_lb";
            this.UserID_lb.Size = new System.Drawing.Size(40, 30);
            this.UserID_lb.TabIndex = 11;
            this.UserID_lb.Text = "ID";
            this.UserID_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserName_lb
            // 
            this.UserName_lb.BackColor = System.Drawing.Color.LightCyan;
            this.UserName_lb.Location = new System.Drawing.Point(122, 36);
            this.UserName_lb.Name = "UserName_lb";
            this.UserName_lb.Size = new System.Drawing.Size(40, 30);
            this.UserName_lb.TabIndex = 10;
            this.UserName_lb.Text = "이름";
            this.UserName_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserRegistration_lb
            // 
            this.UserRegistration_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserRegistration_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserRegistration_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegistration_lb.Location = new System.Drawing.Point(3, 0);
            this.UserRegistration_lb.Name = "UserRegistration_lb";
            this.UserRegistration_lb.Size = new System.Drawing.Size(1240, 29);
            this.UserRegistration_lb.TabIndex = 16;
            this.UserRegistration_lb.Text = "사용자 등록";
            this.UserRegistration_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegiUserList_lb
            // 
            this.RegiUserList_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegiUserList_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegiUserList_lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegiUserList_lb.Location = new System.Drawing.Point(3, 212);
            this.RegiUserList_lb.Name = "RegiUserList_lb";
            this.RegiUserList_lb.Size = new System.Drawing.Size(1240, 26);
            this.RegiUserList_lb.TabIndex = 15;
            this.RegiUserList_lb.Text = "사용자 목록";
            this.RegiUserList_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegiUserList_dgv
            // 
            this.RegiUserList_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegiUserList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegiUserList_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.userID,
            this.userPW,
            this.userdepartment,
            this.userrank});
            this.RegiUserList_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegiUserList_dgv.Location = new System.Drawing.Point(3, 241);
            this.RegiUserList_dgv.Name = "RegiUserList_dgv";
            this.RegiUserList_dgv.RowHeadersWidth = 51;
            this.RegiUserList_dgv.RowTemplate.Height = 27;
            this.RegiUserList_dgv.Size = new System.Drawing.Size(1240, 468);
            this.RegiUserList_dgv.TabIndex = 14;
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
            // formSystem4Okay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 711);
            this.Controls.Add(this.System4Ok_tlpn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSystem4Okay";
            this.Text = "formSystem4Okay";
            this.Load += new System.EventHandler(this.formSystem4Okay_Load);
            this.System4Ok_tlpn.ResumeLayout(false);
            this.UserRegistration_pn.ResumeLayout(false);
            this.UserRegistration_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegiUserList_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel System4Ok_tlpn;
        private System.Windows.Forms.Panel UserRegistration_pn;
        private System.Windows.Forms.Label IDCheck_lb;
        private System.Windows.Forms.Button UserRegistration_bt;
        private System.Windows.Forms.TextBox UserRank_tb;
        private System.Windows.Forms.TextBox UserDepartment_tb;
        private System.Windows.Forms.Label UserRank_lb;
        private System.Windows.Forms.Label UserDepartment_lb;
        private System.Windows.Forms.TextBox UserPW_tb;
        private System.Windows.Forms.TextBox UserID_tb;
        private System.Windows.Forms.TextBox UserName_tb;
        private System.Windows.Forms.Label UserPW_lb;
        private System.Windows.Forms.Label UserID_lb;
        private System.Windows.Forms.Label UserName_lb;
        private System.Windows.Forms.Label UserRegistration_lb;
        private System.Windows.Forms.Label RegiUserList_lb;
        private System.Windows.Forms.DataGridView RegiUserList_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrank;
    }
}