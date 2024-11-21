using DoAnMau.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMau.ChuShop
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        DoAnMauDB database = new DoAnMauDB();
        private int TinhTong()
        {
            int Tong = 0;
            for (int i = 0; i < dgvKetQua.RowCount; i++)
                Tong += int.Parse(dgvKetQua.Rows[i].Cells[7].Value.ToString());
            return Tong;
        }
        private void rdbtToanBo_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtToanBo.Checked)
            {
               // dgvKetQua.DataSource = database.vw_DoanhThu.ToList<vw_DoanhThu>();
                lbTong.Text = TinhTong().ToString("N0");
            }
        }

        private void rdbtThangHienTai_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtThangHienTai.Checked)
            {
               // dgvKetQua.DataSource = database.vw_DoanhThu.ToList<vw_DoanhThu>().FindAll(v => v.NgayLap.Value.Month == DateTime.Now.Month && v.NgayLap.Value.Year == DateTime.Now.Year);
                lbTong.Text = TinhTong().ToString("N0");

            }    
        }

        private void rdbtThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtThoiGian.Checked)
            {
                DateTime tungay = new DateTime(dtpTuNgay.Value.Year, dtpTuNgay.Value.Month, dtpTuNgay.Value.Day, 0, 0, 0);
                DateTime denngay = new DateTime(dtpDenNgay.Value.Year, dtpDenNgay.Value.Month, dtpDenNgay.Value.Day, 23, 59, 59);
              //  dgvKetQua.DataSource = database.vw_DoanhThu.ToList<vw_DoanhThu>().FindAll(v => v.NgayLap.Value >= tungay && v.NgayLap.Value <= denngay);
                lbTong.Text = TinhTong().ToString("N0");
            }
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
