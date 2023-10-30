namespace NoteTakingApp.PL.Views
{
    partial class MyNotes
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
            ListViewGroup listViewGroup1 = new ListViewGroup("group", HorizontalAlignment.Left);
            notesList = new ListView();
            Padding = new ColumnHeader();
            Id = new ColumnHeader();
            Title = new ColumnHeader();
            Description = new ColumnHeader();
            LastModified = new ColumnHeader();
            Favourite = new ColumnHeader();
            panelOptions = new Panel();
            deleteButton = new FontAwesome.Sharp.IconButton();
            updateButton = new FontAwesome.Sharp.IconButton();
            panelOptions.SuspendLayout();
            SuspendLayout();
            // 
            // notesList
            // 
            notesList.BackColor = SystemColors.WindowFrame;
            notesList.BorderStyle = BorderStyle.None;
            notesList.Columns.AddRange(new ColumnHeader[] { Padding, Id, Title, Description, LastModified, Favourite });
            notesList.Dock = DockStyle.Fill;
            notesList.ForeColor = Color.NavajoWhite;
            notesList.FullRowSelect = true;
            listViewGroup1.Header = "group";
            listViewGroup1.Name = "group";
            notesList.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            notesList.Location = new Point(0, 0);
            notesList.MultiSelect = false;
            notesList.Name = "notesList";
            notesList.ShowGroups = false;
            notesList.Size = new Size(1157, 484);
            notesList.TabIndex = 1;
            notesList.UseCompatibleStateImageBehavior = false;
            notesList.View = View.Details;
            notesList.SelectedIndexChanged += notesList_SelectedIndexChanged;
            // 
            // Padding
            // 
            Padding.Text = "";
            Padding.Width = 50;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.TextAlign = HorizontalAlignment.Center;
            Id.Width = 150;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.TextAlign = HorizontalAlignment.Center;
            Title.Width = 300;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.TextAlign = HorizontalAlignment.Center;
            Description.Width = 450;
            // 
            // LastModified
            // 
            LastModified.Text = "LastModified";
            LastModified.TextAlign = HorizontalAlignment.Center;
            LastModified.Width = 280;
            // 
            // Favourite
            // 
            Favourite.Text = " ";
            Favourite.TextAlign = HorizontalAlignment.Center;
            Favourite.Width = 100;
            // 
            // panelOptions
            // 
            panelOptions.Controls.Add(deleteButton);
            panelOptions.Controls.Add(updateButton);
            panelOptions.Dock = DockStyle.Bottom;
            panelOptions.Location = new Point(0, 424);
            panelOptions.Margin = new Padding(2);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1157, 60);
            panelOptions.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            deleteButton.IconColor = Color.Black;
            deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteButton.IconSize = 32;
            deleteButton.Location = new Point(969, 0);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(84, 60);
            deleteButton.TabIndex = 2;
            deleteButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            updateButton.ForeColor = Color.Coral;
            updateButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            updateButton.IconColor = Color.Black;
            updateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateButton.IconSize = 32;
            updateButton.Location = new Point(110, 0);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(84, 60);
            updateButton.TabIndex = 0;
            updateButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // MyNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 484);
            Controls.Add(panelOptions);
            Controls.Add(notesList);
            Margin = new Padding(2);
            Name = "MyNotes";
            Text = "Form1";
            panelOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView notesList;
        private ColumnHeader Id;
        private ColumnHeader Title;
        private ColumnHeader Description;
        private ColumnHeader LastModified;
        private ColumnHeader Favourite;
        private ColumnHeader Padding;
        private Panel panelOptions;
        private FontAwesome.Sharp.IconButton updateButton;
        private FontAwesome.Sharp.IconButton deleteButton;
    }
}