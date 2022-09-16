using Library;
using System.Drawing;
using System.Windows.Forms;

namespace BaseControlLibrary
{
    [ToolboxBitmap(@"CheckBox.bmp")]
    public partial class CheckBox : UserControl
    {
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;
        private readonly Lib lib;

        public CheckBox()
        {
            InitializeComponent();
            int DefaultTop = this.Top;
            int DefaultLeft = this.Left;
            int DefaultHeight = this.Height;
            int DefaultWidth = this.Width;
            lib = new Lib();
        }

        //public void UctrlResize()
        //{
        //    lib.ResizeCtrl(); //.ResizeCtl();
        //}
    }
}
