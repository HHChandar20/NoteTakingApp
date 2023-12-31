﻿namespace NoteTakingApp.PL.Views
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
            minimizeButton = new FontAwesome.Sharp.IconButton();
            resizeButton = new FontAwesome.Sharp.IconButton();
            exitButton = new FontAwesome.Sharp.IconButton();
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
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 911);
            panelMenu.TabIndex = 1;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.Dock = DockStyle.Top;
            deleteNoteButton.FlatAppearance.BorderSize = 0;
            deleteNoteButton.FlatStyle = FlatStyle.Flat;
            deleteNoteButton.ForeColor = Color.FromArgb(248, 161, 69);
            deleteNoteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            deleteNoteButton.IconColor = Color.FromArgb(248, 161, 69);
            deleteNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteNoteButton.IconSize = 32;
            deleteNoteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteNoteButton.Location = new Point(0, 320);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Padding = new Padding(10, 0, 20, 0);
            deleteNoteButton.Size = new Size(220, 60);
            deleteNoteButton.TabIndex = 4;
            deleteNoteButton.Text = "Deleted Notes";
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
            addNoteButton.Location = new Point(0, 260);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Padding = new Padding(10, 0, 20, 0);
            addNoteButton.Size = new Size(220, 60);
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
            favouritesButton.Location = new Point(0, 200);
            favouritesButton.Name = "favouritesButton";
            favouritesButton.Padding = new Padding(10, 0, 20, 0);
            favouritesButton.Size = new Size(220, 60);
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
            myNotesButton.Location = new Point(0, 140);
            myNotesButton.Name = "myNotesButton";
            myNotesButton.Padding = new Padding(10, 0, 20, 0);
            myNotesButton.Size = new Size(220, 60);
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // logo
            // 
            logo.Cursor = Cursors.Hand;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(58, 21);
            logo.Name = "logo";
            logo.Size = new Size(100, 100);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(21, 21, 21);
            panelTitleBar.Controls.Add(minimizeButton);
            panelTitleBar.Controls.Add(resizeButton);
            panelTitleBar.Controls.Add(exitButton);
            panelTitleBar.Controls.Add(navbarLabel);
            panelTitleBar.Controls.Add(navbarIcon);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(764, 70);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.BackColor = SystemColors.ButtonFace;
            minimizeButton.FlatStyle = FlatStyle.Popup;
            minimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            minimizeButton.IconColor = Color.Black;
            minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeButton.IconSize = 20;
            minimizeButton.ImageAlign = ContentAlignment.TopCenter;
            minimizeButton.Location = new Point(637, 9);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Padding = new Padding(3, 0, 0, 0);
            minimizeButton.Size = new Size(34, 24);
            minimizeButton.TabIndex = 4;
            minimizeButton.TabStop = false;
            minimizeButton.TextAlign = ContentAlignment.TopLeft;
            minimizeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // resizeButton
            // 
            resizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resizeButton.BackColor = SystemColors.ButtonFace;
            resizeButton.FlatStyle = FlatStyle.Popup;
            resizeButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            resizeButton.IconColor = Color.Black;
            resizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resizeButton.IconSize = 20;
            resizeButton.Location = new Point(677, 9);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(34, 24);
            resizeButton.TabIndex = 3;
            resizeButton.TabStop = false;
            resizeButton.UseVisualStyleBackColor = false;
            resizeButton.Click += resizeButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.BackColor = Color.Tomato;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            exitButton.IconColor = Color.Black;
            exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitButton.IconSize = 24;
            exitButton.Location = new Point(717, 9);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(35, 24);
            exitButton.TabIndex = 2;
            exitButton.TabStop = false;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // navbarLabel
            // 
            navbarLabel.AutoSize = true;
            navbarLabel.ForeColor = Color.FromArgb(248, 161, 69);
            navbarLabel.Location = new Point(50, 29);
            navbarLabel.Name = "navbarLabel";
            navbarLabel.Size = new Size(40, 15);
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
            navbarIcon.Location = new Point(13, 20);
            navbarIcon.Name = "navbarIcon";
            navbarIcon.Size = new Size(32, 32);
            navbarIcon.TabIndex = 0;
            navbarIcon.TabStop = false;
            // 
            // panelNavbarShadow
            // 
            panelNavbarShadow.BackColor = Color.FromArgb(70, 70, 70);
            panelNavbarShadow.Dock = DockStyle.Top;
            panelNavbarShadow.Location = new Point(220, 70);
            panelNavbarShadow.Name = "panelNavbarShadow";
            panelNavbarShadow.Size = new Size(764, 6);
            panelNavbarShadow.TabIndex = 3;
            // 
            // panelCurrentMenu
            // 
            panelCurrentMenu.BackColor = Color.FromArgb(90, 90, 90);
            panelCurrentMenu.Dock = DockStyle.Fill;
            panelCurrentMenu.Location = new Point(220, 76);
            panelCurrentMenu.Name = "panelCurrentMenu";
            panelCurrentMenu.Size = new Size(764, 835);
            panelCurrentMenu.TabIndex = 4;
            // 
            // panelMenuShadow
            // 
            panelMenuShadow.BackColor = Color.FromArgb(70, 70, 70);
            panelMenuShadow.Dock = DockStyle.Left;
            panelMenuShadow.Location = new Point(220, 76);
            panelMenuShadow.Name = "panelMenuShadow";
            panelMenuShadow.Size = new Size(6, 835);
            panelMenuShadow.TabIndex = 5;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 911);
            Controls.Add(panelMenuShadow);
            Controls.Add(panelCurrentMenu);
            Controls.Add(panelNavbarShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(800, 950);
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
        private FontAwesome.Sharp.IconButton deleteNoteButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton resizeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
    }
}