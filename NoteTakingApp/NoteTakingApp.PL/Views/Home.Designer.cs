namespace NoteTakingApp.PL.Views
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            timerClock = new System.Windows.Forms.Timer(components);
            labelClock = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // labelClock
            // 
            labelClock.Anchor = AnchorStyles.None;
            labelClock.AutoSize = true;
            labelClock.Font = new Font("Agency FB", 108F, FontStyle.Regular, GraphicsUnit.Point);
            labelClock.ForeColor = Color.FromArgb(248, 161, 69);
            labelClock.Location = new Point(204, 0);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(546, 170);
            labelClock.TabIndex = 0;
            labelClock.Text = "9:31:34 AM";
            // 
            // logo
            // 
            logo.Dock = DockStyle.Fill;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(929, 180);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 276);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(logo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 180);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelClock);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 456);
            panel3.Name = "panel3";
            panel3.Size = new Size(929, 217);
            panel3.TabIndex = 5;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 90, 90);
            ClientSize = new Size(929, 509);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerClock;
        private PictureBox logo;
        private Label labelClock;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}