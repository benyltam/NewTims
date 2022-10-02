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
        private Lib lib;
        public Panel()
        {
            int DefaultTop = this.Top;
            int DefaultLeft = this.Left;
            int DefaultHeight = this.Height;
            int DefaultWidth = this.Width;
            string ResizeSetting = "";

            InitializeComponent();

            Lib lib = new Lib();
            int ParentHeight = Parent.Height;
            int ParentWidth = Parent.Width;
            int ParentDefaultWidth = 0;
            int ParentDefaultHeight = 0;
            int height = Height;
            int width = Width;
            int top = Top;
            int left = Left;

            if (!string.IsNullOrEmpty(ResizeSetting))
                lib.ResizeCtrl(ResizeSetting, ref ParentHeight, ParentDefaultHeight, ref ParentWidth, ParentDefaultWidth
                    , ref height, ref width, ref top, ref left, DefaultHeight, DefaultWidth, DefaultTop, DefaultLeft);

        }
    }
}
