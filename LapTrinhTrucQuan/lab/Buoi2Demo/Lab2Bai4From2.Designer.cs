namespace Buoi2Demo
{
    partial class Lab2Bai4From2
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
            lb_doimau = new Label();
            label2 = new Label();
            cbo_color = new ComboBox();
            bnt_doimau = new Button();
            button2 = new Button();
            btn_doiMau = new Button();
            SuspendLayout();
            // 
            // lb_doimau
            // 
            lb_doimau.BackColor = Color.Yellow;
            lb_doimau.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lb_doimau.ForeColor = Color.Red;
            lb_doimau.Location = new Point(137, 50);
            lb_doimau.Name = "lb_doimau";
            lb_doimau.Size = new Size(527, 62);
            lb_doimau.TabIndex = 0;
            lb_doimau.Text = "Chào mừng bạn đến với plpsort.vn";
            lb_doimau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(193, 195);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Chọn màu";
            // 
            // cbo_color
            // 
            cbo_color.FormattingEnabled = true;
            cbo_color.Items.AddRange(new object[] { "Red", "Yellow", "Blue", "Black" });
            cbo_color.Location = new Point(280, 192);
            cbo_color.Name = "cbo_color";
            cbo_color.Size = new Size(354, 28);
            cbo_color.TabIndex = 2;
            // 
            // bnt_doimau
            // 
            bnt_doimau.Location = new Point(193, 363);
            bnt_doimau.Name = "bnt_doimau";
            bnt_doimau.Size = new Size(112, 39);
            bnt_doimau.TabIndex = 3;
            bnt_doimau.Text = "Đổi màu";
            bnt_doimau.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(528, 365);
            button2.Name = "button2";
            button2.Size = new Size(106, 34);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_doiMau
            // 
            btn_doiMau.Location = new Point(280, 365);
            btn_doiMau.Name = "btn_doiMau";
            btn_doiMau.Size = new Size(106, 34);
            btn_doiMau.TabIndex = 5;
            btn_doiMau.Text = "Đổi màu";
            btn_doiMau.UseVisualStyleBackColor = true;
            btn_doiMau.Click += btn_doiMau_Click;
            // 
            // Lab2Bai4From2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_doiMau);
            Controls.Add(button2);
            Controls.Add(cbo_color);
            Controls.Add(label2);
            Controls.Add(lb_doimau);
            Name = "Lab2Bai4From2";
            Text = "Lab2BaiFrom2";
            ResumeLayout(false);
        }

        #endregion

        private Label lb_doimau;
        private Label label2;
        private ComboBox cbo_color;
        private Button bnt_doimau;
        private Button button2;
        private Button btn_doiMau;
    }
}