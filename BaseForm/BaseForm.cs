using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm
{
    public partial class BaseForm : Form
    {
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;
        public BaseForm()
        {
            InitializeComponent();
            DefaultTop = Top;
            DefaultLeft = Left;
            DefaultHeight = Height;
            DefaultWidth = Width;
        }
    }
}
