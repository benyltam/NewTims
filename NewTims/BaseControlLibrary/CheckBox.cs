using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControlLibrary
{
    public partial class CheckBox : UserControl
    {
        //Lib lib = new Lib();
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;

        public CheckBox()
        {
            InitializeComponent();
            int DefaultTop = this.Top;
            int DefaultLeft = this.Left;
            int DefaultHeight = this.Height;
            int DefaultWidth = this.Width;
        }

        public void Resize()
        {
            //Lib.ResizeCtl();
        }

        private void XcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
