namespace Buoi2Demo
{
    partial class Lab2Cau3
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
            groupBox1 = new GroupBox();
            chexbox_dulich = new CheckBox();
            chkbox_muasam = new CheckBox();
            chkbox_thethao = new CheckBox();
            chkbox_xemphim = new CheckBox();
            chkbox_nghenhac = new CheckBox();
            groupBox2 = new GroupBox();
            rdbtn_tim = new RadioButton();
            rdbtn_hong = new RadioButton();
            rdbtn_vang = new RadioButton();
            rdbtn_trang = new RadioButton();
            rdbtn_do = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chexbox_dulich);
            groupBox1.Controls.Add(chkbox_muasam);
            groupBox1.Controls.Add(chkbox_thethao);
            groupBox1.Controls.Add(chkbox_xemphim);
            groupBox1.Controls.Add(chkbox_nghenhac);
            groupBox1.Location = new Point(23, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sở thích của bạn";
            // 
            // chexbox_dulich
            // 
            chexbox_dulich.AutoSize = true;
            chexbox_dulich.Location = new Point(6, 175);
            chexbox_dulich.Name = "chexbox_dulich";
            chexbox_dulich.Size = new Size(94, 24);
            chexbox_dulich.TabIndex = 4;
            chexbox_dulich.Text = "Đi du lịch";
            chexbox_dulich.UseVisualStyleBackColor = true;
            // 
            // chkbox_muasam
            // 
            chkbox_muasam.AutoSize = true;
            chkbox_muasam.Location = new Point(6, 140);
            chkbox_muasam.Name = "chkbox_muasam";
            chkbox_muasam.Size = new Size(110, 24);
            chkbox_muasam.TabIndex = 3;
            chkbox_muasam.Text = "Đi mua sắm";
            chkbox_muasam.UseVisualStyleBackColor = true;
            chkbox_muasam.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkbox_thethao
            // 
            chkbox_thethao.AutoSize = true;
            chkbox_thethao.Location = new Point(6, 105);
            chkbox_thethao.Name = "chkbox_thethao";
            chkbox_thethao.Size = new Size(120, 24);
            chkbox_thethao.TabIndex = 2;
            chkbox_thethao.Text = "Chơi thể thao";
            chkbox_thethao.UseVisualStyleBackColor = true;
            chkbox_thethao.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // chkbox_xemphim
            // 
            chkbox_xemphim.AutoSize = true;
            chkbox_xemphim.Location = new Point(6, 70);
            chkbox_xemphim.Name = "chkbox_xemphim";
            chkbox_xemphim.Size = new Size(99, 24);
            chkbox_xemphim.TabIndex = 1;
            chkbox_xemphim.Text = "Xem phim";
            chkbox_xemphim.UseVisualStyleBackColor = true;
            // 
            // chkbox_nghenhac
            // 
            chkbox_nghenhac.AutoSize = true;
            chkbox_nghenhac.Location = new Point(6, 35);
            chkbox_nghenhac.Name = "chkbox_nghenhac";
            chkbox_nghenhac.Size = new Size(102, 24);
            chkbox_nghenhac.TabIndex = 0;
            chkbox_nghenhac.Text = "Nghe nhạc";
            chkbox_nghenhac.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbtn_tim);
            groupBox2.Controls.Add(rdbtn_hong);
            groupBox2.Controls.Add(rdbtn_vang);
            groupBox2.Controls.Add(rdbtn_trang);
            groupBox2.Controls.Add(rdbtn_do);
            groupBox2.Location = new Point(442, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 257);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Màu bạn thích";
            // 
            // rdbtn_tim
            // 
            rdbtn_tim.AutoSize = true;
            rdbtn_tim.Location = new Point(6, 172);
            rdbtn_tim.Name = "rdbtn_tim";
            rdbtn_tim.Size = new Size(55, 24);
            rdbtn_tim.TabIndex = 4;
            rdbtn_tim.TabStop = true;
            rdbtn_tim.Text = "Tím";
            rdbtn_tim.UseVisualStyleBackColor = true;
            rdbtn_tim.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // rdbtn_hong
            // 
            rdbtn_hong.AutoSize = true;
            rdbtn_hong.Location = new Point(6, 138);
            rdbtn_hong.Name = "rdbtn_hong";
            rdbtn_hong.Size = new Size(67, 24);
            rdbtn_hong.TabIndex = 3;
            rdbtn_hong.TabStop = true;
            rdbtn_hong.Text = "Hồng";
            rdbtn_hong.UseVisualStyleBackColor = true;
            rdbtn_hong.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rdbtn_vang
            // 
            rdbtn_vang.AutoSize = true;
            rdbtn_vang.Location = new Point(6, 104);
            rdbtn_vang.Name = "rdbtn_vang";
            rdbtn_vang.Size = new Size(63, 24);
            rdbtn_vang.TabIndex = 2;
            rdbtn_vang.TabStop = true;
            rdbtn_vang.Text = "Vàng";
            rdbtn_vang.UseVisualStyleBackColor = true;
            rdbtn_vang.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rdbtn_trang
            // 
            rdbtn_trang.AutoSize = true;
            rdbtn_trang.Location = new Point(6, 67);
            rdbtn_trang.Name = "rdbtn_trang";
            rdbtn_trang.Size = new Size(67, 24);
            rdbtn_trang.TabIndex = 1;
            rdbtn_trang.TabStop = true;
            rdbtn_trang.Text = "Trắng";
            rdbtn_trang.UseVisualStyleBackColor = true;
            // 
            // rdbtn_do
            // 
            rdbtn_do.AutoSize = true;
            rdbtn_do.Location = new Point(6, 36);
            rdbtn_do.Name = "rdbtn_do";
            rdbtn_do.Size = new Size(50, 24);
            rdbtn_do.TabIndex = 0;
            rdbtn_do.TabStop = true;
            rdbtn_do.Text = "Đỏ";
            rdbtn_do.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(91, 349);
            button1.Name = "button1";
            button1.Size = new Size(253, 47);
            button1.TabIndex = 2;
            button1.Text = "Sở thích của bạn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(439, 349);
            button2.Name = "button2";
            button2.Size = new Size(253, 47);
            button2.TabIndex = 3;
            button2.Text = "Sở thích của bạn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lab2Cau3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Câu 3";
            Text = "Câu 3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkbox_muasam;
        private CheckBox chkbox_thethao;
        private CheckBox chkbox_xemphim;
        private CheckBox chkbox_nghenhac;
        private GroupBox groupBox2;
        private CheckBox chexbox_dulich;
        private RadioButton rdbtn_tim;
        private RadioButton rdbtn_hong;
        private RadioButton rdbtn_vang;
        private RadioButton rdbtn_trang;
        private RadioButton rdbtn_do;
        private Button button1;
        private Button button2;
    }
}