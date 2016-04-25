namespace _12306Client
{
    partial class Frm_SaleSite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_province = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_county = new System.Windows.Forms.ComboBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.dgv_salesiteList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salesiteList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_salesiteList);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_county);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_city);
            this.groupBox1.Controls.Add(this.cmb_province);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 车票代售点查询 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "所在地区：";
            // 
            // cmb_province
            // 
            this.cmb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_province.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_province.FormattingEnabled = true;
            this.cmb_province.Items.AddRange(new object[] {
            "请选择省"});
            this.cmb_province.Location = new System.Drawing.Point(114, 44);
            this.cmb_province.Name = "cmb_province";
            this.cmb_province.Size = new System.Drawing.Size(158, 24);
            this.cmb_province.TabIndex = 1;
            this.cmb_province.SelectedIndexChanged += new System.EventHandler(this.cmb_province_SelectedIndexChanged);
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Items.AddRange(new object[] {
            "请选择市"});
            this.cmb_city.Location = new System.Drawing.Point(324, 44);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(158, 24);
            this.cmb_city.TabIndex = 2;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = " -- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = " -- ";
            // 
            // cmb_county
            // 
            this.cmb_county.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_county.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_county.FormattingEnabled = true;
            this.cmb_county.Items.AddRange(new object[] {
            "请选择区/县"});
            this.cmb_county.Location = new System.Drawing.Point(533, 44);
            this.cmb_county.Name = "cmb_county";
            this.cmb_county.Size = new System.Drawing.Size(158, 24);
            this.cmb_county.TabIndex = 4;
            // 
            // btn_query
            // 
            this.btn_query.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_query.Location = new System.Drawing.Point(735, 43);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(90, 24);
            this.btn_query.TabIndex = 6;
            this.btn_query.Text = "查 询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // dgv_salesiteList
            // 
            this.dgv_salesiteList.AllowUserToAddRows = false;
            this.dgv_salesiteList.AllowUserToDeleteRows = false;
            this.dgv_salesiteList.AllowUserToResizeColumns = false;
            this.dgv_salesiteList.AllowUserToResizeRows = false;
            this.dgv_salesiteList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_salesiteList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_salesiteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_salesiteList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_salesiteList.Location = new System.Drawing.Point(34, 103);
            this.dgv_salesiteList.Name = "dgv_salesiteList";
            this.dgv_salesiteList.ReadOnly = true;
            this.dgv_salesiteList.RowHeadersVisible = false;
            this.dgv_salesiteList.RowTemplate.Height = 23;
            this.dgv_salesiteList.Size = new System.Drawing.Size(791, 283);
            this.dgv_salesiteList.TabIndex = 7;
            // 
            // Frm_SaleSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 444);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_SaleSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代售点查询";
            this.Load += new System.EventHandler(this.Frm_SaleSite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salesiteList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_county;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dgv_salesiteList;
    }
}