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

namespace binaryreader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Save";
            button2.Text = "write";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "text file |*.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string path = sf.FileName;
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.Write(textBox1.Text);
                sw.Dispose();
            }
        }
    }
}
