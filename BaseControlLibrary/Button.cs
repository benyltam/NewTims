using System.Drawing;
using System.Windows.Forms;
//using Library;


namespace BaseControlLibrary
{
    [ToolboxBitmap(@"Button.bmp")]
    public partial class Button : UserControl
    {
        static int DefaultTop;
        static int DefaultLeft;
        static int DefaultHeight;
        static int DefaultWidth;

        public Button()
        {
            InitializeComponent();
            DefaultTop = Top;
            DefaultLeft = Left;
            DefaultHeight = Height;
            DefaultWidth = Width;

        }
    }
}
