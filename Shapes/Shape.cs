using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public abstract class Shape
    {
        public event Action<Shape> OnDied;

        protected int x;
        protected int y;
        protected int width;
        protected int height;

        protected int lives;
        protected bool doesDamage = true;

        protected Color color;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;

            lives = 1;
        }

        public abstract void Draw(Graphics g);

        public virtual bool IsMouseOver(int mx, int my)
        {
            return 
                mx >= x && 
                mx <= x + width && 
                my >= y && 
                my <= y + height;
        }

        public abstract void DoYourThing(int mx, int my, bool isLeftButton);

        protected void TakeDamage()
        {
            lives--;
            if(lives <= 0)
                OnDied?.Invoke(this);
        }

    }
}
