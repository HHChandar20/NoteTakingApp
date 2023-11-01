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

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            favouriteCheckbox.Checked = false;
        }
    }

}