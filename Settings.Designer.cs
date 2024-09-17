namespace Drawing3
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConfirmButton = new Button();
            ParticleLabel = new Label();
            ParticlesTextBox = new TextBox();
            GravRadTextBox = new TextBox();
            GravRadLabel = new Label();
            GravStrTextBox = new TextBox();
            GravStrLabel = new Label();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(121, 178);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(95, 29);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ParticleLabel
            // 
            ParticleLabel.AutoSize = true;
            ParticleLabel.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ParticleLabel.Location = new Point(12, 27);
            ParticleLabel.Name = "ParticleLabel";
            ParticleLabel.Size = new Size(88, 18);
            ParticleLabel.TabIndex = 1;
            ParticleLabel.Text = "Particles:";
            // 
            // ParticlesTextBox
            // 
            ParticlesTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ParticlesTextBox.Location = new Point(138, 22);
            ParticlesTextBox.Name = "ParticlesTextBox";
            ParticlesTextBox.Size = new Size(174, 27);
            ParticlesTextBox.TabIndex = 3;
            // 
            // GravRadTextBox
            // 
            GravRadTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GravRadTextBox.Location = new Point(138, 68);
            GravRadTextBox.Name = "GravRadTextBox";
            GravRadTextBox.Size = new Size(174, 27);
            GravRadTextBox.TabIndex = 5;
            // 
            // GravRadLabel
            // 
            GravRadLabel.AutoSize = true;
            GravRadLabel.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GravRadLabel.Location = new Point(12, 73);
            GravRadLabel.Name = "GravRadLabel";
            GravRadLabel.Size = new Size(104, 18);
            GravRadLabel.TabIndex = 4;
            GravRadLabel.Text = "Grav Radius:";
            // 
            // GravStrTextBox
            // 
            GravStrTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GravStrTextBox.Location = new Point(138, 111);
            GravStrTextBox.Name = "GravStrTextBox";
            GravStrTextBox.Size = new Size(174, 27);
            GravStrTextBox.TabIndex = 7;
            // 
            // GravStrLabel
            // 
            GravStrLabel.AutoSize = true;
            GravStrLabel.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GravStrLabel.Location = new Point(12, 116);
            GravStrLabel.Name = "GravStrLabel";
            GravStrLabel.Size = new Size(120, 18);
            GravStrLabel.TabIndex = 6;
            GravStrLabel.Text = "Grav Strength:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 219);
            Controls.Add(GravStrTextBox);
            Controls.Add(GravStrLabel);
            Controls.Add(GravRadTextBox);
            Controls.Add(GravRadLabel);
            Controls.Add(ParticlesTextBox);
            Controls.Add(ParticleLabel);
            Controls.Add(ConfirmButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Settings";
            Text = "Inputs";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmButton;
        private Label ParticleLabel;
        private TextBox ParticlesTextBox;
        private TextBox GravRadTextBox;
        private Label GravRadLabel;
        private TextBox GravStrTextBox;
        private Label GravStrLabel;
    }
}