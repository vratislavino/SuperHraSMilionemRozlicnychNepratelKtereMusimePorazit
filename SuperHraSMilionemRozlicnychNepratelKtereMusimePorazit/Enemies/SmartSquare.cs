using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies
{
    public class SmartSquare : Shape
    {
        private static Pen outline = new Pen(Color.Black, 4f);
        bool[,] squares = new bool[2, 2];
        int squareSize;

        public SmartSquare(int x, int y) : base(x, y)
        {
            width = height = 80;
            squareSize = width / 2;
            lives = 4;
        }

        public override void DoYourThing(int mx, int my, bool isLeftButton)
        {
            if (!isLeftButton) return;
            int i = (mx - x)/squareSize;
            int j = (my - y)/squareSize;
            
            if(i >= squares.GetLength(0))
                i = squares.GetLength(0) - 1;

            j = Math.Min(j, squares.GetLength(0) - 1);

            if (!squares[i,j])
            {
                squares[i, j] = true;
                TakeDamage();
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(outline, x, y, width, height);
            g.DrawLine(outline, x + width / 2, y, x + width / 2, y + height);
            g.DrawLine(outline, x, y + height / 2, x + width, y + height / 2);
        
            for(int i = 0; i < squares.GetLength(0); i++)
            {
                for(int j = 0; j < squares.GetLength(1); j++)
                {
                    if (squares[i,j])
                    {
                        g.FillRectangle(Brushes.Red, 
                            x + i * squareSize, 
                            y + j * squareSize,
                            squareSize,
                            squareSize);
                    }
                }
            }
        }
    }
}
