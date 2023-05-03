using Microsoft.Office.Interop.Excel;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string fullTtext = textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text + "\n" + textBox5.Text + "\n";
            richTextBox1.Text = fullTtext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ofd.ShowDialog();
            string filename = ofd.FileName;
            Microsoft.Office.Interop.Excel.Application excelobj= new Microsoft.Office.Interop.Excel.Application();
            excelobj.Visible = true;
            Workbook wb = excelobj.Workbooks.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet wsh = wb.Sheets[1];
            wsh.Cells[1, 1] = textBox1.Text;
            wb.Save(); wb.Close();
        }
    }
}