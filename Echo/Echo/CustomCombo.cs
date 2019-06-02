using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo
{
    class CustomCombo : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(this.ForeColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        
                        //g.DrawLine(p, Width - buttonWidth, 0, Width - buttonWidth, Height);

                    }
                    

                    using (SolidBrush brushRect = new SolidBrush(this.BackColor))
                    {
                        g.FillRectangle(brushRect, 0, 0, Width - 1, Height - 1);

                        //g.DrawIcon
                    }


                    using (SolidBrush brushTrian = new SolidBrush(Color.Black))
                    {
                        var p = new Pen(this.ForeColor);
                        Point[] trianglePoints = { new Point(0, 0), new Point(20, -1), new Point(Width, Height) };
                        //g.FillPolygon(brushTrian, trianglePoints);
                        g.DrawRectangle(p, 0, 0, 15, 15);
                        g.FillRectangle(brushTrian, 0, 0, 15, 15);
                    }


                }
            }
        }

    }
}
