namespace Drawing3
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
            drawTimer = new System.Windows.Forms.Timer(components);
            garbageTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // drawTimer
            // 
            drawTimer.Enabled = true;
            drawTimer.Interval = 20;
            drawTimer.Tick += drawTimer_Tick;
            // 
            // garbageTimer
            // 
            garbageTimer.Enabled = true;
            garbageTimer.Interval = 5000;
            garbageTimer.Tick += garbageTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(349, 339);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Particles Program";
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Timer garbageTimer;
    }
}
