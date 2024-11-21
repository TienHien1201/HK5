namespace Buoi2Demo
{
    partial class Lab2Bai6Form1
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
            label1 = new Label();
            lbl_complete = new Label();
            label3 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lbl_ngaythang = new Label();
            lbl_gio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(110, 0, 0, 0);
            label1.Size = new Size(799, 105);
            label1.TabIndex = 0;
            label1.Text = "Bây giờ là: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_complete
            // 
            lbl_complete.Location = new Point(360, 118);
            lbl_complete.Name = "lbl_complete";
            lbl_complete.Size = new Size(262, 22);
            lbl_complete.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 398);
            label3.Name = "label3";
            label3.Size = new Size(799, 53);
            label3.TabIndex = 2;
            label3.Text = "Xin chào các bạn đến với plpSoft.vn";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(69, 145);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 3;
            button1.Text = "Hiển thị ngày giờ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(285, 145);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(469, 52);
            progressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // lbl_ngaythang
            // 
            lbl_ngaythang.BackColor = SystemColors.ActiveBorder;
            lbl_ngaythang.ForeColor = SystemColors.ButtonFace;
            lbl_ngaythang.Location = new Point(339, 42);
            lbl_ngaythang.Name = "lbl_ngaythang";
            lbl_ngaythang.Size = new Size(191, 27);
            lbl_ngaythang.TabIndex = 5;
            // 
            // lbl_gio
            // 
            lbl_gio.BackColor = SystemColors.ActiveBorder;
            lbl_gio.ForeColor = SystemColors.ButtonFace;
            lbl_gio.Location = new Point(546, 42);
            lbl_gio.Name = "lbl_gio";
            lbl_gio.Size = new Size(219, 27);
            lbl_gio.TabIndex = 6;
            // 
            // Lab2Bai6Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_gio);
            Controls.Add(lbl_ngaythang);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lbl_complete);
            Controls.Add(label1);
            Name = "Lab2Bai6Form1";
            Text = "From1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_complete;
        private Label label3;
        private Button button1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label lbl_ngaythang;
        private Label lbl_gio;
    }
}