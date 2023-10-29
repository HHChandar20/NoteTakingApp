namespace NoteTakingApp.PL.Views
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelMenu = new Panel();
            deleteNoteButton = new FontAwesome.Sharp.IconButton();
            addNoteButton = new FontAwesome.Sharp.IconButton();
            favouritesButton = new FontAwesome.Sharp.IconButton();
            myNotesButton = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            logo = new PictureBox();
            panelTitleBar = new Panel();
            navbarLabel = new Label();
            navbarIcon = new FontAwesome.Sharp.IconPictureBox();
            panelNavbarShadow = new Panel();
            panelCurrentMenu = new Panel();
            panelMenuShadow = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navbarIcon).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(21, 21, 21);
            panelMenu.Controls.Add(deleteNoteButton);
            panelMenu.Controls.Add(addNoteButton);
            panelMenu.Controls.Add(favouritesButton);
            panelMenu.Controls.Add(myNotesButton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 5, 4, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(314, 804);
            panelMenu.TabIndex = 1;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.Dock = DockStyle.Top;
            deleteNoteButton.FlatAppearance.BorderSize = 0;
            deleteNoteButton.FlatStyle = FlatStyle.Flat;
            deleteNoteButton.ForeColor = Color.FromArgb(248, 161, 69);
            deleteNoteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            deleteNoteButton.IconColor = Color.FromArgb(248, 161, 69);
            deleteNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteNoteButton.IconSize = 32;
            deleteNoteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteNoteButton.Location = new Point(0, 533);
            deleteNoteButton.Margin = new Padding(4, 5, 4, 5);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Padding = new Padding(14, 0, 29, 0);
            deleteNoteButton.Size = new Size(314, 100);
            deleteNoteButton.TabIndex = 4;
            deleteNoteButton.Text = "Delete Note";
            deleteNoteButton.TextAlign = ContentAlignment.MiddleLeft;
            deleteNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteNoteButton.UseVisualStyleBackColor = true;
            deleteNoteButton.Click += deleteNoteButton_Click;
            // 
            // addNoteButton
            // 
            addNoteButton.Dock = DockStyle.Top;
            addNoteButton.FlatAppearance.BorderSize = 0;
            addNoteButton.FlatStyle = FlatStyle.Flat;
            addNoteButton.ForeColor = Color.FromArgb(248, 161, 69);
            addNoteButton.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            addNoteButton.IconColor = Color.FromArgb(248, 161, 69);
            addNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addNoteButton.IconSize = 32;
            addNoteButton.ImageAlign = ContentAlignment.MiddleLeft;
            addNoteButton.Location = new Point(0, 433);
            addNoteButton.Margin = new Padding(4, 5, 4, 5);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Padding = new Padding(14, 0, 29, 0);
            addNoteButton.Size = new Size(314, 100);
            addNoteButton.TabIndex = 3;
            addNoteButton.Text = "Add Note";
            addNoteButton.TextAlign = ContentAlignment.MiddleLeft;
            addNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // favouritesButton
            // 
            favouritesButton.Dock = DockStyle.Top;
            favouritesButton.FlatAppearance.BorderSize = 0;
            favouritesButton.FlatStyle = FlatStyle.Flat;
            favouritesButton.ForeColor = Color.FromArgb(248, 161, 69);
            favouritesButton.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
            favouritesButton.IconColor = Color.FromArgb(248, 161, 69);
            favouritesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            favouritesButton.IconSize = 32;
            favouritesButton.ImageAlign = ContentAlignment.MiddleLeft;
            favouritesButton.Location = new Point(0, 333);
            favouritesButton.Margin = new Padding(4, 5, 4, 5);
            favouritesButton.Name = "favouritesButton";
            favouritesButton.Padding = new Padding(14, 0, 29, 0);
            favouritesButton.Size = new Size(314, 100);
            favouritesButton.TabIndex = 2;
            favouritesButton.Text = "Favourites";
            favouritesButton.TextAlign = ContentAlignment.MiddleLeft;
            favouritesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            favouritesButton.UseVisualStyleBackColor = true;
            favouritesButton.Click += favouritesButton_Click;
            // 
            // myNotesButton
            // 
            myNotesButton.Dock = DockStyle.Top;
            myNotesButton.FlatAppearance.BorderSize = 0;
            myNotesButton.FlatStyle = FlatStyle.Flat;
            myNotesButton.ForeColor = Color.FromArgb(248, 161, 69);
            myNotesButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            myNotesButton.IconColor = Color.FromArgb(248, 161, 69);
            myNotesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            myNotesButton.IconSize = 32;
            myNotesButton.ImageAlign = ContentAlignment.MiddleLeft;
            myNotesButton.Location = new Point(0, 233);
            myNotesButton.Margin = new Padding(4, 5, 4, 5);
            myNotesButton.Name = "myNotesButton";
            myNotesButton.Padding = new Padding(14, 0, 29, 0);
            myNotesButton.Size = new Size(314, 100);
            myNotesButton.TabIndex = 1;
            myNotesButton.Text = "My Notes";
            myNotesButton.TextAlign = ContentAlignment.MiddleLeft;
            myNotesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            myNotesButton.UseVisualStyleBackColor = true;
            myNotesButton.Click += myNotesButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(logo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 5, 4, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(314, 233);
            panelLogo.TabIndex = 0;
            // 
            // logo
            // 
            logo.Cursor = Cursors.Hand;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(83, 35);
            logo.Margin = new Padding(4, 5, 4, 5);
            logo.Name = "logo";
            logo.Size = new Size(143, 167);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(21, 21, 21);
            panelTitleBar.Controls.Add(navbarLabel);
            panelTitleBar.Controls.Add(navbarIcon);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(314, 0);
            panelTitleBar.Margin = new Padding(4, 5, 4, 5);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(944, 117);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // navbarLabel
            // 
            navbarLabel.AutoSize = true;
            navbarLabel.ForeColor = Color.FromArgb(248, 161, 69);
            navbarLabel.Location = new Point(71, 48);
            navbarLabel.Margin = new Padding(4, 0, 4, 0);
            navbarLabel.Name = "navbarLabel";
            navbarLabel.Size = new Size(61, 25);
            navbarLabel.TabIndex = 1;
            navbarLabel.Text = "Home";
            // 
            // navbarIcon
            // 
            navbarIcon.BackColor = Color.FromArgb(21, 21, 21);
            navbarIcon.ForeColor = Color.FromArgb(248, 161, 69);
            navbarIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            navbarIcon.IconColor = Color.FromArgb(248, 161, 69);
            navbarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            navbarIcon.IconSize = 46;
            navbarIcon.Location = new Point(19, 33);
            navbarIcon.Margin = new Padding(4, 5, 4, 5);
            navbarIcon.Name = "navbarIcon";
            navbarIcon.Size = new Size(46, 53);
            navbarIcon.TabIndex = 0;
            navbarIcon.TabStop = false;
            // 
            // panelNavbarShadow
            // 
            panelNavbarShadow.BackColor = Color.FromArgb(70, 70, 70);
            panelNavbarShadow.Dock = DockStyle.Top;
            panelNavbarShadow.Location = new Point(314, 117);
            panelNavbarShadow.Margin = new Padding(4, 5, 4, 5);
            panelNavbarShadow.Name = "panelNavbarShadow";
            panelNavbarShadow.Size = new Size(944, 10);
            panelNavbarShadow.TabIndex = 3;
            // 
            // panelCurrentMenu
            // 
            panelCurrentMenu.BackColor = Color.FromArgb(190, 190, 190);
            panelCurrentMenu.Dock = DockStyle.Fill;
            panelCurrentMenu.Location = new Point(314, 127);
            panelCurrentMenu.Margin = new Padding(4, 5, 4, 5);
            panelCurrentMenu.Name = "panelCurrentMenu";
            panelCurrentMenu.Size = new Size(944, 677);
            panelCurrentMenu.TabIndex = 4;
            // 
            // panelMenuShadow
            // 
            panelMenuShadow.BackColor = Color.FromArgb(70, 70, 70);
            panelMenuShadow.Dock = DockStyle.Left;
            panelMenuShadow.Location = new Point(314, 127);
            panelMenuShadow.Margin = new Padding(4, 5, 4, 5);
            panelMenuShadow.Name = "panelMenuShadow";
            panelMenuShadow.Size = new Size(9, 677);
            panelMenuShadow.TabIndex = 5;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 804);
            Controls.Add(panelMenuShadow);
            Controls.Add(panelCurrentMenu);
            Controls.Add(panelNavbarShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMenu";
            Text = "Note Taking App";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)navbarIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton deleteNoteButton;
        private FontAwesome.Sharp.IconButton addNoteButton;
        private FontAwesome.Sharp.IconButton favouritesButton;
        private FontAwesome.Sharp.IconButton myNotesButton;
        private Panel panelLogo;
        private PictureBox logo;
        private Panel panelTitleBar;
        private Label navbarLabel;
        private FontAwesome.Sharp.IconPictureBox navbarIcon;
        private Panel panelNavbarShadow;
        private Panel panelCurrentMenu;
        private Panel panelMenuShadow;
    }
}