namespace AppRealEstateManagement
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbTongQuan = new Label();
            lb = new Label();
            menuStrip1 = new MenuStrip();
            phânKhuToolStripMenuItem = new ToolStripMenuItem();
            theBeverlyToolStripMenuItem = new ToolStripMenuItem();
            gloryHinhToolStripMenuItem = new ToolStripMenuItem();
            theBeverlySolaryToolStripMenuItem = new ToolStripMenuItem();
            theOpusOneToolStripMenuItem = new ToolStripMenuItem();
            theOrigramiToolStripMenuItem = new ToolStripMenuItem();
            theRainBowToolStripMenuItem = new ToolStripMenuItem();
            theMahattanGloryToolStripMenuItem = new ToolStripMenuItem();
            theMahattanToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1918, 1027);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lbTongQuan);
            flowLayoutPanel1.Controls.Add(lb);
            flowLayoutPanel1.Controls.Add(menuStrip1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(734, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(938, 39);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lbTongQuan
            // 
            lbTongQuan.BackColor = Color.Goldenrod;
            lbTongQuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongQuan.ForeColor = Color.White;
            lbTongQuan.Location = new Point(3, 0);
            lbTongQuan.Name = "lbTongQuan";
            lbTongQuan.Size = new Size(127, 37);
            lbTongQuan.TabIndex = 0;
            lbTongQuan.Text = "Tổng quan";
            lbTongQuan.Click += lbTongQuan_Click;
            // 
            // lb
            // 
            lb.BackColor = Color.Goldenrod;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb.ForeColor = Color.White;
            lb.Location = new Point(136, 0);
            lb.Name = "lb";
            lb.Size = new Size(127, 37);
            lb.TabIndex = 1;
            lb.Text = "Vị trí";
            lb.Click += lb_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { phânKhuToolStripMenuItem });
            menuStrip1.Location = new Point(266, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(122, 36);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // phânKhuToolStripMenuItem
            // 
            phânKhuToolStripMenuItem.BackColor = Color.Goldenrod;
            phânKhuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { theBeverlyToolStripMenuItem, gloryHinhToolStripMenuItem, theBeverlySolaryToolStripMenuItem, theOpusOneToolStripMenuItem, theOrigramiToolStripMenuItem, theRainBowToolStripMenuItem, theMahattanGloryToolStripMenuItem, theMahattanToolStripMenuItem });
            phânKhuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phânKhuToolStripMenuItem.ForeColor = Color.White;
            phânKhuToolStripMenuItem.Name = "phânKhuToolStripMenuItem";
            phânKhuToolStripMenuItem.Size = new Size(114, 32);
            phânKhuToolStripMenuItem.Text = "Phân khu";
            // 
            // theBeverlyToolStripMenuItem
            // 
            theBeverlyToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theBeverlyToolStripMenuItem.Name = "theBeverlyToolStripMenuItem";
            theBeverlyToolStripMenuItem.Size = new Size(256, 28);
            theBeverlyToolStripMenuItem.Text = "The Beverly";
            // 
            // gloryHinhToolStripMenuItem
            // 
            gloryHinhToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gloryHinhToolStripMenuItem.Name = "gloryHinhToolStripMenuItem";
            gloryHinhToolStripMenuItem.Size = new Size(256, 28);
            gloryHinhToolStripMenuItem.Text = "Glory Hights";
            // 
            // theBeverlySolaryToolStripMenuItem
            // 
            theBeverlySolaryToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theBeverlySolaryToolStripMenuItem.Name = "theBeverlySolaryToolStripMenuItem";
            theBeverlySolaryToolStripMenuItem.Size = new Size(256, 28);
            theBeverlySolaryToolStripMenuItem.Text = "The beverly Solary";
            // 
            // theOpusOneToolStripMenuItem
            // 
            theOpusOneToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theOpusOneToolStripMenuItem.Name = "theOpusOneToolStripMenuItem";
            theOpusOneToolStripMenuItem.Size = new Size(256, 28);
            theOpusOneToolStripMenuItem.Text = "The Opus One";
            // 
            // theOrigramiToolStripMenuItem
            // 
            theOrigramiToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theOrigramiToolStripMenuItem.Name = "theOrigramiToolStripMenuItem";
            theOrigramiToolStripMenuItem.Size = new Size(256, 28);
            theOrigramiToolStripMenuItem.Text = "The Origrami";
            // 
            // theRainBowToolStripMenuItem
            // 
            theRainBowToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theRainBowToolStripMenuItem.Name = "theRainBowToolStripMenuItem";
            theRainBowToolStripMenuItem.Size = new Size(256, 28);
            theRainBowToolStripMenuItem.Text = "The RainBow";
            // 
            // theMahattanGloryToolStripMenuItem
            // 
            theMahattanGloryToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theMahattanGloryToolStripMenuItem.Name = "theMahattanGloryToolStripMenuItem";
            theMahattanGloryToolStripMenuItem.Size = new Size(256, 28);
            theMahattanGloryToolStripMenuItem.Text = "The Mahattan Glory";
            // 
            // theMahattanToolStripMenuItem
            // 
            theMahattanToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            theMahattanToolStripMenuItem.Name = "theMahattanToolStripMenuItem";
            theMahattanToolStripMenuItem.Size = new Size(256, 28);
            theMahattanToolStripMenuItem.Text = "The mahattan";
            // 
            // label1
            // 
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(391, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 3;
            label1.Text = "Tiện ích";
            // 
            // label2
            // 
            label2.BackColor = Color.Goldenrod;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(524, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 4;
            label2.Text = "Bảng giá";
            // 
            // label3
            // 
            label3.BackColor = Color.Goldenrod;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(657, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 5;
            label3.Text = "Liên hệ";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1699, 655);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHome";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbTongQuan;
        private Label lb;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem phânKhuToolStripMenuItem;
        private ToolStripMenuItem theBeverlyToolStripMenuItem;
        private ToolStripMenuItem gloryHinhToolStripMenuItem;
        private ToolStripMenuItem theBeverlySolaryToolStripMenuItem;
        private ToolStripMenuItem theOpusOneToolStripMenuItem;
        private ToolStripMenuItem theOrigramiToolStripMenuItem;
        private ToolStripMenuItem theRainBowToolStripMenuItem;
        private ToolStripMenuItem theMahattanGloryToolStripMenuItem;
        private ToolStripMenuItem theMahattanToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}