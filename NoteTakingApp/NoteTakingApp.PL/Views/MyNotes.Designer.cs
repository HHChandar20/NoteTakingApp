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
            notesList.Margin = new Padding(4, 5, 4, 5);
            notesList.MultiSelect = false;
            notesList.Name = "notesList";
            notesList.ShowGroups = false;
            notesList.Size = new Size(800, 450);
            notesList.TabIndex = 1;
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
            // MyNotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notesList);
            Name = "MyNotes";
            Text = "Form1";
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
    }
}