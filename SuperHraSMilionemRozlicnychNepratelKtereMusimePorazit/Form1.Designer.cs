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
            SuspendLayout();
            // 
            // canvas1
            // 
            canvas1.BackColor = Color.White;
            canvas1.BorderStyle = BorderStyle.FixedSingle;
            canvas1.Location = new Point(12, 61);
            canvas1.Name = "canvas1";
            canvas1.Size = new Size(1494, 1090);
            canvas1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 1163);
            Controls.Add(canvas1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Canvas canvas1;
        private System.Windows.Forms.Timer timer1;
    }
}
