﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varible
{
    public partial class Form1 : Form
    {

        #region varibles
        string[] namearr = { "", "", "", "","",""};
        int arrcount=0;
        #endregion
        #region init & Load
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arrcount < namearr.Length)
            {
                if(textBox1.Text !=null && textBox1.Text.Trim()!="")
                {
                    namearr[arrcount] = textBox1.Text;
                    arrcount++;
                    textBox2.Text = arrcount.ToString();
                }
                else
                {
                    errormessage.Text = "No spaces and null values";
                }
            }
            else
            {
                errormessage.Text = "MaxLength Reached";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errormessage.Text = "";
            textBox3.Text = namearr.Length.ToString();
        }
    }
    #endregion

}
