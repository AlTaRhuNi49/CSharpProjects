using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "cal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal i = numericUpDown1.Value;
            decimal b = numericUpDown2.Value;
            MessageBox.Show((i + b).ToString());


        }
    }
}
