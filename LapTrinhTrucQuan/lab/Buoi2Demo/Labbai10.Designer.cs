namespace Buoi2Demo
{
    partial class Labbai10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labbai10));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            ctrlTToolStripMenuItem = new ToolStripMenuItem();
            hiểnThịToolStripMenuItem = new ToolStripComboBox();
            label1 = new Label();
            lblTime = new Label();
            lblDate = new Label();
            timerTime = new System.Windows.Forms.Timer(components);
            timerDate = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 399);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, hiểnThịToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 28);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ctrlTToolStripMenuItem });
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(130, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // ctrlTToolStripMenuItem
            // 
            ctrlTToolStripMenuItem.Name = "ctrlTToolStripMenuItem";
            ctrlTToolStripMenuItem.Size = new Size(137, 26);
            ctrlTToolStripMenuItem.Text = "Ctrl+ T";
            // 
            // hiểnThịToolStripMenuItem
            // 
            hiểnThịToolStripMenuItem.AutoSize = false;
            hiểnThịToolStripMenuItem.Items.AddRange(new object[] { "Hiển thị giờ", "Hiển thị ngày tháng" });
            hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            hiểnThịToolStripMenuItem.Size = new Size(75, 28);
            hiểnThịToolStripMenuItem.Text = "Hiển thị";
            hiểnThịToolStripMenuItem.Click += hiểnThịToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 32);
            label1.Name = "label1";
            label1.Size = new Size(282, 50);
            label1.TabIndex = 2;
            label1.Text = "Menu lựa chọn";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTime.Location = new Point(502, 218);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(112, 31);
            lblTime.TabIndex = 3;
            lblTime.Text = "Thời gian";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDate.Location = new Point(502, 275);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(188, 31);
            lblDate.TabIndex = 5;
            lblDate.Text = "Ngày tháng năm";
            lblDate.Click += label3_Click;
            // 
            // timerTime
            // 
            timerTime.Tick += timer1_Tick;
            // 
            // timerDate
            // 
            timerDate.Tick += timer2_Tick;
            // 
            // Labbai10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "Labbai10";
            Text = "Labbai10";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem ctrlTToolStripMenuItem;
        private ToolStripComboBox hiểnThịToolStripMenuItem;
        private Label label1;
        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerDate;
        private ToolTip toolTip1;
    }
}