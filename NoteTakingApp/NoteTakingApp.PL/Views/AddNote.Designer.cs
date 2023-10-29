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
            favouriteCheckbox = new CheckBox();
            addNoteButton = new Button();
            titleLabel = new Label();
            descriptionLabel = new Label();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(324, 68);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(340, 31);
            titleTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(288, 194);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(455, 144);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.Text = "";
            // 
            // favouriteCheckbox
            // 
            favouriteCheckbox.AutoSize = true;
            favouriteCheckbox.Location = new Point(432, 413);
            favouriteCheckbox.Name = "favouriteCheckbox";
            favouriteCheckbox.Size = new Size(110, 29);
            favouriteCheckbox.TabIndex = 2;
            favouriteCheckbox.Text = "Favourite";
            favouriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // addNoteButton
            // 
            addNoteButton.Location = new Point(444, 512);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(112, 34);
            addNoteButton.TabIndex = 3;
            addNoteButton.Text = "Add Note";
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(474, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(44, 25);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(452, 154);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description";
            // 
            // AddNote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 612);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(addNoteButton);
            Controls.Add(favouriteCheckbox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Name = "AddNote";
            Text = "Add Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private RichTextBox descriptionTextBox;
        private CheckBox favouriteCheckbox;
        private Button addNoteButton;
        private Label titleLabel;
        private Label descriptionLabel;
    }
}