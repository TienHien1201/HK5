using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MotSoBai
{
    public partial class Bai3_3 : Form
    {
        public Bai3_3()
        {
            InitializeComponent();
        }
        class User
        {
            public string Value { get; set; }
            public string Group { get; set; }
        }
        List<User> users = new List<User>();
        void CreateUsers()
        {
            users.Add(new User() { Value = "1645", Group = "Technicians" });
            users.Add(new User() { Value = "1689", Group = "Technicians" });
            users.Add(new User() { Value = "8345", Group = "Custodians" });
            users.Add(new User() { Value = "9998", Group = "Scientist" });
            users.Add(new User() { Value = "1006", Group = "Scientist" });
            users.Add(new User() { Value = "1007", Group = "Scientist" });
            users.Add(new User() { Value = "1008", Group = "Scientist" });
        }
        private void Bai3_3_Load(object sender, EventArgs e)
        {
            CreateUsers();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt =sender as Button;// (Button)sender;
            tbCode.Text += bt.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbCode.Clear();
        }

        private void btLoggin_Click(object sender, EventArgs e)
        {
            User user = users.Find(u => u.Value == tbCode.Text);
            if (user != null)
            {
                lbAccessedList.Items.Add(DateTime.Now.ToString($"dd-MM-yyyy hh:mm:ss tt")+$"\t{user.Group}");
            }
            else
            {
                lbAccessedList.Items.Add(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt")+"\tRestricted Access!");
            }
        }

        private void Bai3_3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1) 
            {
                bt1.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                bt2.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                bt3.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                bt4.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> contents = new List<string>();
            if(lbAccessedList.Items.Count == 0 ) {
                MessageBox.Show("Chưa có gì để lưu!");
            }
            else
            {
                foreach (string item in lbAccessedList.Items)
                    contents.Add(item);
                //lưu lên file
                File.WriteAllLines(Application.StartupPath + "\\File\\NhatKyDangNhap.txt", contents);
                MessageBox.Show("Đã lưu lên file: "+ Application.StartupPath + "\\File\\NhatKyDangNhap.txt");
            }
        }
    }
}
