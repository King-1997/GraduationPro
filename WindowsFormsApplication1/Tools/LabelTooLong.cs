using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tools
{
    class LabelTooLong
    {
        private void showDot(System.Windows.Forms.Label label)
        {
            Graphics graphics = CreateGraphics();
            string label_str = label.Text;
            string str = label_str;
            SizeF sizeF = graphics.MeasureString(label_str, label.Font);
            while (sizeF.Width >= label.Width - 10)
            {
                str = label_str.Substring(0, str.Length - 1);
                sizeF = graphics.MeasureString(str, label.Font);
                label.Text = str + "...";
            }
        }

        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
