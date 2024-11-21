namespace Buoi2Demo
{
    partial class Lab2bai8
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
            txtNode = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            treeView1 = new TreeView();
            button7 = new Button();
            button8 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 0;
            label1.Text = "TreeView";
            // 
            // txtNode
            // 
            txtNode.Location = new Point(477, 27);
            txtNode.Name = "txtNode";
            txtNode.Size = new Size(311, 27);
            txtNode.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(423, 93);
            button1.Name = "button1";
            button1.Size = new Size(365, 29);
            button1.TabIndex = 3;
            button1.Text = "Thêm node gốc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 141);
            button2.Name = "button2";
            button2.Size = new Size(365, 33);
            button2.TabIndex = 4;
            button2.Text = "Thêm node con";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(423, 236);
            button3.Name = "button3";
            button3.Size = new Size(365, 33);
            button3.TabIndex = 6;
            button3.Text = "Xóa node đang chọn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(423, 190);
            button4.Name = "button4";
            button4.Size = new Size(365, 29);
            button4.TabIndex = 5;
            button4.Text = "Xóa tất cả các node";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(423, 284);
            button6.Name = "button6";
            button6.Size = new Size(365, 29);
            button6.TabIndex = 7;
            button6.Text = "Đếm tổng node tree";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 77);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(366, 304);
            treeView1.TabIndex = 9;
            // 
            // button7
            // 
            button7.Location = new Point(687, 359);
            button7.Name = "button7";
            button7.Size = new Size(89, 33);
            button7.TabIndex = 11;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(423, 363);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 10;
            button8.Text = "+";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 30);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 12;
            label3.Text = "Tiêu đề Node";
            // 
            // Lab2bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(treeView1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNode);
            Controls.Add(label1);
            Name = "Lab2bai8";
            Text = "Lab2bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNode;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private TreeView treeView1;
        private Button button7;
        private Button button8;
        private Label label3;
    }
}