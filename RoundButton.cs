using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace EasyTasks
{
    public partial class RoundButton : Button
    {
        private int roundedRadius = 10;
        [ Category("Appearance"), Description("The radius of the rounded corners")]
        public int RoundedRadius
        {
            get { return roundedRadius; }
            set { roundedRadius = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle Rect = new Rectangle(0, 0, Width-1, Height-1);
            GraphicsPath GraphPath = new GraphicsPath();

            //Starting angles are CLOCKWISE in these functions, but the difference in angles is COUNTER-CLOCKWISE
            //(who the hell knows why, good job Microsoft)
            GraphPath.AddArc(Rect.X, Rect.Y, roundedRadius, roundedRadius, 180, 90); //top left corner
            GraphPath.AddArc(Rect.X + Rect.Width - roundedRadius - 1, Rect.Y, roundedRadius + 2, roundedRadius + 1, 270, 90); //top right corner
            GraphPath.AddArc(Rect.X + Rect.Width - roundedRadius -1, Rect.Y + Rect.Height - roundedRadius -1, roundedRadius + 1, roundedRadius + 1, 0, 90); //bottom right corner
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - roundedRadius, roundedRadius + 2, roundedRadius + 1, 90, 90); //bottom left corner
            Region = new Region(GraphPath);


            base.OnPaint(e);
        }
    }
}
