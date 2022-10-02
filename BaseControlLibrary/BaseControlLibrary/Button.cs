using System.Drawing;
using System.Windows.Forms;
using Library;


namespace BaseControlLibrary
{
    [ToolboxBitmap(@"Button.bmp")]
    public partial class Button : UserControl
    {
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;

        static int ParentDefaultHeight;
        static int ParentDefaultWidth;
        static int ParentHeight;
        static int ParentWidth;
        static string ResizeSetting;

        private readonly Lib lib = new Lib();

        public Button()
        {
            DefaultTop = Top;
            DefaultLeft = Left;
            DefaultHeight = Height;
            DefaultWidth = Width;
            ResizeSetting = "";

            InitializeComponent();
            lib.RestoreCtrlSize();

            int height = Height;
            int width = Width;
            int top = Top;
            int left = Left;

            //public void ResizeCtrl(string str, ref int ParentHeight, int ParentDefaultHeight, ref int ParentWidth, int ParentDefaultWidth,
            //    ref int height, ref int width, ref int top, ref int left,
            //    int defaultHeight, int defaultWidth, int defaultTop, int defaultLeft)
            if (!string.IsNullOrEmpty(ResizeSetting))
            lib.ResizeCtrl(ResizeSetting, ref ParentHeight, ParentDefaultHeight, ref ParentWidth, ParentDefaultWidth
                , ref height, ref width, ref top, ref left
                , DefaultHeight, DefaultWidth, DefaultTop, DefaultLeft);
        }
    }
}