namespace Buoi2Demo
{
    partial class Lab2Bai4From1
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
            label1 = new Label();
            label2 = new Label();
            bnt_nhap = new Button();
            label3 = new Label();
            txt_hienthi = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txt_nhap = new TextBox();
            lstBox_hienthi = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Magenta;
            label1.Cursor = Cursors.SizeAll;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(-10, -1);
            label1.Name = "label1";
            label1.Size = new Size(812, 98);
            label1.TabIndex = 0;
            label1.Text = "Khai báo y tế điện tử";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 1;
            label2.Text = "Họ tên: ";
            label2.Click += label2_Click;
            // 
            // bnt_nhap
            // 
            bnt_nhap.Location = new Point(81, 208);
            bnt_nhap.Name = "bnt_nhap";
            bnt_nhap.Size = new Size(156, 29);
            bnt_nhap.TabIndex = 3;
            bnt_nhap.Text = "Nhập thông tin";
            bnt_nhap.UseVisualStyleBackColor = true;
            bnt_nhap.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(366, 358);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 5;
            label3.Text = "Tổng số người đã khai báo";
            // 
            // txt_hienthi
            // 
            txt_hienthi.Location = new Point(579, 355);
            txt_hienthi.Name = "txt_hienthi";
            txt_hienthi.Size = new Size(125, 27);
            txt_hienthi.TabIndex = 6;
            txt_hienthi.TextChanged += txt_hienthi_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(370, 401);
            button2.Name = "button2";
            button2.Size = new Size(186, 29);
            button2.TabIndex = 7;
            button2.Text = "Xóa thông tin đang chọn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(579, 401);
            button3.Name = "button3";
            button3.Size = new Size(186, 29);
            button3.TabIndex = 8;
            button3.Text = "Xóa thông tin đầu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(370, 449);
            button4.Name = "button4";
            button4.Size = new Size(186, 29);
            button4.TabIndex = 9;
            button4.Text = "Xóa tất cả thông tin";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(579, 449);
            button5.Name = "button5";
            button5.Size = new Size(186, 29);
            button5.TabIndex = 10;
            button5.Text = "Xóa thông tin cuối";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_nhap
            // 
            txt_nhap.Location = new Point(92, 136);
            txt_nhap.Name = "txt_nhap";
            txt_nhap.Size = new Size(192, 27);
            txt_nhap.TabIndex = 11;
            // 
            // lstBox_hienthi
            // 
            lstBox_hienthi.FormattingEnabled = true;
            lstBox_hienthi.ItemHeight = 20;
            lstBox_hienthi.Location = new Point(354, 111);
            lstBox_hienthi.Name = "lstBox_hienthi";
            lstBox_hienthi.Size = new Size(434, 224);
            lstBox_hienthi.TabIndex = 12;
            // 
            // Lab2Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(lstBox_hienthi);
            Controls.Add(txt_nhap);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_hienthi);
            Controls.Add(label3);
            Controls.Add(bnt_nhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab2Bai4";
            Text = "Bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bnt_nhap;
        private Label label3;
        private TextBox txt_hienthi;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txt_nhap;
        private ListBox lstBox_hienthi;
    }
}