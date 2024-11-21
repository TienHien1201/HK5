namespace Buoi2Demo
{
    partial class Lab2bai6Form2
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 150);
            label1.Name = "label1";
            label1.Size = new Size(362, 144);
            label1.TabIndex = 0;
            label1.Text = "Chào mừng các bạn đến với plpSoft.vn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lab2bai6Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "Lab2bai6Form2";
            Text = "Form2";
            Load += Lab2bai6Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}