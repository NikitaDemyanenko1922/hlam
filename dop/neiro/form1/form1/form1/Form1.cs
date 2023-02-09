using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        //Поля
        private int[] inputData = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //Свойства

        //Конструктор
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Recognize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

         private void button1_Click(object sender, EventArgs e)
         {
            ChngStatButton(button1, 0);
         }

         /*private void button2_Click(object sender, EventArgs e)
         {
             button2.BackColor = Color.Black;
         }

         private void button3_Click(object sender, EventArgs e)
         {
             button3.BackColor = Color.Black;
         }

         private void button4_Click(object sender, EventArgs e)
         {
             button4.BackColor = Color.Black;
         }

         private void button5_Click(object sender, EventArgs e)
         {
             button5.BackColor = Color.Black;
         }

         private void button6_Click(object sender, EventArgs e)
         {
             button6.BackColor = Color.Black;
         }

         private void button7_Click(object sender, EventArgs e)
         {
             button7.BackColor = Color.Black;
         }

         private void button8_Click(object sender, EventArgs e)
         {
             button8.BackColor = Color.Black;
         }

         private void button9_Click(object sender, EventArgs e)
         {
             button9.BackColor = Color.Black;
         }

         private void button10_Click(object sender, EventArgs e)
         {
             button10.BackColor = Color.Black;
         }

         private void button11_Click(object sender, EventArgs e)
         {
             button11.BackColor = Color.Black;
         }

         private void button12_Click(object sender, EventArgs e)
         {
             button12.BackColor = Color.Black;
         }

         private void button13_Click(object sender, EventArgs e)
         {
             button13.BackColor = Color.Black;
         }

         private void button14_Click(object sender, EventArgs e)
         {
             button14.BackColor = Color.Black;
         }

         private void button15_Click(object sender, EventArgs e)
         {
             button15.BackColor = Color.Black;
         }*/

        private void ChngStatButton(Button b, int index)
        {
            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.Black;
                inputData[index] = 1;
            }
            else
            {
                b.BackColor = Color.White;
                inputData[index] = 0;
            }
        }
    }
}
