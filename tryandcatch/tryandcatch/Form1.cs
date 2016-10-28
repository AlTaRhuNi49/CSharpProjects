using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryandcatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try//try this code if it is working or not
            {
                string[] names = new string[2];
                string s = names[2];
            }
            catch (Exception ex)//catch if there is any error
            {
                MessageBox.Show(ex.Message);
            }
            finally//this code will exist even there is an error or not
            {
                MessageBox.Show("ur code is done :P");
            }
        }
    }
}
