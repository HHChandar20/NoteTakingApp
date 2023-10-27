namespace NoteTakingApp.PL.Forms
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
            listView1 = new ListView();
            Id = new ColumnHeader();
            Title = new ColumnHeader();
            Description = new ColumnHeader();
            LastModified = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Title, Description, LastModified });
            listView1.Dock = DockStyle.Fill;
            listViewGroup1.Header = "group";
            listViewGroup1.Name = "group";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1134, 611);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 50;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 150;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 200;
            // 
            // LastModified
            // 
            LastModified.Text = "LastModified";
            LastModified.Width = 150;
            // 
            // MyNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 611);
            Controls.Add(listView1);
            Name = "MyNotes";
            Text = "MyNotes";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader Title;
        private ColumnHeader Description;
        private ColumnHeader LastModified;
    }
}