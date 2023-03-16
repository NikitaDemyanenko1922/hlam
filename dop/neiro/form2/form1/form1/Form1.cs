using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using form1.NewClassus;

namespace form1
{
    public partial class Form1 : Form
    {
        //Поля
        private int[] inputData = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        NeuroNetwork neuroNetwork;
        //Свойства

        //Конструктор
        public Form1()
        {
            InitializeComponent();
           // neuroNetwork = new NeuroNetwork();
        }

        private void ChngStatButton(Button b, int index)
        {
            if (b.BackColor == Color.Black)
            {
                b.BackColor = Color.White;
                inputData[index] = 0;
            }
            else
            {
                b.BackColor = Color.Black;
                inputData[index] = 1;
            }
        }

        //Метод сохранения обучающего множества
        private void radioButtonSaveTrain_Click(object sender, EventArgs e)
        {
            string strInputData = "";
            //string adress_of_app = Application.ExecutablePath;
            for(int i = 0; i<inputData.Length;i++)
            {
                strInputData += inputData[i].ToString();
            }
            //File.WriteAllText(adress_of_app+"/trainSet/fileTrainSet.txt", strInputData);
            File.AppendAllText("Z:/Neiro/form1/trainSet/fileTrainSet.txt", strInputData + " \n");
        }

        private void button_Recognize_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":(");
        }

        private void button1_Click(object sender, EventArgs e)
         {
            ChngStatButton(button1, 0);
         }

         private void button2_Click(object sender, EventArgs e)
         {
            ChngStatButton(button2, 1);
        }

         private void button3_Click(object sender, EventArgs e)
         {
            ChngStatButton(button3, 2);
         }

         private void button4_Click(object sender, EventArgs e)
         {
            ChngStatButton(button4, 3);
        }

         private void button5_Click(object sender, EventArgs e)
         {
            ChngStatButton(button5, 4);
        }

         private void button6_Click(object sender, EventArgs e)
         {
            ChngStatButton(button6, 5);
        }

         private void button7_Click(object sender, EventArgs e)
         {
            ChngStatButton(button7, 6);
        }

         private void button8_Click(object sender, EventArgs e)
         {
            ChngStatButton(button8, 7);
        }

         private void button9_Click(object sender, EventArgs e)
         {
            ChngStatButton(button9, 8);
        }

         private void button10_Click(object sender, EventArgs e)
         {
            ChngStatButton(button10, 9); 
         }

         private void button11_Click(object sender, EventArgs e)
         {
            ChngStatButton(button11, 10);
        }

         private void button12_Click(object sender, EventArgs e)
         {
            ChngStatButton(button12, 11);
        }

         private void button13_Click(object sender, EventArgs e)
         {
            ChngStatButton(button13, 12);
        }

         private void button14_Click(object sender, EventArgs e)
         {
            ChngStatButton(button14, 13);
        }

         private void button15_Click(object sender, EventArgs e)
         {
            ChngStatButton(button15, 14);
        }
    }
}
