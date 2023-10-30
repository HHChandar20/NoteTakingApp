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

namespace NoteTakingApp.PL.Views
{
    public partial class MyNotes : Form
    {
        private static NoteController controllerInstance = NoteController.GetInstance();
        private static MainMenu mainMenuInstance = MainMenu.GetInstance();

        public MyNotes()
        {
            InitializeComponent();
            LoadNotesToListView();
        }

        private void LoadNotesToListView()
        {
            string[] lines = controllerInstance.ReadFromCsvFile();

            foreach (string line in lines)
            {
                if (line == "") continue;

                string[] values = new string[6];

                Array.Copy(line.Split(","), 0, values, 1, 5);

                ListViewItem item = new ListViewItem(values);

                notesList.Items.Add(item);
            }
        }

        private void notesList_DoubleClick(object sender, EventArgs e)
        {
            updateButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count == 1)
            {
                controllerInstance.DeleteNote(int.Parse(notesList.SelectedItems[0].SubItems[1].Text));
                notesList.SelectedItems[0].Remove();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count == 1)
            {
                int id = int.Parse(notesList.SelectedItems[0].SubItems[1].Text);
                string title = notesList.SelectedItems[0].SubItems[2].Text;
                string description = notesList.SelectedItems[0].SubItems[3].Text;
                string favourite = notesList.SelectedItems[0].SubItems[5].Text;

                UpdateNote updateMenuInstance = new UpdateNote(id, title, description, favourite);
                mainMenuInstance.OpenForm(updateMenuInstance);

            }

        }

        private void notesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}