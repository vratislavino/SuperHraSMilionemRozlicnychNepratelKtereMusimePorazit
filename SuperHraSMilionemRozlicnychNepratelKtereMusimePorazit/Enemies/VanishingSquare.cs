
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies
{
    public class VanishingSquare : Shape
    {
        private Brush[] brushes = new Brush[] { 
            new SolidBrush(Color.FromArgb(215, 195, 235)),
            new SolidBrush(Color.FromArgb(177, 134, 209)),
            new SolidBrush(Color.FromArgb(128, 70, 180)),
        };
        private static Pen outline = new Pen(Color.Purple, 3f);

        private int refPointX;
        private int refPointY;
        private int range = 120;

        public VanishingSquare(int x, int y) : base(x, y)
        {
            refPointX = x;
            refPointY = y;
            width = height = 40;
            lives = 3;
        }

        private void Replace()
        {
            Random r = new Random();
            x = r.Next(refPointX-range, refPointX+range);
            y = r.Next(refPointY-range, refPointY+range);
        }

        public override void DoYourThing(int mx, int my, bool isLeftButton)
        {
            TakeDamage();
            Replace();
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(brushes[lives-1], x, y, width, height);
            g.DrawRectangle(outline, x, y, width, height);
        }
    }
}
