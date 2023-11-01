namespace NoteTakingApp.PL.Views
{
    partial class DeletedNotes
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
            restoreButton = new FontAwesome.Sharp.IconButton();
            deleteButton = new FontAwesome.Sharp.IconButton();
            buttonsLayout = new TableLayoutPanel();
            buttonsLayout.SuspendLayout();
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
            notesList.Size = new Size(598, 332);
            notesList.TabIndex = 7;
            notesList.UseCompatibleStateImageBehavior = false;
            notesList.View = View.Details;
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
            // restoreButton
            // 
            restoreButton.Dock = DockStyle.Fill;
            restoreButton.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            restoreButton.IconColor = Color.Black;
            restoreButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            restoreButton.IconSize = 36;
            restoreButton.Location = new Point(2, 2);
            restoreButton.Margin = new Padding(2);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(295, 86);
            restoreButton.TabIndex = 0;
            restoreButton.UseVisualStyleBackColor = true;
            restoreButton.Click += restoreButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            deleteButton.IconColor = Color.Black;
            deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteButton.IconSize = 40;
            deleteButton.Location = new Point(301, 2);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(295, 86);
            deleteButton.TabIndex = 1;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // buttonsLayout
            // 
            buttonsLayout.ColumnCount = 2;
            buttonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsLayout.Controls.Add(restoreButton, 0, 0);
            buttonsLayout.Controls.Add(deleteButton, 1, 0);
            buttonsLayout.Dock = DockStyle.Bottom;
            buttonsLayout.Location = new Point(0, 242);
            buttonsLayout.Margin = new Padding(2);
            buttonsLayout.Name = "buttonsLayout";
            buttonsLayout.RowCount = 1;
            buttonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsLayout.Size = new Size(598, 90);
            buttonsLayout.TabIndex = 8;
            // 
            // DeletedNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 332);
            Controls.Add(buttonsLayout);
            Controls.Add(notesList);
            Margin = new Padding(2);
            Name = "DeletedNotes";
            Text = "Form1";
            buttonsLayout.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton restoreButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private TableLayoutPanel buttonsLayout;
    }
}