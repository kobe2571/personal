namespace _12306Client
{
    partial class Frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_login = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_leftticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ticketprice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_salesite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_time = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_login,
            this.toolStripMenuItem1,
            this.tsm_leftticket,
            this.toolStripMenuItem2,
            this.tsm_ticketprice,
            this.toolStripMenuItem3,
            this.tsm_salesite,
            this.toolStripMenuItem4,
            this.tsm_time});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_login
            // 
            this.tsm_login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsm_login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsm_login.Name = "tsm_login";
            this.tsm_login.Size = new System.Drawing.Size(92, 24);
            this.tsm_login.Text = "登 录 （&L）";
            this.tsm_login.Click += new System.EventHandler(this.tsm_login_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // tsm_leftticket
            // 
            this.tsm_leftticket.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsm_leftticket.Name = "tsm_leftticket";
            this.tsm_leftticket.Size = new System.Drawing.Size(117, 24);
            this.tsm_leftticket.Text = "余票查询 （&Y）";
            this.tsm_leftticket.Click += new System.EventHandler(this.tsm_leftticket_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem2.Text = "|";
            // 
            // tsm_ticketprice
            // 
            this.tsm_ticketprice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsm_ticketprice.Name = "tsm_ticketprice";
            this.tsm_ticketprice.Size = new System.Drawing.Size(118, 24);
            this.tsm_ticketprice.Text = "票价查询 （&P）";
            this.tsm_ticketprice.Click += new System.EventHandler(this.tsm_ticketprice_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem3.Text = "|";
            // 
            // tsm_salesite
            // 
            this.tsm_salesite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsm_salesite.Name = "tsm_salesite";
            this.tsm_salesite.Size = new System.Drawing.Size(134, 24);
            this.tsm_salesite.Text = "代售点查询 （&D）";
            this.tsm_salesite.Click += new System.EventHandler(this.tsm_salesite_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(23, 24);
            this.toolStripMenuItem4.Text = "|";
            // 
            // tsm_time
            // 
            this.tsm_time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsm_time.Name = "tsm_time";
            this.tsm_time.Size = new System.Drawing.Size(132, 24);
            this.tsm_time.Text = "正晚点查询 （&Z）";
            this.tsm_time.Click += new System.EventHandler(this.tsm_time_Click);
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_userName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_userName.ForeColor = System.Drawing.Color.Red;
            this.lbl_userName.Location = new System.Drawing.Point(878, 7);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(59, 16);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "铁道部";
            this.lbl_userName.Visible = false;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_welcome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Black;
            this.lbl_welcome.Location = new System.Drawing.Point(943, 7);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(76, 16);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "欢迎你！";
            this.lbl_welcome.Visible = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12306客户端";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_login;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsm_leftticket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsm_ticketprice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsm_salesite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsm_time;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_welcome;
    }
}