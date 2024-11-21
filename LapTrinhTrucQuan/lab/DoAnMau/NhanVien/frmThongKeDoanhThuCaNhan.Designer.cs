namespace DoAnMau.NhanVien
{
    partial class frmThongKeDoanhThuCaNhan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtToanBo = new System.Windows.Forms.RadioButton();
            this.lbTong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtThangHienTai = new System.Windows.Forms.RadioButton();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
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
            this.panel3.Controls.Add(this.rdbtThangHienTai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 49);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 45);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH SỐ BÁN HÀNG";
            // 
            // rdbtToanBo
            // 
            this.rdbtToanBo.AutoSize = true;
            this.rdbtToanBo.BackColor = System.Drawing.Color.Teal;
            this.rdbtToanBo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtToanBo.ForeColor = System.Drawing.Color.Yellow;
            this.rdbtToanBo.Location = new System.Drawing.Point(401, 11);
            this.rdbtToanBo.Name = "rdbtToanBo";
            this.rdbtToanBo.Size = new System.Drawing.Size(93, 23);
            this.rdbtToanBo.TabIndex = 9;
            this.rdbtToanBo.Text = "Toàn bộ";
            this.rdbtToanBo.UseVisualStyleBackColor = false;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbTong.ForeColor = System.Drawing.Color.Yellow;
            this.lbTong.Location = new System.Drawing.Point(622, 9);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(24, 27);
            this.lbTong.TabIndex = 8;
            this.lbTong.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(494, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng doanh số:";
            // 
            // rdbtThangHienTai
            // 
            this.rdbtThangHienTai.AutoSize = true;
            this.rdbtThangHienTai.BackColor = System.Drawing.Color.Teal;
            this.rdbtThangHienTai.Checked = true;
            this.rdbtThangHienTai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtThangHienTai.ForeColor = System.Drawing.Color.White;
            this.rdbtThangHienTai.Location = new System.Drawing.Point(257, 11);
            this.rdbtThangHienTai.Name = "rdbtThangHienTai";
            this.rdbtThangHienTai.Size = new System.Drawing.Size(145, 23);
            this.rdbtThangHienTai.TabIndex = 3;
            this.rdbtThangHienTai.TabStop = true;
            this.rdbtThangHienTai.Text = "Tháng hiện tại";
            this.rdbtThangHienTai.UseVisualStyleBackColor = false;
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
            this.dgvKetQua.Location = new System.Drawing.Point(3, 23);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(773, 386);
            this.dgvKetQua.TabIndex = 0;
            // 
            // gbKetQua
            // 
            this.gbKetQua.BackColor = System.Drawing.Color.Teal;
            this.gbKetQua.Controls.Add(this.dgvKetQua);
            this.gbKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKetQua.ForeColor = System.Drawing.Color.White;
            this.gbKetQua.Location = new System.Drawing.Point(0, 49);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Size = new System.Drawing.Size(779, 412);
            this.gbKetQua.TabIndex = 3;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "Dữ liệu bán hàng thống kê được";
            // 
            // frmThongKeDoanhThuCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 461);
            this.Controls.Add(this.gbKetQua);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKeDoanhThuCaNhan";
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
        private System.Windows.Forms.RadioButton rdbtThangHienTai;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.RadioButton rdbtToanBo;
        private System.Windows.Forms.Panel panel1;
    }
}