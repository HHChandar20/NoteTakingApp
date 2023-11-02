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
            updateButton = new FontAwesome.Sharp.IconButton();
            buttonLayout = new TableLayoutPanel();
            favouritesButton = new FontAwesome.Sharp.IconButton();
            deleteButton = new FontAwesome.Sharp.IconButton();
            buttonLayout.SuspendLayout();
            SuspendLayout();
            // 
            // notesList
            // 
            notesList.BackColor = Color.FromArgb(90, 90, 90);
            notesList.BorderStyle = BorderStyle.None;
            notesList.Columns.AddRange(new ColumnHeader[] { Padding, Id, Title, Description, LastModified, Favourite });
            notesList.Dock = DockStyle.Fill;
            notesList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesList.ForeColor = Color.NavajoWhite;
            notesList.FullRowSelect = true;
            listViewGroup1.Header = "group";
            listViewGroup1.Name = "group";
            notesList.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            notesList.Location = new Point(0, 0);
            notesList.MultiSelect = false;
            notesList.Name = "notesList";
            notesList.ShowGroups = false;
            notesList.Size = new Size(912, 530);
            notesList.TabIndex = 6;
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
            // updateButton
            // 
            updateButton.Dock = DockStyle.Fill;
            updateButton.ForeColor = Color.Coral;
            updateButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            updateButton.IconColor = Color.Black;
            updateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateButton.IconSize = 36;
            updateButton.Location = new Point(608, 2);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(302, 86);
            updateButton.TabIndex = 0;
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // buttonLayout
            // 
            buttonLayout.ColumnCount = 5;
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonLayout.ColumnStyles.Add(new ColumnStyle());
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonLayout.ColumnStyles.Add(new ColumnStyle());
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonLayout.Controls.Add(updateButton, 4, 0);
            buttonLayout.Controls.Add(favouritesButton, 2, 0);
            buttonLayout.Controls.Add(deleteButton, 0, 0);
            buttonLayout.Dock = DockStyle.Bottom;
            buttonLayout.Location = new Point(0, 440);
            buttonLayout.Margin = new Padding(2);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.RowCount = 1;
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonLayout.Size = new Size(912, 90);
            buttonLayout.TabIndex = 7;
            // 
            // favouritesButton
            // 
            favouritesButton.AutoSize = true;
            favouritesButton.Dock = DockStyle.Fill;
            favouritesButton.IconChar = FontAwesome.Sharp.IconChar.HeartBroken;
            favouritesButton.IconColor = Color.Black;
            favouritesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            favouritesButton.IconSize = 40;
            favouritesButton.Location = new Point(305, 2);
            favouritesButton.Margin = new Padding(2);
            favouritesButton.Name = "favouritesButton";
            favouritesButton.Size = new Size(299, 86);
            favouritesButton.TabIndex = 1;
            favouritesButton.UseVisualStyleBackColor = true;
            favouritesButton.Click += favouritesButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            deleteButton.IconColor = Color.Black;
            deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteButton.IconSize = 36;
            deleteButton.Location = new Point(2, 2);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(299, 86);
            deleteButton.TabIndex = 2;
            deleteButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // MyNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 530);
            Controls.Add(buttonLayout);
            Controls.Add(notesList);
            Margin = new Padding(2);
            Name = "MyNotes";
            Text = "Form1";
            buttonLayout.ResumeLayout(false);
            buttonLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView notesList;
        private ColumnHeader Padding;
        private ColumnHeader Id;
        private ColumnHeader Title;
        private ColumnHeader Description;
        private ColumnHeader LastModified;
        private ColumnHeader Favourite;
        private FontAwesome.Sharp.IconButton updateButton;
        private TableLayoutPanel buttonLayout;
        private FontAwesome.Sharp.IconButton favouritesButton;
        private FontAwesome.Sharp.IconButton deleteButton;
    }
}