using System;
using System.Linq;
using System.Windows.Forms;

namespace NewTims
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //Lib Lib = new Lib();
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            //foreach (var p in this.Controls.OfType<BaseControlLibrary.Panel>())
            foreach (Control c in this.Controls)
            {
                try
                {
                    ResizeForm(c, e);
                }
                catch { }
            }
        }
    }
}

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
