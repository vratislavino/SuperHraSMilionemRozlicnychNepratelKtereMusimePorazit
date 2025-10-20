using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies
{
    public class StupidLittleCircle : Shape
    {
        private Brush ColorBrush;
        private static Pen outline = new Pen(Color.DarkBlue, 3f);
        public StupidLittleCircle(int x, int y) : base(x, y)
        {
            ColorBrush = Brushes.SkyBlue;
            width = 50;
            height = 50;
        }

        public override void DoYourThing(int mx, int my, bool isLeftButton)
        {
            TakeDamage();
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(ColorBrush, x, y, width, height);
            g.DrawEllipse(outline, x, y, width, height);
        }
    }
}
