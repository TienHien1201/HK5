namespace DoAnMau.ChuShop
{
    partial class frmThongKeDoanhThu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtToanBo = new System.Windows.Forms.RadioButton();
            this.lbTong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdbtThoiGian = new System.Windows.Forms.RadioButton();
            this.rdbtThangHienTai = new System.Windows.Forms.RadioButton();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.gbKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.rdbtToanBo);
            this.panel3.Controls.Add(this.lbTong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpDenNgay);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpTuNgay);
            this.panel3.Controls.Add(this.rdbtThoiGian);
            this.panel3.Controls.Add(this.rdbtThangHienTai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 76);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 72);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // rdbtToanBo
            // 
            this.rdbtToanBo.AutoSize = true;
            this.rdbtToanBo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtToanBo.ForeColor = System.Drawing.Color.Yellow;
            this.rdbtToanBo.Location = new System.Drawing.Point(406, 13);
            this.rdbtToanBo.Name = "rdbtToanBo";
            this.rdbtToanBo.Size = new System.Drawing.Size(111, 28);
            this.rdbtToanBo.TabIndex = 9;
            this.rdbtToanBo.Text = "Toàn bộ";
            this.rdbtToanBo.UseVisualStyleBackColor = true;
            this.rdbtToanBo.CheckedChanged += new System.EventHandler(this.rdbtToanBo_CheckedChanged);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.ForeColor = System.Drawing.Color.Yellow;
            this.lbTong.Location = new System.Drawing.Point(402, 39);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(28, 29);
            this.lbTong.TabIndex = 8;
            this.lbTong.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(635, 36);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(122, 32);
            this.dtpDenNgay.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dtpDenNgay, "Chọn mốc cuối thời gian");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(592, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(635, 9);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(122, 32);
            this.dtpTuNgay.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dtpTuNgay, "Chọn mốc đầu thời gian");
            // 
            // rdbtThoiGian
            // 
            this.rdbtThoiGian.AutoSize = true;
            this.rdbtThoiGian.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtThoiGian.ForeColor = System.Drawing.Color.White;
            this.rdbtThoiGian.Location = new System.Drawing.Point(505, 13);
            this.rdbtThoiGian.Name = "rdbtThoiGian";
            this.rdbtThoiGian.Size = new System.Drawing.Size(152, 28);
            this.rdbtThoiGian.TabIndex = 3;
            this.rdbtThoiGian.Text = "Thời gian từ";
            this.rdbtThoiGian.UseVisualStyleBackColor = true;
            this.rdbtThoiGian.CheckedChanged += new System.EventHandler(this.rdbtThoiGian_CheckedChanged);
            // 
            // rdbtThangHienTai
            // 
            this.rdbtThangHienTai.AutoSize = true;
            this.rdbtThangHienTai.Checked = true;
            this.rdbtThangHienTai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtThangHienTai.ForeColor = System.Drawing.Color.White;
            this.rdbtThangHienTai.Location = new System.Drawing.Point(255, 12);
            this.rdbtThangHienTai.Name = "rdbtThangHienTai";
            this.rdbtThangHienTai.Size = new System.Drawing.Size(176, 28);
            this.rdbtThangHienTai.TabIndex = 2;
            this.rdbtThangHienTai.TabStop = true;
            this.rdbtThangHienTai.Text = "Tháng hiện tại";
            this.rdbtThangHienTai.UseVisualStyleBackColor = true;
            this.rdbtThangHienTai.CheckedChanged += new System.EventHandler(this.rdbtThangHienTai_CheckedChanged);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKetQua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(3, 28);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvKetQua.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.Size = new System.Drawing.Size(765, 354);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // gbKetQua
            // 
            this.gbKetQua.BackColor = System.Drawing.Color.Teal;
            this.gbKetQua.Controls.Add(this.dgvKetQua);
            this.gbKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKetQua.ForeColor = System.Drawing.Color.White;
            this.gbKetQua.Location = new System.Drawing.Point(0, 76);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Size = new System.Drawing.Size(771, 385);
            this.gbKetQua.TabIndex = 3;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "Dữ liệu bán hàng thống kê được";
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 461);
            this.Controls.Add(this.gbKetQua);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKeDoanhThu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.gbKetQua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.RadioButton rdbtThoiGian;
        private System.Windows.Forms.RadioButton rdbtThangHienTai;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.RadioButton rdbtToanBo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}