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

namespace streamwriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "open";
            button2.Text = "write";
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(File.OpenWrite(path));//to write on text file but the new writing will override the previous writing
            StreamWriter sw = new StreamWriter(File.Create(path));
            sw.Write(textBox1.Text);
            sw.Dispose();
        }
    }
}
