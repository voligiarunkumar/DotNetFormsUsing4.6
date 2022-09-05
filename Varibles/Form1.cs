using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varibles
{
    public partial class Form1 : Form
    {
        #region varibles  
        string[] nameArray = { "", "", "", "", };
        int arrcount=0;
        #endregion

        #region init & Load
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (arrcount < nameArray.Length)
            {
                if (textBox.Text != null && textBox.Text.Trim() != "")
                {
                    nameArray[arrcount] = textBox.Text;
                    arrcount++;
                    textBox1.Text = arrcount.ToString();
                }
                else
                {
                    errormessage.Text = "name should not be null and no spaces";
                }
            }
            else
            {
                
                for (int i = 0; i < nameArray.Length; i++)
                {
                    errormessage.Text = nameArray[i];
                }
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            errormessage.Text = "";
     
            textBox2.Text =nameArray.Length.ToString();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
