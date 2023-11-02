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
using static System.Windows.Forms.DataFormats;

namespace NoteTakingApp.PL.Views
{

    public partial class UpdateNote : Form
    {
        private static UpdateNote instance = null;

        private static MainMenu mainMenuInstance = MainMenu.GetInstance();
        private static NoteController controllerInstance = NoteController.GetInstance();
        private static int Id;

        public UpdateNote(int id, string title, string description, string favourite)
        {
            InitializeComponent();
            Id = id;
            titleTextBox.Text = title;
            descriptionTextBox.Text = description.Replace("[COMMA]", ",");
            favouriteCheckbox.Checked = favourite == "♥︎";
        }

        public static UpdateNote GetInstance(int id, string title, string description, string favourite)
        {
            if (instance == null)
            {
                instance = new UpdateNote(id, title, description, favourite);
            }

            return instance;
        }


        private void updateNoteButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            string favourite = favouriteCheckbox.Checked ? "♥︎" : "♡";

            controllerInstance.UpdateNote(Id, title, description, favourite);

            this.Close();

            MyNotes myNotesInstance = new MyNotes();
            mainMenuInstance.OpenForm(myNotesInstance);
        }
    }
}
