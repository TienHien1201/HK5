using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MotSoBai
{
    public partial class Bai5_1 : Form
    {
        public Bai5_1()
        {
            InitializeComponent();
        }

        //xử lý cho các button tên món

        int STT = 0;
        void ThemMonVaoLuoi(string TenMon)
        {
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[1].Value.ToString() == TenMon)
                {
                    row.Cells[2].Value = int.Parse(row.Cells[2].Value.ToString()) + 1;
                    row.Cells[4].Value = int.Parse(row.Cells[4].Value.ToString()) + 30000;
                    return;
                }
            }
            dgvOrder.Rows.Add(1);
            DataGridViewRow newrow = dgvOrder.Rows[dgvOrder.Rows.Count - 1];
            newrow.Cells[0].Value = ++STT;
            newrow.Cells[1].Value = TenMon;
            newrow.Cells[2].Value = 1;
            newrow.Cells[3].Value = 30000;
            newrow.Cells[4].Value = 30000;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btMon= sender as Button;
            ThemMonVaoLuoi(btMon.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(dgvOrder.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!");
                return;
            }
            int vt = dgvOrder.SelectedRows[0].Index;
            dgvOrder.Rows.Remove(dgvOrder.SelectedRows[0]);
            //thay đổi STT trên giao diện
            for (int i = vt; i < dgvOrder.Rows.Count; i++)
            {
                dgvOrder.Rows[i].Cells[0].Value = ++vt;
            }
            STT--;
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if(cbbBan.Text=="")
            {
                MessageBox.Show("Vui lòng chọn bàn cần order!");
                return;
            }
            MessageBox.Show("Đã lưu order!");
            dgvOrder.Rows.Clear();
            cbbBan.Text = "";
            STT = 0;
        }
    }
}
