
namespace SuperHraSMilionemRozlicnychNepratelKtereMusimePorazit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            canvas1 = new Canvas();
            timer1 = new System.Windows.Forms.Timer(components);
            enemiesCountLabel = new Label();
            bar1 = new Bar();
            SuspendLayout();
            // 
            // canvas1
            // 
            canvas1.BackColor = Color.White;
            canvas1.BorderStyle = BorderStyle.FixedSingle;
            canvas1.Location = new Point(12, 82);
            canvas1.Name = "canvas1";
            canvas1.Size = new Size(1494, 1069);
            canvas1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // enemiesCountLabel
            // 
            enemiesCountLabel.AutoSize = true;
            enemiesCountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemiesCountLabel.Location = new Point(619, 9);
            enemiesCountLabel.Name = "enemiesCountLabel";
            enemiesCountLabel.Size = new Size(39, 48);
            enemiesCountLabel.TabIndex = 1;
            enemiesCountLabel.Text = "0";
            // 
            // bar1
            // 
            bar1.BackColor = Color.Black;
            bar1.Location = new Point(12, 17);
            bar1.MaxValue = 100;
            bar1.Name = "bar1";
            bar1.Size = new Size(550, 40);
            bar1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 1163);
            Controls.Add(bar1);
            Controls.Add(enemiesCountLabel);
            Controls.Add(canvas1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Canvas canvas1;
        private System.Windows.Forms.Timer timer1;
        private Label enemiesCountLabel;
        private Bar bar1;
    }
}
