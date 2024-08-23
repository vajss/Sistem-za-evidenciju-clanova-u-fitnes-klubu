using Server.Custom_UI_components;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Server
{
    public class ToggleButton : Button
    {
        public int buttonRadius = 10;
       
        public int ButtonRadius
        {
            get
            {
                return buttonRadius;
            }
            set
            {
                buttonRadius = value < 0 ? 0 : value;
            }
        }

        public ToggleStateEnum toggleState = ToggleStateEnum.OFF;

        public ToggleStateEnum ToggleState
        {
            get
            {
                return toggleState;
            }
            set
            {
                toggleState = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, buttonRadius))
            {
                Region = new Region(GraphPath);
                using (Pen pen = new Pen(SystemColors.Control, 0))
                {
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 90, 180);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 270, 180);
            GraphPath.CloseFigure();
            return GraphPath;
        }

    }
}