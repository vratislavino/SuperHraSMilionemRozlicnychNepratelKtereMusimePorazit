using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit
{
    public partial class Canvas : UserControl
    {
        List<Shape> shapes = new List<Shape>();

        public Canvas()
        {
            InitializeComponent();
        }

        public void AddShape(Shape newShape)
        {
            shapes.Add(newShape);
            Invalidate();
            newShape.OnDied += OnShapeDied;
        }

        private void OnShapeDied(Shape shape)
        {
            shapes.Remove(shape);
            Invalidate();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {

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
