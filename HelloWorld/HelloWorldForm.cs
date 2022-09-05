using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            label1.Text = "this is my first form buliding";
        }
       
    }
}
