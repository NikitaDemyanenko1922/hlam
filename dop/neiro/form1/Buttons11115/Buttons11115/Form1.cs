﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons11115
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

        private void button_recognize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChngStatButton(button1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChngStatButton(button2, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChngStatButton(button3, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChngStatButton(button4, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChngStatButton(button5, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChngStatButton(button6, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChngStatButton(button7, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChngStatButton(button8, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChngStatButton(button9, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChngStatButton(button10, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChngStatButton(button11, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChngStatButton(button12, 0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ChngStatButton(button13, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChngStatButton(button14, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ChngStatButton(button15, 0);
        }

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
