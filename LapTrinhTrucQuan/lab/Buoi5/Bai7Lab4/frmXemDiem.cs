using Buoi5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.Bai7Lab4
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }
        BT7DTHD.BT7DTHD data = new BT7DTHD.BT7DTHD();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'lTTQ_Lab4_BT7_S4DataSet1.KetQua' table. You can move, or remove it, as needed.
        
            dataGridView2.DataSource = data.LayDuLieu("select * from KetQua;");
            // TODO: This line of code loads data into the 'lTTQ_Lab4_BT7_S4DataSet.KetQua' table. You can move, or remove it, as needed.
           
           
            

        }
        Model1 db = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                //    sql += $" where MaKhoa='{MaKhoa}';";

                dataGridView2.DataSource = db.KetQua.ToList<KetQua>().FindAll(s => s.MaSo == int.Parse(comboBox1.Text));
            else { MessageBox.Show("Vui lòng chọn sinh viên cần xem!"); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
