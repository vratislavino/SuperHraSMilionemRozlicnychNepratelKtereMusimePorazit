using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shapes;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit
{
    public partial class Canvas : UserControl
    {
        public event Action ShapesCountChanged;

        public int ShapesCount => shapes.Count;

        List<Shape> shapes = new List<Shape>();

        public Canvas()
        {
            InitializeComponent();
        }

        public void AddShape(Shape newShape)
        {
            shapes.Add(newShape);
            ShapesCountChanged?.Invoke();
            Invalidate();
            newShape.OnDied += OnShapeDied;
        }

        private void OnShapeDied(Shape shape)
        {
            shapes.Remove(shape);
            ShapesCountChanged?.Invoke();
            Invalidate();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (shapes.Count == 0) return;
            foreach(var shape in shapes)
            {
                if(shape.IsMouseOver(e.X, e.Y))
                {
                    shape.DoYourThing(e.X, e.Y, e.Button == MouseButtons.Left);
                    break;
                }
            }
            Invalidate();

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (shapes.Count == 0) return;

            e.Graphics.SmoothingMode = 
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            shapes.ForEach(s => s.Draw(e.Graphics));
        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }
    }
}
