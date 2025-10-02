using SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit.Enemies;

namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas1.AddShape(
                new StupidLittleCircle(
                    random.Next(0, canvas1.Width),
                    random.Next(0, canvas1.Height)
                    )
                );
        }
    }
}
