using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies
{
    public class StupidLittleCircle : Shape
    {
        private Brush ColorBrush;

        public StupidLittleCircle(int x, int y) : base(x, y)
        {
            ColorBrush = Brushes.Blue;
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
        }
    }
}
