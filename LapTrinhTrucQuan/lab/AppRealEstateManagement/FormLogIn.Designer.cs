namespace AppRealEstateManagement
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            cbMatKhau = new CheckBox();
            pictureBox2 = new PictureBox();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btDangKy = new Button();
            btDangNhap = new Button();
            lbMatKhau = new Label();
            lbtaiKhoan = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 2560);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(cbMatKhau);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(btDangKy);
            panel1.Controls.Add(btDangNhap);
            panel1.Controls.Add(lbMatKhau);
            panel1.Controls.Add(lbtaiKhoan);
            panel1.Location = new Point(84, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 343);
            panel1.TabIndex = 1;
            // 
            // cbMatKhau
            // 
            cbMatKhau.AutoSize = true;
            cbMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbMatKhau.ForeColor = Color.FromArgb(0, 64, 0);
            cbMatKhau.Location = new Point(276, 140);
            cbMatKhau.Name = "cbMatKhau";
            cbMatKhau.Size = new Size(143, 24);
            cbMatKhau.TabIndex = 7;
            cbMatKhau.Text = "Show PassWord";
            cbMatKhau.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 128);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.FromArgb(192, 255, 255);
            txtTaiKhoan.Location = new Point(276, 31);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(380, 27);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(192, 255, 255);
            txtMatKhau.Location = new Point(276, 83);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(380, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // btDangKy
            // 
            btDangKy.BackColor = Color.FromArgb(0, 64, 0);
            btDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btDangKy.ForeColor = Color.White;
            btDangKy.Location = new Point(392, 170);
            btDangKy.Name = "btDangKy";
            btDangKy.Size = new Size(94, 29);
            btDangKy.TabIndex = 3;
            btDangKy.Text = "Sign In";
            btDangKy.UseVisualStyleBackColor = false;
            // 
            // btDangNhap
            // 
            btDangNhap.BackColor = Color.FromArgb(0, 64, 0);
            btDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btDangNhap.ForeColor = Color.White;
            btDangNhap.Location = new Point(282, 170);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(94, 29);
            btDangNhap.TabIndex = 2;
            btDangNhap.Text = "Log In";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatKhau.ForeColor = Color.FromArgb(0, 192, 0);
            lbMatKhau.Location = new Point(167, 87);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(88, 23);
            lbMatKhau.TabIndex = 1;
            lbMatKhau.Text = "PassWord";
            lbMatKhau.Click += label2_Click;
            // 
            // lbtaiKhoan
            // 
            lbtaiKhoan.AutoSize = true;
            lbtaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbtaiKhoan.ForeColor = Color.FromArgb(0, 192, 0);
            lbtaiKhoan.Location = new Point(180, 32);
            lbtaiKhoan.Name = "lbtaiKhoan";
            lbtaiKhoan.Size = new Size(75, 23);
            lbtaiKhoan.TabIndex = 0;
            lbtaiKhoan.Text = "Account";
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 554);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOG IN";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btDangKy;
        private Button btDangNhap;
        private Label lbMatKhau;
        private Label lbtaiKhoan;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private PictureBox pictureBox2;
        private CheckBox cbMatKhau;
    }
}