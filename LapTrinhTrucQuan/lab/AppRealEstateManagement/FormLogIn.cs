

namespace AppRealEstateManagement

{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            //MoFormCon(new FormHome());
        }
    }
}