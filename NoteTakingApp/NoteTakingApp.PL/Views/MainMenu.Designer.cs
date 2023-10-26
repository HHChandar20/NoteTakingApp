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
            panelMenu = new Panel();
            updateNoteButton = new FontAwesome.Sharp.IconButton();
            deleteNoteButton = new FontAwesome.Sharp.IconButton();
            addNoteButton = new FontAwesome.Sharp.IconButton();
            myNotesButton = new FontAwesome.Sharp.IconButton();
            homeButton = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(21, 21, 21);
            panelMenu.Controls.Add(updateNoteButton);
            panelMenu.Controls.Add(deleteNoteButton);
            panelMenu.Controls.Add(addNoteButton);
            panelMenu.Controls.Add(myNotesButton);
            panelMenu.Controls.Add(homeButton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 1;
            // 
            // updateNoteButton
            // 
            updateNoteButton.Dock = DockStyle.Top;
            updateNoteButton.FlatAppearance.BorderSize = 0;
            updateNoteButton.FlatStyle = FlatStyle.Flat;
            updateNoteButton.ForeColor = Color.FromArgb(248, 161, 69);
            updateNoteButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            updateNoteButton.IconColor = Color.FromArgb(248, 161, 69);
            updateNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateNoteButton.IconSize = 32;
            updateNoteButton.ImageAlign = ContentAlignment.MiddleLeft;
            updateNoteButton.Location = new Point(0, 380);
            updateNoteButton.Name = "updateNoteButton";
            updateNoteButton.Padding = new Padding(10, 0, 20, 0);
            updateNoteButton.Size = new Size(220, 60);
            updateNoteButton.TabIndex = 5;
            updateNoteButton.Text = "Update Note";
            updateNoteButton.TextAlign = ContentAlignment.MiddleLeft;
            updateNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateNoteButton.UseVisualStyleBackColor = true;
            updateNoteButton.Click += updateNoteButton_Click;
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
            deleteNoteButton.Location = new Point(0, 320);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Padding = new Padding(10, 0, 20, 0);
            deleteNoteButton.Size = new Size(220, 60);
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
            myNotesButton.Location = new Point(0, 200);
            myNotesButton.Name = "myNotesButton";
            myNotesButton.Padding = new Padding(10, 0, 20, 0);
            myNotesButton.Size = new Size(220, 60);
            myNotesButton.TabIndex = 2;
            myNotesButton.Text = "My Notes";
            myNotesButton.TextAlign = ContentAlignment.MiddleLeft;
            myNotesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            myNotesButton.UseVisualStyleBackColor = true;
            myNotesButton.Click += myNotesButton_Click;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Top;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.FromArgb(248, 161, 69);
            homeButton.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            homeButton.IconColor = Color.FromArgb(248, 161, 69);
            homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeButton.IconSize = 32;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(0, 140);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(10, 0, 20, 0);
            homeButton.Size = new Size(220, 60);
            homeButton.TabIndex = 1;
            homeButton.Text = "Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            Text = "Note Taking App";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton updateNoteButton;
        private FontAwesome.Sharp.IconButton deleteNoteButton;
        private FontAwesome.Sharp.IconButton addNoteButton;
        private FontAwesome.Sharp.IconButton myNotesButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private Panel panelLogo;
    }
}