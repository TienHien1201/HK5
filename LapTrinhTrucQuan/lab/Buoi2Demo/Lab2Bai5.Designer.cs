namespace Buoi2Demo
{
    partial class Lab2Bai5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2Bai5));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_tendangnhap = new TextBox();
            txt_matkhau = new TextBox();
            chk_hienthi = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(459, 47);
            label1.Name = "label1";
            label1.Size = new Size(295, 39);
            label1.TabIndex = 0;
            label1.Text = "Cửa sổ đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 132);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 180);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Location = new Point(542, 129);
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(232, 27);
            txt_tendangnhap.TabIndex = 3;
            txt_tendangnhap.TextChanged += textBox1_TextChanged;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(542, 173);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(232, 27);
            txt_matkhau.TabIndex = 4;
            txt_matkhau.TextChanged += txt_matkhau_TextChanged;
            txt_matkhau.KeyPress += txt_matkhau_KeyPress;
            // 
            // chk_hienthi
            // 
            chk_hienthi.AutoSize = true;
            chk_hienthi.Location = new Point(489, 245);
            chk_hienthi.Name = "chk_hienthi";
            chk_hienthi.Size = new Size(148, 24);
            chk_hienthi.TabIndex = 5;
            chk_hienthi.Text = "Hiển thị mật khẩu";
            chk_hienthi.UseVisualStyleBackColor = true;
            chk_hienthi.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(409, 317);
            button1.Name = "button1";
            button1.Size = new Size(105, 41);
            button1.TabIndex = 6;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(643, 317);
            button2.Name = "button2";
            button2.Size = new Size(111, 41);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 407);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 8;
            label4.Text = "Nhấn F1 để được hướng dẫn";
            label4.Click += label4_Click;
            label4.PreviewKeyDown += label4_PreviewKeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 426);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://plpsoft.vn/30236-Bai-tap-C-Bai-5-Su-dung-ToolTip-HelpProvider-ErrorProvider-trong-C-windows-Form";
            // 
            // Lab2Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chk_hienthi);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_tendangnhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab2Bai5";
            helpProvider1.SetShowHelp(this, true);
            Text = "Bài 5";
            Load += Lab2Bai5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_tendangnhap;
        private TextBox txt_matkhau;
        private CheckBox chk_hienthi;
        private Button button1;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private HelpProvider helpProvider1;
    }
}