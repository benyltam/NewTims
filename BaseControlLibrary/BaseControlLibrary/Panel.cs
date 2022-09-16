using Library;
using System.Drawing;
using System.Windows.Forms;

namespace BaseControlLibrary
{
    //[ToolboxBitmap(@"Panel.bmp")]
    public partial class Panel : UserControl
    {
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;
        private readonly Lib lib;
        public Panel()
        {
            InitializeComponent();
            int DefaultTop = this.Top;
            int DefaultLeft = this.Left;
            int DefaultHeight = this.Height;
            int DefaultWidth = this.Width;
            string ResizeSetting = "";
            Lib lib = new Lib();
            lib.ResizeCtrl(ResizeSetting, Parent.Height, Parent.DefaultHeight, Parent.Width,Parent.DefaultWidth
                , Top, Left, Height, Width, DefaultHeight, DefaultTop, DefaultWidth, DefaultLeft);

            //public void ResizeCtrl(string str, ref int parentHeight, ref int parentDefaultHeight, ref int parentWidth, ref int parentDefaultWidth,
            //    ref int top, ref int left, ref int height, ref int width,
            //    ref int defaultHeight, ref int defaultTop, ref int defaultWidth, ref int defaultLeft)
        }

    }
}