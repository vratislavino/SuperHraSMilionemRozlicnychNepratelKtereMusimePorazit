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
    public partial class Bar : UserControl
    {
        public event Action DroppedToZero;

        public int MaxValue { get; set; } = 100;
        private int currentValue = 50;

        public Bar()
        {
            InitializeComponent();
            currentValue = MaxValue;
        }

        public void Reduce(int amount)
        {
            currentValue -= amount;
            if(currentValue <= 0)
            {
                currentValue = 0;
                DroppedToZero?.Invoke();
            }
            UpdateValue();
        }

        private void UpdateValue()
        {
            var perc = (float)currentValue / MaxValue;
            panel1.Size = new Size(
                (int)(Width * perc),
                Height
                );
        }

        private void Bar_SizeChanged(object sender, EventArgs e)
        {
            UpdateValue();
        }
    }
}
