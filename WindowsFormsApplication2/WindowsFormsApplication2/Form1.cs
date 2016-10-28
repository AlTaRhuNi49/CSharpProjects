using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "ho":
                    MessageBox.Show("hello ho");
                    break;
                case "fo":
                    MessageBox.Show("hello fo");
                    break;
                default :
                    MessageBox.Show("nothig :P");
                    break;

            }
        }
    }
}
