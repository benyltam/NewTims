using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    using System;

    public class Lib
    {
        public string String(string v1, int v2)
        {
            try
            {
                return string.Join("", System.Linq.Enumerable.Repeat(v1, v2));
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public string Item(string Str, int ItemIndex, string Seperator)
        {
            int i = 1;
            int seperatorCount = Str.Length - Str.Replace(Seperator, "").Length;
            if (ItemIndex > seperatorCount - 1)
                Str = "";
            else
            {
                int p1;
                do
                {
                    if (i == ItemIndex)
                        break;
                    p1 = Str.IndexOf(Seperator);
                    if (p1 == -1)
                        break;
                    else
                        Str = Str.Substring(p1 + 1);
                    i++;
                }
                while (true);
                p1 = Str.IndexOf(Seperator);
                if (p1 != -1)
                    Str = Str.Substring(0, p1);
            }
            return Str;
        }

        public int ItemCount(string Str, string Seperator)      //issue: ItemCount("a/bb//")
        {
            int seperatorCount = 0;
            if (Str.Contains(Seperator))
            {
                seperatorCount = Str.Length - Str.Replace(Seperator, "").Length;

            }
            return seperatorCount ;
        }

        public string Inside(string str, string leftquote, string rightquote)
        {
            var x = str.IndexOf(leftquote);
            var y = str.IndexOf(rightquote, x + leftquote.Length);
            return str.Substring(x + leftquote.Length, y - x - leftquote.Length);
        }

        public void RestoreCtrlSize()
        {

        }

        public void ResizeCtrl(string str, ref int parentHeight, int parentDefaultHeight, ref int parentWidth, int parentDefaultWidth,
            ref int height, ref int width, ref int top, ref int left,
            int defaultHeight, int defaultWidth, int defaultTop, int defaultLeft)
        {
            str += "*";
            decimal ratio;
            //object oCon = parent;
            string c;
            do
            {
                c = str.Substring(0, 1);
                if (c == "*") goto End;
                if ("HWRBMC".IndexOf(c) > -1)
                    if (str.Substring(1, 1) == "(")
                    {
                        string s_numerator = str.Substring(str.IndexOf(c + '(') + 2, str.IndexOf('/') - str.IndexOf(c + '(') - 2);
                        string s_denominator = str.Substring(str.IndexOf('/') + 1, str.IndexOf(')') - str.IndexOf('/') - 1);
                        ratio = decimal.Parse(s_numerator) / decimal.Parse(s_denominator);
                        if (c == "H")   //height expand/contract
                            height += defaultHeight + (int)((decimal)(parentHeight - parentDefaultHeight) * 1000 * ratio) / 1000;

                        if (c == "B")   //bottom align
                            top += defaultTop + (int)((decimal)(parentHeight - parentDefaultHeight) * 1000 * ratio) / 1000;

                        if (c == "M")   //keep in middle
                            top += defaultHeight + (int)((decimal)(parentHeight - parentDefaultHeight) * 1000 * ratio) / 1000 / 2;

                        if (c == "W")   //width expand/contract
                            width += defaultWidth + (int)((decimal)(parentWidth - parentDefaultWidth) * 1000 * ratio) / 1000;

                        if (c == "R")   //right align
                            left += defaultLeft + (int)((decimal)(parentWidth - parentDefaultWidth) * 1000 * ratio) / 1000;

                        if (c == "C")   //horizontally keep center
                            left += defaultLeft + (int)((decimal)(parentWidth - parentDefaultWidth) * 1000 * ratio) / 1000 / 2;

                        str = str.Substring(str.IndexOf(")") + 1);
                    }
                    else
                    {
                        str = str.Substring(1);
                    }
            }
            while (true);
        End:;
        }
    }



}
