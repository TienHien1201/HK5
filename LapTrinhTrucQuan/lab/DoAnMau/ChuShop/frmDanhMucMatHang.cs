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
    public partial class frmDanhMucMatHang : Form
    {
        DoAnMauDB db = new DoAnMauDB();
        public frmDanhMucMatHang()
        {
            InitializeComponent();
        }
        int ViTriHienTai = 0;
        void LayDuLieuDanhMucMatHang()
        {
            MatHang.DataSource = db.LayDuLieu("select * from MatHang;");
            
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhMucMatHang_Load(object sender, EventArgs e)
        {
            LayDuLieuDanhMucMatHang();
        }
    }
}
