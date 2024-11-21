namespace Buoi2Demo
{
    partial class Lab2Cau2
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textSo1 = new TextBox();
            textSo2 = new TextBox();
            label3 = new Label();
            textKq = new TextBox();
            button5 = new Button();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Số 1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Số 2:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(31, 33);
            button1.Name = "button1";
            button1.Size = new Size(96, 59);
            button1.TabIndex = 2;
            button1.Text = "+\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(133, 33);
            button2.Name = "button2";
            button2.Size = new Size(98, 59);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(339, 33);
            button3.Name = "button3";
            button3.Size = new Size(92, 59);
            button3.TabIndex = 4;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Location = new Point(437, 33);
            button4.Name = "button4";
            button4.Size = new Size(99, 59);
            button4.TabIndex = 5;
            button4.Text = "del";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textSo1
            // 
            textSo1.Location = new Point(126, 39);
            textSo1.Name = "textSo1";
            textSo1.Size = new Size(599, 27);
            textSo1.TabIndex = 6;
            textSo1.Text = "1";
            // 
            // textSo2
            // 
            textSo2.Location = new Point(126, 99);
            textSo2.Name = "textSo2";
            textSo2.Size = new Size(599, 27);
            textSo2.TabIndex = 7;
            textSo2.TextChanged += textSo2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 341);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 8;
            label3.Text = "Kết quả:";
            // 
            // textKq
            // 
            textKq.Cursor = Cursors.No;
            textKq.Location = new Point(126, 344);
            textKq.Name = "textKq";
            textKq.Size = new Size(599, 27);
            textKq.TabIndex = 9;
            textKq.TextChanged += textKq_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Location = new Point(237, 33);
            button5.Name = "button5";
            button5.Size = new Size(96, 59);
            button5.TabIndex = 10;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(117, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Lab1Cau2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(textKq);
            Controls.Add(label3);
            Controls.Add(textSo2);
            Controls.Add(textSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Câu 2";
            Text = "Câu 2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textSo1;
        private TextBox textSo2;
        private Label label3;
        private TextBox textKq;
        private Button button5;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
    }
}