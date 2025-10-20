using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies
{
    public class Pizza : Shape
    {
        static Brush brush = Brushes.Chocolate;
        List<int> angles = new List<int> { 0, 90, 180, 270};
        int currentAngle;
        public Pizza(int x, int y) : base(x, y)
        {
            width = height = 90;
            lives = 4;
            ReplaceSlice();
        }

        private void ReplaceSlice()
        {
            int index  = new Random().Next(0, angles.Count);
            currentAngle = angles[index];
            angles.RemoveAt(index);
        }

        public override bool IsMouseOver(int mx, int my)
        {
            int sx = x + width / 2;
            int sy = y + height / 2;

            bool isInside = Math.Sqrt((my - sy) * (my - sy) + (mx - sx) * (mx - sx)) <= width / 2;
            if (!isInside) return false;
            double angle = Math.Atan2(my - sy, mx - sx) * 180 / Math.PI;
            angle = (angle + 360) % 360;


            if(angle > angles[currentAngle] && angle < angles[currentAngle] + 90)
            {
                return true;
            }

            return false;
        }

        public override void DoYourThing(int mx, int my, bool isLeftButton)
        {

            ReplaceSlice();
            TakeDamage();
        }

        public override void Draw(Graphics g)
        {
            g.FillPie(brush, x, y, width, height, angles[currentAngle], 90);
        }
    }
}
