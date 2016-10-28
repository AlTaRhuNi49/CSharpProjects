using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openFiled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//open window to browes the files in the computer
            ofd.Filter = "image |*.png";//to determine which type of file must open (description |*.the type like (.zip))
            ofd.Title = "open image";//select name for open file dialog
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)//check if the user opened file
            {
                MessageBox.Show("hello");//the will executed if the user opened the file
                MessageBox.Show(ofd.FileName);//to get file path
                MessageBox.Show(ofd.SafeFileName);//to get the file name
            }
        }
    }
}
