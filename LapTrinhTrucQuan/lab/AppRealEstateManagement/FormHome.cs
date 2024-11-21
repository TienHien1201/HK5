using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRealEstateManagement
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        //void MoFormCon(Form f)
        //{
        //    foreach (Form child in this.MdiChildren)
        //    {
        //        if (child.Name == f.Name)
        //        {
        //            child.Activate();
        //            return;
        //        }
        //    }
        //    f.MdiParent = this;
        //    f.Show();
        //}

        private void lbTongQuan_Click(object sender, EventArgs e)
        {

            FormsForHome.FrmTongQuan frmTongQuan = new FormsForHome.FrmTongQuan();
            frmTongQuan.Show();

        }

        private void lb_Click(object sender, EventArgs e)
        {
            FormsForHome.FormVitri frmVitri = new FormsForHome.FormVitri();
            frmVitri.Show();
        }
    }
}
