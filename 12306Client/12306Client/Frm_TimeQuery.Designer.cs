namespace _12306Client
{
    partial class Frm_TimeQuery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_endstation = new System.Windows.Forms.RadioButton();
            this.rdb_startstation = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_station = new System.Windows.Forms.TextBox();
            this.txt_traincode = new System.Windows.Forms.TextBox();
            this.txt_checkcode = new System.Windows.Forms.TextBox();
            this.pb_checkcode = new System.Windows.Forms.PictureBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkcode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.pb_checkcode);
            this.groupBox1.Controls.Add(this.txt_checkcode);
            this.groupBox1.Controls.Add(this.txt_traincode);
            this.groupBox1.Controls.Add(this.txt_station);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdb_startstation);
            this.groupBox1.Controls.Add(this.rdb_endstation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 正晚点查询 ";
            // 
            // rdb_endstation
            // 
            this.rdb_endstation.AutoSize = true;
            this.rdb_endstation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_endstation.Location = new System.Drawing.Point(135, 39);
            this.rdb_endstation.Name = "rdb_endstation";
            this.rdb_endstation.Size = new System.Drawing.Size(67, 18);
            this.rdb_endstation.TabIndex = 0;
            this.rdb_endstation.TabStop = true;
            this.rdb_endstation.Text = "到达站";
            this.rdb_endstation.UseVisualStyleBackColor = true;
            // 
            // rdb_startstation
            // 
            this.rdb_startstation.AutoSize = true;
            this.rdb_startstation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_startstation.Location = new System.Drawing.Point(237, 39);
            this.rdb_startstation.Name = "rdb_startstation";
            this.rdb_startstation.Size = new System.Drawing.Size(67, 18);
            this.rdb_startstation.TabIndex = 1;
            this.rdb_startstation.TabStop = true;
            this.rdb_startstation.Text = "出发站";
            this.rdb_startstation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(64, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "车 站：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "车 次：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(57, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "验证码：";
            // 
            // txt_station
            // 
            this.txt_station.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_station.Location = new System.Drawing.Point(135, 82);
            this.txt_station.Name = "txt_station";
            this.txt_station.Size = new System.Drawing.Size(169, 23);
            this.txt_station.TabIndex = 6;
            // 
            // txt_traincode
            // 
            this.txt_traincode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_traincode.Location = new System.Drawing.Point(135, 126);
            this.txt_traincode.Name = "txt_traincode";
            this.txt_traincode.Size = new System.Drawing.Size(169, 23);
            this.txt_traincode.TabIndex = 7;
            // 
            // txt_checkcode
            // 
            this.txt_checkcode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_checkcode.Location = new System.Drawing.Point(135, 168);
            this.txt_checkcode.Name = "txt_checkcode";
            this.txt_checkcode.Size = new System.Drawing.Size(76, 23);
            this.txt_checkcode.TabIndex = 8;
            // 
            // pb_checkcode
            // 
            this.pb_checkcode.Location = new System.Drawing.Point(226, 165);
            this.pb_checkcode.Name = "pb_checkcode";
            this.pb_checkcode.Size = new System.Drawing.Size(78, 26);
            this.pb_checkcode.TabIndex = 9;
            this.pb_checkcode.TabStop = false;
            this.pb_checkcode.Click += new System.EventHandler(this.pb_checkcode_Click);
            // 
            // btn_query
            // 
            this.btn_query.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_query.Location = new System.Drawing.Point(72, 217);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 10;
            this.btn_query.Text = "查 询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(203, 217);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "取 消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Frm_TimeQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_TimeQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "列车正晚点查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_endstation;
        private System.Windows.Forms.RadioButton rdb_startstation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_station;
        private System.Windows.Forms.TextBox txt_traincode;
        private System.Windows.Forms.TextBox txt_checkcode;
        private System.Windows.Forms.PictureBox pb_checkcode;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Button btn_cancel;
    }
}