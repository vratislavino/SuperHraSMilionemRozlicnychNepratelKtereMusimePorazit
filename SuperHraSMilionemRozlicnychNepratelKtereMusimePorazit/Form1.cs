using SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit;
using SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies;
using System;
using System.Reflection;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit
{
    public partial class Form1 : Form
    {
        List<Type> shapeTypes = new List<Type>();

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            canvas1.ShapesCountChanged += Canvas1_ShapesCountChanged;
            bar1.DroppedToZero += Bar1_DroppedToZero;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var types = LoadShapeTypesFromAssembly(Assembly.GetExecutingAssembly());
            shapeTypes.AddRange(types);
        }

        private List<Type> LoadShapeTypesFromAssembly(Assembly ass)
        {
            var types = ass.GetTypes().ToList();
            types = types.Where(t => t.IsAssignableTo(typeof(Shape))).ToList();
            types.Remove(typeof(Shape));
            return types;
        }

        private void Bar1_DroppedToZero()
        {
            timer1.Stop();
            MessageBox.Show("You lost!");
        }

        private void Canvas1_ShapesCountChanged()
        {
            enemiesCountLabel.Text = $"Enemies: {canvas1.ShapesCount}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bar1.Reduce(canvas1.ShapesCount);

            var newShape = CreateShape();
            canvas1.AddShape(newShape);
        }

        private Shape CreateShape()
        {
            int index = random.Next(0, shapeTypes.Count);
            Type t = shapeTypes[index];
            var shape = 
                Activator.CreateInstance(
                    t, 
                    random.Next(0, canvas1.Width), 
                    random.Next(0, canvas1.Height)) 
                as Shape;
            return shape;
        }
    }
}