using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing3
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Return values
        public int particleValue = 300;
        public int gravRadiusValue = 300;
        public int gravStrengthValue = 300;

        // Base
        private void Settings_Load(object sender, EventArgs e)
        {
            ParticlesTextBox.Text = particleValue.ToString();
            GravRadTextBox.Text = gravRadiusValue.ToString();
            GravStrTextBox.Text = gravStrengthValue.ToString();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            particleValue = Convert.ToInt32(ParticlesTextBox.Text);
            gravRadiusValue = Convert.ToInt32(GravRadTextBox.Text);
            gravStrengthValue = Convert.ToInt32(GravStrTextBox.Text);

            this.Close();
        }

        // Functions
        private string ReviseInput(string input)
        {
            string inputToRevise = input;

            for (int i = 0; i < inputToRevise.Length; i++)
            {

            }

            return " ";
        }
    }
}
