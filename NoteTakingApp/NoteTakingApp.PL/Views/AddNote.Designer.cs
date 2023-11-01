namespace NoteTakingApp.PL.Views
{
    partial class AddNote
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
            titleTextBox = new TextBox();
            descriptionTextBox = new RichTextBox();
            addNoteButton = new Button();
            titleLabel = new Label();
            descriptionLabel = new Label();
            panelAddNote = new Panel();
            titleLayoutPanel = new TableLayoutPanel();
            descriptionLayoutPanel = new TableLayoutPanel();
            favouriteLayoutPanel = new TableLayoutPanel();
            favouriteCheckbox = new CheckBox();
            panelAddNote.SuspendLayout();
            titleLayoutPanel.SuspendLayout();
            descriptionLayoutPanel.SuspendLayout();
            favouriteLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.None;
            titleTextBox.BackColor = Color.NavajoWhite;
            titleTextBox.Font = new Font("Russo One", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextBox.Location = new Point(359, 43);
            titleTextBox.Margin = new Padding(2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(429, 30);
            titleTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.None;
            descriptionTextBox.BackColor = Color.NavajoWhite;
            descriptionTextBox.Location = new Point(359, 47);
            descriptionTextBox.Margin = new Padding(2);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(429, 220);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.Text = "";
            // 
            // addNoteButton
            // 
            addNoteButton.BackColor = Color.FromArgb(250, 141, 29);
            addNoteButton.Dock = DockStyle.Bottom;
            addNoteButton.FlatStyle = FlatStyle.Popup;
            addNoteButton.Font = new Font("Russo One", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            addNoteButton.ForeColor = Color.PapayaWhip;
            addNoteButton.Location = new Point(0, 879);
            addNoteButton.Margin = new Padding(2);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(1147, 52);
            addNoteButton.TabIndex = 3;
            addNoteButton.Text = "Add Note";
            addNoteButton.UseVisualStyleBackColor = false;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(248, 161, 69);
            titleLabel.Location = new Point(544, 6);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(58, 23);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.ForeColor = Color.FromArgb(248, 161, 69);
            descriptionLabel.Location = new Point(507, 9);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(132, 23);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description";
            // 
            // panelAddNote
            // 
            panelAddNote.Controls.Add(titleLayoutPanel);
            panelAddNote.Controls.Add(descriptionLayoutPanel);
            panelAddNote.Controls.Add(favouriteLayoutPanel);
            panelAddNote.Controls.Add(addNoteButton);
            panelAddNote.Dock = DockStyle.Fill;
            panelAddNote.Location = new Point(0, 0);
            panelAddNote.Name = "panelAddNote";
            panelAddNote.Size = new Size(1147, 931);
            panelAddNote.TabIndex = 6;
            // 
            // titleLayoutPanel
            // 
            titleLayoutPanel.Anchor = AnchorStyles.Top;
            titleLayoutPanel.ColumnCount = 1;
            titleLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleLayoutPanel.Controls.Add(titleLabel, 0, 0);
            titleLayoutPanel.Controls.Add(titleTextBox, 0, 1);
            titleLayoutPanel.Location = new Point(0, 75);
            titleLayoutPanel.Name = "titleLayoutPanel";
            titleLayoutPanel.RowCount = 2;
            titleLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            titleLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            titleLayoutPanel.Size = new Size(1147, 81);
            titleLayoutPanel.TabIndex = 8;
            // 
            // descriptionLayoutPanel
            // 
            descriptionLayoutPanel.Anchor = AnchorStyles.Top;
            descriptionLayoutPanel.ColumnCount = 1;
            descriptionLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            descriptionLayoutPanel.Controls.Add(descriptionTextBox, 0, 1);
            descriptionLayoutPanel.Controls.Add(descriptionLabel, 0, 0);
            descriptionLayoutPanel.Location = new Point(0, 192);
            descriptionLayoutPanel.Name = "descriptionLayoutPanel";
            descriptionLayoutPanel.RowCount = 2;
            descriptionLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6976748F));
            descriptionLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.30232F));
            descriptionLayoutPanel.Size = new Size(1147, 273);
            descriptionLayoutPanel.TabIndex = 7;
            // 
            // favouriteLayoutPanel
            // 
            favouriteLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            favouriteLayoutPanel.ColumnCount = 1;
            favouriteLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            favouriteLayoutPanel.Controls.Add(favouriteCheckbox, 0, 0);
            favouriteLayoutPanel.Location = new Point(0, 538);
            favouriteLayoutPanel.Name = "favouriteLayoutPanel";
            favouriteLayoutPanel.RowCount = 1;
            favouriteLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            favouriteLayoutPanel.Size = new Size(1147, 122);
            favouriteLayoutPanel.TabIndex = 6;
            // 
            // favouriteCheckbox
            // 
            favouriteCheckbox.Anchor = AnchorStyles.None;
            favouriteCheckbox.AutoSize = true;
            favouriteCheckbox.BackColor = Color.Transparent;
            favouriteCheckbox.FlatAppearance.BorderColor = Color.FromArgb(248, 161, 69);
            favouriteCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(248, 161, 69);
            favouriteCheckbox.FlatAppearance.MouseDownBackColor = Color.FromArgb(248, 161, 69);
            favouriteCheckbox.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 161, 69);
            favouriteCheckbox.Font = new Font("Russo One", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            favouriteCheckbox.ForeColor = Color.FromArgb(248, 161, 69);
            favouriteCheckbox.Location = new Point(509, 47);
            favouriteCheckbox.Margin = new Padding(2);
            favouriteCheckbox.Name = "favouriteCheckbox";
            favouriteCheckbox.Size = new Size(129, 27);
            favouriteCheckbox.TabIndex = 2;
            favouriteCheckbox.Text = "Favourite";
            favouriteCheckbox.TextAlign = ContentAlignment.MiddleCenter;
            favouriteCheckbox.TextImageRelation = TextImageRelation.ImageAboveText;
            favouriteCheckbox.UseVisualStyleBackColor = false;
            // 
            // AddNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(90, 90, 90);
            ClientSize = new Size(1147, 931);
            Controls.Add(panelAddNote);
            Margin = new Padding(2);
            Name = "AddNote";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Add Note";
            panelAddNote.ResumeLayout(false);
            titleLayoutPanel.ResumeLayout(false);
            titleLayoutPanel.PerformLayout();
            descriptionLayoutPanel.ResumeLayout(false);
            descriptionLayoutPanel.PerformLayout();
            favouriteLayoutPanel.ResumeLayout(false);
            favouriteLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox titleTextBox;
        private RichTextBox descriptionTextBox;
        private Button addNoteButton;
        private Label titleLabel;
        private Label descriptionLabel;
        private Panel panelAddNote;
        private CheckBox favouriteCheckbox;
        private TableLayoutPanel favouriteLayoutPanel;
        private TableLayoutPanel titleLayoutPanel;
        private TableLayoutPanel descriptionLayoutPanel;
    }
}