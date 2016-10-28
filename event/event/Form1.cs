using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exEvent.myClass1 mc = new exEvent.myClass1();
            mc.OnPropertyChanged += new EventHandler (Mc_OnPropertyChanged);
            mc.Name = "adam";
        }

        private void Mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("the propertu");
        }
    }
}
