using Buoi5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.Bai7Lab4
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        BT7DTHD.BT7DTHD data = new BT7DTHD.BT7DTHD();
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.LayDuLieu("select * from SinhVien;");
        }
        Model1 database = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                dataGridView1.DataSource = database.SinhVien.ToList<SinhVien>().FindAll(s => s.MaKhoa == comboBox1.Text);
        }
    }
}
