using Buoi5.BT8DTHD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buoi5.Bai8Lab4
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }
        BT8DTHD.BT8DTHD data = new BT8DTHD.BT8DTHD();
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
        DoccGia dg = new DoccGia();
        void setNull()
        {
            textBox1.Text = ""; textBox3.Text = ""; textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            textBox1.Focus();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.LayDuLieu("select * from DocGia;");
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Giả sử cột đầu tiên chứa ID hoặc giá trị cần để xóa nhân viên
                    string selectedID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    // Gọi phương thức xóa nhân viên
                    dg.XoaDocGia(selectedID);

                    // Xóa dòng từ DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    // Gọi phương thức setNull để thiết lập lại các giá trị
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                themmoi = false; setButton(false);

            }
            else


                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ngaySinh = String.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            string ngayLap = String.Format("{0:MM/dd/yyyy}", dateTimePicker2.Value);
            string ngayHet = String.Format("{0:MM/dd/yyyy}", dateTimePicker3.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver if (themmoi)
            if (themmoi)
            {

                dg.ThemDocGia(textBox1.Text, ngaySinh, textBox3.Text, textBox2.Text, ngayLap, ngayHet, Double.Parse(textBox4.Text));


                MessageBox.Show("Thêm mới thành công");

            }
            else
            {
                // Lấy giá trị ID của độc giả từ cột đầu tiên của dòng được chọn
                string selectedID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Cập nhật độc giả
                dg.CapNhatDocGia(selectedID, textBox1.Text, ngaySinh, textBox3.Text, textBox2.Text, ngayLap, ngayHet, Double.Parse(textBox4.Text));

            }
            dataGridView1.DataSource = data.LayDuLieu("select * from DocGia;");
            setNull();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                // Chuyển sang kiểu DateTime
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                // Chuyển sang kiểu DateTime
                dateTimePicker2.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                // Chuyển sang kiểu DateTime
                dateTimePicker3.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                 textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setButton(true);
        }
    }
}
