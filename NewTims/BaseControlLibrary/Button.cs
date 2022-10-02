using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControlLibrary
{
    [ToolboxBitmap(@"Button.bmp")]
    public partial class Button : UserControl
    {
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;
        static Lib Lib = new Lib();

        public Button()
        {
            InitializeComponent();
            DefaultTop = Top;
            DefaultLeft = Left;
            DefaultHeight = Height;
            DefaultWidth = Width;
        }
        Lib.ResizeCtrl();
    }
}