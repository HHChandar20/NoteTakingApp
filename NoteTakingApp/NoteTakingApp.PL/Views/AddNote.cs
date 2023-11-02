using NoteTakingApp.PL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace NoteTakingApp.PL.Views
{
    public partial class AddNote : Form
    {
        private static NoteController noteController = NoteController.GetInstance();

        public AddNote()
        {
            InitializeComponent();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "")
            {
                noteController.CreateNewNote(titleTextBox.Text, descriptionTextBox.Text, favouriteCheckbox.Checked ? "♥︎" : "♡");
            }
            else
            {
                string caption = "Error Detected in Input";
                string message = "You must add title!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            favouriteCheckbox.Checked = false;
        }
    }

}