namespace _12306Client
{
    partial class Frm_LeftTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ticketShow = new System.Windows.Forms.DataGridView();
            this.cmb_ticketType = new System.Windows.Forms.ComboBox();
            this.btn_queryTickets = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_startTime = new System.Windows.Forms.DateTimePicker();
            this.txt_endStation = new System.Windows.Forms.TextBox();
            this.txt_startStation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticketShow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ticketShow);
            this.groupBox1.Controls.Add(this.cmb_ticketType);
            this.groupBox1.Controls.Add(this.btn_queryTickets);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_startTime);
            this.groupBox1.Controls.Add(this.txt_endStation);
            this.groupBox1.Controls.Add(this.txt_startStation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 606);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  余 票 查 询  ";
            // 
            // dgv_ticketShow
            // 
            this.dgv_ticketShow.AllowUserToAddRows = false;
            this.dgv_ticketShow.AllowUserToDeleteRows = false;
            this.dgv_ticketShow.AllowUserToResizeColumns = false;
            this.dgv_ticketShow.AllowUserToResizeRows = false;
            this.dgv_ticketShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ticketShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ticketShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ticketShow.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ticketShow.Location = new System.Drawing.Point(20, 75);
            this.dgv_ticketShow.MultiSelect = false;
            this.dgv_ticketShow.Name = "dgv_ticketShow";
            this.dgv_ticketShow.ReadOnly = true;
            this.dgv_ticketShow.RowHeadersVisible = false;
            this.dgv_ticketShow.RowTemplate.Height = 23;
            this.dgv_ticketShow.Size = new System.Drawing.Size(1012, 512);
            this.dgv_ticketShow.TabIndex = 10;
            // 
            // cmb_ticketType
            // 
            this.cmb_ticketType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ticketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ticketType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_ticketType.FormattingEnabled = true;
            this.cmb_ticketType.Items.AddRange(new object[] {
            "成人票",
            "学生票"});
            this.cmb_ticketType.Location = new System.Drawing.Point(771, 31);
            this.cmb_ticketType.Name = "cmb_ticketType";
            this.cmb_ticketType.Size = new System.Drawing.Size(100, 22);
            this.cmb_ticketType.TabIndex = 4;
            // 
            // btn_queryTickets
            // 
            this.btn_queryTickets.Location = new System.Drawing.Point(915, 30);
            this.btn_queryTickets.Name = "btn_queryTickets";
            this.btn_queryTickets.Size = new System.Drawing.Size(95, 25);
            this.btn_queryTickets.TabIndex = 5;
            this.btn_queryTickets.Text = "余票查询";
            this.btn_queryTickets.UseVisualStyleBackColor = true;
            this.btn_queryTickets.Click += new System.EventHandler(this.btn_queryTickets_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(516, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "出发日：";
            // 
            // dtp_startTime
            // 
            this.dtp_startTime.CalendarFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_startTime.Checked = false;
            this.dtp_startTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_startTime.CustomFormat = "";
            this.dtp_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_startTime.Location = new System.Drawing.Point(589, 30);
            this.dtp_startTime.Name = "dtp_startTime";
            this.dtp_startTime.Size = new System.Drawing.Size(142, 21);
            this.dtp_startTime.TabIndex = 3;
            this.dtp_startTime.Value = new System.DateTime(2015, 11, 16, 0, 0, 0, 0);
            // 
            // txt_endStation
            // 
            this.txt_endStation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_endStation.Location = new System.Drawing.Point(347, 31);
            this.txt_endStation.Name = "txt_endStation";
            this.txt_endStation.Size = new System.Drawing.Size(137, 23);
            this.txt_endStation.TabIndex = 2;
            // 
            // txt_startStation
            // 
            this.txt_startStation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_startStation.Location = new System.Drawing.Point(106, 31);
            this.txt_startStation.Name = "txt_startStation";
            this.txt_startStation.Size = new System.Drawing.Size(137, 23);
            this.txt_startStation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(274, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的地：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "出发地：";
            // 
            // Frm_LeftTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 632);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_LeftTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "余票查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticketShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_endStation;
        private System.Windows.Forms.TextBox txt_startStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_startTime;
        private System.Windows.Forms.Button btn_queryTickets;
        private System.Windows.Forms.ComboBox cmb_ticketType;
        private System.Windows.Forms.DataGridView dgv_ticketShow;
    }
}