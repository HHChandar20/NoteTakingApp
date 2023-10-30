namespace NoteTakingApp.PL.Views
{
    partial class UpdateNote
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
            descriptionLabel = new Label();
            titleLabel = new Label();
            updateNoteButton = new Button();
            favouriteCheckbox = new CheckBox();
            descriptionTextBox = new RichTextBox();
            titleTextBox = new TextBox();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(391, 183);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(415, 62);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(44, 25);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Title";
            // 
            // updateNoteButton
            // 
            updateNoteButton.Location = new Point(386, 517);
            updateNoteButton.Name = "updateNoteButton";
            updateNoteButton.Size = new Size(112, 34);
            updateNoteButton.TabIndex = 9;
            updateNoteButton.Text = "Update Note";
            updateNoteButton.UseVisualStyleBackColor = true;
            updateNoteButton.Click += updateNoteButton_Click;
            // 
            // favouriteCheckbox
            // 
            favouriteCheckbox.AutoSize = true;
            favouriteCheckbox.Location = new Point(391, 428);
            favouriteCheckbox.Name = "favouriteCheckbox";
            favouriteCheckbox.Size = new Size(110, 29);
            favouriteCheckbox.TabIndex = 8;
            favouriteCheckbox.Text = "Favourite";
            favouriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(219, 229);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(455, 144);
            descriptionTextBox.TabIndex = 7;
            descriptionTextBox.Text = "";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(275, 101);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(340, 31);
            titleTextBox.TabIndex = 6;
            // 
            // UpdateNote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 611);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(updateNoteButton);
            Controls.Add(favouriteCheckbox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Name = "UpdateNote";
            Text = "UpdateNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private Label titleLabel;
        private Button updateNoteButton;
        private CheckBox favouriteCheckbox;
        private RichTextBox descriptionTextBox;
        private TextBox titleTextBox;
    }
}