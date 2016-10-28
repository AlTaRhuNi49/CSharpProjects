using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace streamreader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//to open file dialog
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)//check if the user opened file
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));//read the file that the user opened
                textBox1.Text = sr.ReadToEnd();//get the text of the file to set on text box
                sr.Dispose();//to close the file after 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
