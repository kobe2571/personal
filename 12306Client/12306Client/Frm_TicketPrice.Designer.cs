namespace _12306Client
{
    partial class Frm_TicketPrice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_startTime = new System.Windows.Forms.DateTimePicker();
            this.txt_endStation = new System.Windows.Forms.TextBox();
            this.txt_startStation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_randCode = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.pbx_randCode = new System.Windows.Forms.PictureBox();
            this.dgv_ticketPrice = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_randCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticketPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ticketPrice);
            this.groupBox1.Controls.Add(this.pbx_randCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_randCode);
            this.groupBox1.Controls.Add(this.txt_startStation);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_startTime);
            this.groupBox1.Controls.Add(this.txt_endStation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 票 价 查 询 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(450, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 12;
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
            this.dtp_startTime.Location = new System.Drawing.Point(523, 32);
            this.dtp_startTime.Name = "dtp_startTime";
            this.dtp_startTime.Size = new System.Drawing.Size(116, 21);
            this.dtp_startTime.TabIndex = 10;
            this.dtp_startTime.Value = new System.DateTime(2015, 11, 16, 0, 0, 0, 0);
            // 
            // txt_endStation
            // 
            this.txt_endStation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_endStation.Location = new System.Drawing.Point(308, 35);
            this.txt_endStation.Name = "txt_endStation";
            this.txt_endStation.Size = new System.Drawing.Size(118, 23);
            this.txt_endStation.TabIndex = 9;
            // 
            // txt_startStation
            // 
            this.txt_startStation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_startStation.Location = new System.Drawing.Point(92, 35);
            this.txt_startStation.Name = "txt_startStation";
            this.txt_startStation.Size = new System.Drawing.Size(114, 23);
            this.txt_startStation.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(235, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "目的地：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "出发地：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(663, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "验证码：";
            // 
            // txt_randCode
            // 
            this.txt_randCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_randCode.Location = new System.Drawing.Point(736, 33);
            this.txt_randCode.Name = "txt_randCode";
            this.txt_randCode.Size = new System.Drawing.Size(70, 23);
            this.txt_randCode.TabIndex = 15;
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(941, 32);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(95, 25);
            this.btn_query.TabIndex = 13;
            this.btn_query.Text = "票价查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // pbx_randCode
            // 
            this.pbx_randCode.Location = new System.Drawing.Point(836, 24);
            this.pbx_randCode.Name = "pbx_randCode";
            this.pbx_randCode.Size = new System.Drawing.Size(72, 36);
            this.pbx_randCode.TabIndex = 16;
            this.pbx_randCode.TabStop = false;
            this.pbx_randCode.Click += new System.EventHandler(this.pbx_randCode_Click);
            // 
            // dgv_ticketPrice
            // 
            this.dgv_ticketPrice.AllowUserToAddRows = false;
            this.dgv_ticketPrice.AllowUserToDeleteRows = false;
            this.dgv_ticketPrice.AllowUserToResizeColumns = false;
            this.dgv_ticketPrice.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ticketPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ticketPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ticketPrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ticketPrice.Location = new System.Drawing.Point(22, 84);
            this.dgv_ticketPrice.Name = "dgv_ticketPrice";
            this.dgv_ticketPrice.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ticketPrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ticketPrice.RowHeadersVisible = false;
            this.dgv_ticketPrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ticketPrice.RowTemplate.Height = 23;
            this.dgv_ticketPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ticketPrice.Size = new System.Drawing.Size(1014, 480);
            this.dgv_ticketPrice.TabIndex = 17;
            // 
            // Frm_TicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 612);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_TicketPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "票价查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_randCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticketPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_startStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_startTime;
        private System.Windows.Forms.TextBox txt_endStation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_randCode;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.PictureBox pbx_randCode;
        private System.Windows.Forms.DataGridView dgv_ticketPrice;
    }
}