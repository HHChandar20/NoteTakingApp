using NoteTakingApp.PL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp.PL.Views
{
    public partial class Favourites : Form
    {
        NoteController controllerInstance = NoteController.GetInstance();
        MainMenu mainMenuInstance = MainMenu.GetInstance();
        public Favourites()
        {
            InitializeComponent();
            LoadNotesToListView();
        }

        private void LoadNotesToListView()
        {
            notesList.Items.Clear();

            string[] lines = controllerInstance.ReadNotes();

            foreach (string line in lines)
            {
                if (line == "" || line.Contains("♡")) continue;

                string[] values = new string[6];

                Array.Copy(line.Split(","), 0, values, 1, 5);

                ListViewItem item = new ListViewItem(values);

                notesList.Items.Add(item);
            }
        }

        private void removeFromFavouritesButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count != 1) return;

            int id = int.Parse(notesList.SelectedItems[0].SubItems[1].Text);
            string title = notesList.SelectedItems[0].SubItems[2].Text;
            string description = notesList.SelectedItems[0].SubItems[3].Text;
            string favourite = "♡";

            controllerInstance.UpdateNote(id, title, description, favourite);
            notesList.SelectedItems[0].Remove();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count != 1) return;

            controllerInstance.DeleteNote(int.Parse(notesList.SelectedItems[0].SubItems[1].Text));
            LoadNotesToListView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count != 1) return;

            int id = int.Parse(notesList.SelectedItems[0].SubItems[1].Text);
            string title = notesList.SelectedItems[0].SubItems[2].Text;
            string description = notesList.SelectedItems[0].SubItems[3].Text;
            string favourite = notesList.SelectedItems[0].SubItems[5].Text;

            UpdateNote updateMenuInstance = new UpdateNote(id, title, description, favourite);
            mainMenuInstance.OpenForm(updateMenuInstance);
        }
    }
}
