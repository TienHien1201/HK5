namespace Buoi2Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Lab2Cau2 cau2 = new Lab2Cau2();
            cau2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2Cau3 cau3 = new Lab2Cau3();
            cau3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2Bai4From1 bai4f1 = new Lab2Bai4From1();
            bai4f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2Bai4From2 bai4f2 = new Lab2Bai4From2();
            bai4f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab2Bai5 bai5 = new Lab2Bai5();
            bai5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab2Bai6Form1 bai6 = new Lab2Bai6Form1();
            bai6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab2bai7 bai7 = new Lab2bai7();
            bai7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lab2bai8 bai8 = new Lab2bai8();
            bai8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lab2Bai9 bai9 = new lab2Bai9();
            bai9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Labbai10 bai10 = new Labbai10();
            bai10.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Lab2Bai11 bai11 = new Lab2Bai11();
            bai11.ShowDialog();
        }
    }
}