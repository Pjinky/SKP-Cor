﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = string.Empty;

        private void TextUpdate(string output)
        {
            this.textBox1.Text += output;
        }

        private void Calc(string input)
        {
            int[] output;
            int final = 0;
            if (input.Contains('+'))
            {
                string[] vs = input.Split('+');
                output = new int[vs.Length];
                for (int i = 0; i < vs.Length; i++)
                {
                    if (int.TryParse(vs[i], out output[i]))
                    {
                        final += output[i];
                    }
                }
            }
            this.textBox1.Text = final + "";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            Calc(input);
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if(input[input.Length - 1] != '+')
            {
                TextUpdate("+");
                input += "+";
            }
            else
            {

            }
            
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            TextUpdate("0");
            input += "0";
        }

        private void btn_One_Click(object sender, EventArgs e)
        {
            TextUpdate("1");
            input += "1";
        }

        private void btn_Two_Click(object sender, EventArgs e)
        {
            TextUpdate("2");
            input += "2";
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            TextUpdate("3");
            input += "3";
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            TextUpdate("4");
            input += "4";
        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            TextUpdate("5");
            input += "5";
        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            TextUpdate("6");
            input += "6";
        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            TextUpdate("7");
            input += "7";
        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            TextUpdate("8");
            input += "8";
        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            TextUpdate("9");
            input += "9";
        }
    }
}
