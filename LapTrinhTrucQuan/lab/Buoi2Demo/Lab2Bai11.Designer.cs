namespace Buoi2Demo
{
    partial class Lab2Bai11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2Bai11));
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            hiểnThịThờiGianToolStripMenuItem = new ToolStripMenuItem();
            hiểnThịThờiGianToolStripMenuItem1 = new ToolStripMenuItem();
            hiểnThịNToolStripMenuItem = new ToolStripMenuItem();
            lblTime = new Label();
            lblDate = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ContextMenuStrip = contextMenuStrip1;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(220, 40);
            label1.Name = "label1";
            label1.Size = new Size(360, 50);
            label1.TabIndex = 0;
            label1.Text = "Context Menu Strip";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { hiểnThịThờiGianToolStripMenuItem, hiểnThịThờiGianToolStripMenuItem1, hiểnThịNToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 104);
            // 
            // hiểnThịThờiGianToolStripMenuItem
            // 
            hiểnThịThờiGianToolStripMenuItem.Name = "hiểnThịThờiGianToolStripMenuItem";
            hiểnThịThờiGianToolStripMenuItem.Size = new Size(210, 24);
            hiểnThịThờiGianToolStripMenuItem.Text = "Menu Exit Ctrl + T";
            hiểnThịThờiGianToolStripMenuItem.Click += hiểnThịThờiGianToolStripMenuItem_Click;
            // 
            // hiểnThịThờiGianToolStripMenuItem1
            // 
            hiểnThịThờiGianToolStripMenuItem1.Name = "hiểnThịThờiGianToolStripMenuItem1";
            hiểnThịThờiGianToolStripMenuItem1.Size = new Size(210, 24);
            hiểnThịThờiGianToolStripMenuItem1.Text = "Display Time";
            hiểnThịThờiGianToolStripMenuItem1.Click += hiểnThịThờiGianToolStripMenuItem1_Click;
            // 
            // hiểnThịNToolStripMenuItem
            // 
            hiểnThịNToolStripMenuItem.Name = "hiểnThịNToolStripMenuItem";
            hiểnThịNToolStripMenuItem.Size = new Size(210, 24);
            hiểnThịNToolStripMenuItem.Text = "Display Date";
            hiểnThịNToolStripMenuItem.Click += hiểnThịNToolStripMenuItem_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(557, 221);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(71, 20);
            lblTime.TabIndex = 1;
            lblTime.Text = "Thời gian";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(567, 297);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(119, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Ngày tháng năm";
            lblDate.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 296);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Lab2Bai11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Name = "Lab2Bai11";
            Text = "Lab2Bai11";
            Load += Lab2Bai11_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Label lblDate;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem hiểnThịThờiGianToolStripMenuItem;
        private ToolStripMenuItem hiểnThịThờiGianToolStripMenuItem1;
        private ToolStripMenuItem hiểnThịNToolStripMenuItem;
    }
}