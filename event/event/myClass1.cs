using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exEvent
{
    class myClass1
{
        public event EventHandler OnPropertyChanged;
        string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(this, new EventArgs());
            }
        }
}
}
