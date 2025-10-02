using SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            canvas1.ShapesCountChanged += Canvas1_ShapesCountChanged;
            bar1.DroppedToZero += Bar1_DroppedToZero;
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

            canvas1.AddShape(
                new StupidLittleCircle(
                    random.Next(0, canvas1.Width),
                    random.Next(0, canvas1.Height)
                    )
                );
        }
    }
}
