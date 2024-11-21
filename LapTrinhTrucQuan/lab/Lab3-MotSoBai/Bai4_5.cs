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
    public partial class Bai4_5 : Form
    {
        public Bai4_5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstbatdau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = lstbatdau.SelectedItems.Count;
            for (int i = 0; i <= n - 1; i++) lstketqua.Items.Add(lstbatdau.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--) lstbatdau.Items.RemoveAt(j);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = lstbatdau.Items.Count;
            for (int i = 1; i <= n - 1; i++) lstketqua.Items.Add(lstbatdau.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--) lstbatdau.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = lstbatdau.SelectedItems.Count;
            for (int i = n - 1; i >= 0 ; i--) lstketqua.Items.Add(lstbatdau.SelectedItems[i].ToString());
            for (int j = 1; j < n - 1; j++) lstbatdau.Items.RemoveAt(j);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = lstketqua.Items.Count;
            for (int i = n - 1; i >= 0; i--) lstbatdau.Items.Add(lstketqua.Items[i].ToString());
            for (int j = 1; j < n - 1; j++) lstketqua.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = lstbatdau.SelectedItems.Count; //Số mục dang duoc chon trong IstKetqua
            for (int i = n - 1; i >= 0; i--)
                lstbatdau.Items.Remove(lstbatdau.SelectedItems[i].ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai4_5_Load(object sender, EventArgs e)
        {

        }
    }
}
