using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

public class ListViewCustom : BrightIdeasSoftware.DataListView
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
        public RECT(int Left, int Top, int Right, int Bottom)
        {
            left = Left;
            top = Top;
            right = Right;
            bottom = Bottom;
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    private struct NMHDR
    {
        public IntPtr hwndFrom;
        public IntPtr idFrom;
        public int code;
    }
    [StructLayout(LayoutKind.Sequential)]
    private struct NMLISTVIEW
    {
        public NMHDR hdr;
        public int iItem;
        public int iSubItem;
        public uint uNewState;
        public uint uOldState;
        public uint uChanged;
        public Point ptAction;
        public IntPtr lParam;
    }
    [StructLayout(LayoutKind.Sequential)]
    private struct NMCUSTOMDRAW
    {
        public NMHDR hdr;
        public int dwDrawStage;
        public IntPtr hdc;
        public RECT rc;
        public IntPtr dwItemSpec;
        public uint uItemState;
        public IntPtr lItemlParam;
    }
    [StructLayout(LayoutKind.Sequential)]
    private struct NMLVCUSTOMDRAW
    {
        public NMCUSTOMDRAW nmcd;
        public int clrText;
        public int clrTextBk;
        public int iSubItem;
        public int dwItemType;
        public int clrFace;
        public int iIconEffect;
        public int iIconPhase;
        public int iPartId;
        public int iStateId;
        public RECT rcText;
        public uint uAlign;
    }
    [FlagsAttribute]
    private enum CDRF
    {
        CDRF_DODEFAULT = 0x00000000,
        CDRF_NEWFONT = 0x00000002,
        CDRF_SKIPDEFAULT = 0x00000004,
        CDRF_DOERASE = 0x00000008,
        CDRF_SKIPPOSTPAINT = 0x00000100,
        CDRF_NOTIFYPOSTPAINT = 0x00000010,
        CDRF_NOTIFYITEMDRAW = 0x00000020,
        CDRF_NOTIFYSUBITEMDRAW = 0x00000020,
        CDRF_NOTIFYPOSTERASE = 0x00000040
    }
    [FlagsAttribute]
    private enum CDDS
    {
        CDDS_PREPAINT = 0x00000001,
        CDDS_POSTPAINT = 0x00000002,
        CDDS_PREERASE = 0x00000003,
        CDDS_POSTERASE = 0x00000004,
        CDDS_ITEM = 0x00010000,
        CDDS_ITEMPREPAINT = (CDDS_ITEM | CDDS_PREPAINT),
        CDDS_ITEMPOSTPAINT = (CDDS_ITEM | CDDS_POSTPAINT),
        CDDS_ITEMPREERASE = (CDDS_ITEM | CDDS_PREERASE),
        CDDS_ITEMPOSTERASE = (CDDS_ITEM | CDDS_POSTERASE),
        CDDS_SUBITEM = 0x00020000
    }
    public const int LVM_FIRST = 0x1000;
    public const int LVM_SETITEMSTATE = (LVM_FIRST + 43);
    public const int LVM_GETITEMSTATE = (LVM_FIRST + 44);
    public const int LVM_SETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 54);
    private const int NM_FIRST = 0;
    private const int NM_CLICK = (NM_FIRST - 2);
    private const int NM_DBLCLK = (NM_FIRST - 3);
    private const int NM_RETURN = (NM_FIRST - 4);
    private const int NM_RCLICK = (NM_FIRST - 5);
    private const int NM_RDBLCLK = (NM_FIRST - 6);
    private const int NM_SETFOCUS = (NM_FIRST - 7);
    private const int NM_KILLFOCUS = (NM_FIRST - 8);
    private const int NM_CUSTOMDRAW = (NM_FIRST - 12);
    private const int WM_REFLECT = 0x2000;
    private const int WM_NOFITY = 0x004e;
    private const int LVIS_FOCUSED = 0x0001;
    private const int LVIS_SELECTED = 0x0002;
    private const int LVIS_CUT = 0x0004;
    private const int LVIS_DROPHILITED = 0x0008;
    private const int LVIS_GLOW = 0x0010;
    private const int LVIS_ACTIVATING = 0x0020;
    private const int LVIS_OVERLAYMASK = 0x0F00;
    private const int LVIS_STATEIMAGEMASK = 0xF000;
    private static int INDEXTOSTATEIMAGEMASK(int i)
    {
        return ((i) << 12);
    }
    private const int LVS_EX_GRIDLINES = 0x00000001;
    private const int LVS_EX_FULLROWSELECT = 0x00000020; // applies to report mode only
    private const int LVS_EX_DOUBLEBUFFER = 0x00010000;
    [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    public static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, IntPtr lParam);
    [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    public static extern IntPtr GetFocus();
    public ListViewCustom()
    {
        this.FullRowSelect = true;
        //this.DoubleBuffered = true;
        //int nRet = SendMessage(this.Handle, LVM_SETEXTENDEDLISTVIEWSTYLE, 0, (IntPtr)LVS_EX_DOUBLEBUFFER);
    }
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_REFLECT + WM_NOFITY)
        {
            var pnmhdr = (NMHDR)m.GetLParam(typeof(NMHDR));
            if (pnmhdr.code == NM_CUSTOMDRAW)
            {
                var pnmlv = (NMLVCUSTOMDRAW)m.GetLParam(typeof(NMLVCUSTOMDRAW));
                switch (pnmlv.nmcd.dwDrawStage)
                {
                    case (int)CDDS.CDDS_PREPAINT:
                        m.Result = new IntPtr((int)CDRF.CDRF_NOTIFYITEMDRAW);
                        break;
                    case (int)CDDS.CDDS_ITEMPREPAINT:
                        m.Result = new IntPtr((int)(CDRF.CDRF_NOTIFYSUBITEMDRAW | CDRF.CDRF_NOTIFYPOSTPAINT));
                        break;
                    case (int)CDDS.CDDS_ITEMPOSTPAINT:
                        int nItem = (int)pnmlv.nmcd.dwItemSpec;
                        bool bListViewFocus = (GetFocus() == pnmhdr.hwndFrom);
                        if (nItem != -1)
                        {
                            Color textColor, backColor;
                            if (this.Items[(int)pnmlv.nmcd.dwItemSpec].Selected == true && bListViewFocus)
                            {
                                textColor = SystemColors.HighlightText; // GetSysColor(COLOR_HIGHLIGHTTEXT);
                                backColor = SystemColors.Highlight; // COLOR_HIGHLIGHT
                            }
                            else if (this.Items[(int)pnmlv.nmcd.dwItemSpec].Selected == true && !this.HideSelection)
                            {
                                textColor = SystemColors.WindowText; // GetSysColor(COLOR_BTNTEXT);
                                backColor = SystemColors.ButtonFace; // COLOR_BTNFACE;
                            }
                            else
                            {
                                textColor = Color.Blue;
                                backColor = SystemColors.Window; // COLOR_WINDOW;
                            }

                            int nCol = 0;
                            Rectangle rectFirstCol = new Rectangle(0, 0, 0, 0);
                            foreach (ListViewItem.ListViewSubItem subitem in this.Items[nItem].SubItems)
                            {
                                if (nCol == 1)
                                {
                                    rectFirstCol = new Rectangle(0, subitem.Bounds.Top, subitem.Bounds.Left, subitem.Bounds.Bottom - subitem.Bounds.Top);
                                    break;
                                }
                                nCol++;
                            }

                            string sText = this.Items[nItem].SubItems[0].Text;
                            //using (Font font = new Font("Arial", 10, System.Drawing.FontStyle.Regular, GraphicsUnit.Point))
                            {
                                TextFormatFlags flags = TextFormatFlags.Right | TextFormatFlags.WordBreak;
                                using (Graphics gr = Graphics.FromHdc(pnmlv.nmcd.hdc))
                                {
                                    using (Brush brush = new SolidBrush(backColor))
                                    {
                                        gr.FillRectangle(brush, rectFirstCol);
                                        //TextRenderer.DrawText(gr, sText, font, rectFirstCol, textColor, flags);
                                        TextRenderer.DrawText(gr, sText, this.Font, rectFirstCol, textColor, flags);
                                    }
                                }
                            }

                        }
                        m.Result = new IntPtr(1);
                        break;
                }
                return;
            }
            return;
        }
        else
            base.WndProc(ref m);
    }
}