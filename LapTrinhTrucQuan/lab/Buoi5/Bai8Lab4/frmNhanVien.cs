using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Buoi5.Bai8Lab4
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BT8DTHD.BT8DTHD data = new BT8DTHD.BT8DTHD();
      

        private void button1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false); 
            textBox1.Focus();

        }
        void setButton(bool val)
        {
            button1.Enabled = val;
            button2.Enabled = val;
            button3.Enabled = val;
            button4.Enabled = val;
            button5.Enabled = !val;
            button6.Enabled = !val;
        }
        public bool themmoi = false;
        void setNull()
        {
            textBox1.Text = ""; textBox3.Text = ""; textBox2.Text = "";
        }

        void LayDuLieuNhanVien()
        {
         

            lsvNhanVien.Items.Clear(); // Clear existing items
            DataTable dt = data.LayDuLieu("select * from NHANVIEN");

      
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNhanVien.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }


        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet.BANGCAP' table. You can move, or remove it, as needed.
            this.bANGCAPTableAdapter.Fill(this.qLTHUVIENDataSet.BANGCAP);
           setNull();
            setButton(true);
            LayDuLieuNhanVien();

        }

       

        private void button3_Click(object sender, EventArgs e)
        {


            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                themmoi = false; setButton(false);

            }
            else


                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            setButton(true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        Bai8Lab4.NhanVien nv = new NhanVien();
        private void button2_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(
                    lsvNhanVien.SelectedItems[0].SubItems[0].Text); lsvNhanVien.Items.RemoveAt(
                    lsvNhanVien.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");


        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                textBox1.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dateTimePicker1.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                textBox3.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                textBox2.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox cboBangCap.SelectedIndex =
                comboBox1.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver if (themmoi)
            if(themmoi)  {

  nv.ThemNhanVien(textBox1.Text, ngay, textBox3.Text, textBox2.Text, comboBox1.SelectedValue.ToString());


  MessageBox.Show("Thêm mới thành công");

            }
            else
            {
                nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, textBox1.Text, ngay, textBox3.Text, textBox2.Text, comboBox1.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }

            LayDuLieuNhanVien();
            setNull();

        }
    }
    }
