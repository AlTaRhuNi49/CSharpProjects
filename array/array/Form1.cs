using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Text = "moahamed";
            checkBox2.Text = "ali";
            checkBox3.Text = "salem";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = { "mohamed", "ali", "salem" };
            string b = names[0];
            string c = names[1];
            string d = names[2];
            
        }
    }
}
