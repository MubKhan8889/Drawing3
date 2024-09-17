using Microsoft.VisualBasic.Devices;
using System.Numerics;
using System.Security.Policy;

namespace Drawing3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Misc
        List<Particle> particlesList = new List<Particle>();
        Settings settingForm;

        // Variables
        short radius = 100;
        short gravity = 5;

        short particles = 300;

        short initialPosition = 200;
        short initialVelocity = 100;

        // Mouse Variables
        bool mouseHeld = false;

        byte mouseHeldDown = 0;
        short mouseXPosition = 0;
        short mouseYPosition = 0;

        byte mouseDrawFadeSpeed = 5;

        // Base
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadParticles();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.Black);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Draw mouse gravity
            if (mouseHeldDown > 5)
            {
                Brush greyCircle = new SolidBrush(Color.Gray);

                int calculateSize = (int)(Math.Sin(mouseHeldDown * Math.PI / 510f) * radius);
                g.FillEllipse(greyCircle, mouseXPosition - calculateSize, mouseYPosition - calculateSize, calculateSize * 2, calculateSize * 2);
            }

            // Write Info
            Brush whiteText = new SolidBrush(Color.WhiteSmoke);
            Font writeFont = new Font(FontFamily.GenericMonospace, 12);

            PointF particlesTextPoint = new PointF(10f, this.Height - 116f);
            PointF radiusTextPoint = new PointF(10f, this.Height - 87f);
            PointF gravityTextPoint = new PointF(10f, this.Height - 72f);

            g.DrawString($"Particles: {particles}", writeFont, whiteText, particlesTextPoint);
            g.DrawString($"Gravity Radius: {radius}", writeFont, whiteText, radiusTextPoint);
            g.DrawString($"Gravity Strength: {gravity}", writeFont, whiteText, gravityTextPoint);

            // Draw particles
            foreach (Particle particle in particlesList) { particle.DrawParticle(g, this.Size); }
        }

        // Timers
        private void drawTimer_Tick(object sender, EventArgs e)
        {
            float delta = drawTimer.Interval / 1000f;
            foreach (Particle particle in particlesList)
            {
                if (mouseHeld == true) particle.ChangeVelocityBasedOnMousePos(delta, new Point(mouseXPosition, mouseYPosition), this.Size, gravity, radius);
                particle.ParticleMove(delta, this.Size);
            }

            if (mouseHeld == true)
            {
                Point screenPos = this.PointToClient(Cursor.Position);

                mouseXPosition = (short)screenPos.X;
                mouseYPosition = (short)screenPos.Y;
            }

            int mouseHeldMult = (mouseHeld == true) ? 1 : -1;
            mouseHeldDown = (byte)Math.Clamp(mouseHeldDown + (delta * 255 * mouseDrawFadeSpeed * mouseHeldMult), 0, 255);

            Invalidate();
        }

        private void garbageTimer_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        // Mouse Input
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseHeld = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach (Particle particle in particlesList)
                {
                    particle.SetRandomPosition(initialPosition);
                    particle.SetRandomVelocity(initialVelocity);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mouseHeld = false;
        }

        // Keyboard Input
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (settingForm != null) return;

                settingForm = new Settings();

                settingForm.particleValue = particles;
                settingForm.gravRadiusValue = radius;
                settingForm.gravStrengthValue = gravity;

                settingForm.Activate();
                settingForm.Visible = true;

                settingForm.FormClosed += SettingsFormClose;
            }
        }

        // Functions
        private void SettingsFormClose(object sender, FormClosedEventArgs e)
        {
            particles = (short)settingForm.particleValue;
            radius = (short)settingForm.gravRadiusValue;
            gravity = (short)settingForm.gravStrengthValue;

            settingForm.Dispose();
            settingForm = null;

            LoadParticles();
        }

        private void LoadParticles()
        {
            particlesList.Clear();

            for (int i = 0; i < particles; i++)
            {
                particlesList.Add(new Particle(initialPosition, initialVelocity));
            }
        }
    }
}
