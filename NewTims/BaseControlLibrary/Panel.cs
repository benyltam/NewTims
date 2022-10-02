using System.Windows.Forms;
using Library;

namespace BaseControlLibrary
{
    public partial class Panel : UserControl
    {
        //private Lib lib;
        public Panel()
        {
            InitializeComponent();
            //Lib lib = new Lib();
        }

        protected void DoSomething()
        {
            //string results = lib.String("string1", 10);
        }
    }
}

//static int DefaultTop;
//static int DefaultLeft;
//static int DefaultHeight;
//static int DefaultWidth;

//int DefaultTop = this.Top;
//int DefaultLeft = this.Left;
//int DefaultHeight = this.Height;
//int DefaultWidth = this.Width;
