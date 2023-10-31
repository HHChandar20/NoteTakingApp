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
    public partial class DeletedNotes : Form
    {
        private static NoteController controllerInstance = NoteController.GetInstance();

        public DeletedNotes()
        {
            InitializeComponent();
            LoadNotesToListView();
        }

        private void LoadNotesToListView()
        {
            notesList.Items.Clear();
            string[] lines = controllerInstance.ReadDeletedNotes();

            foreach (string line in lines)
            {
                if (line == "") continue;

                string[] values = new string[6];

                Array.Copy(line.Split(","), 0, values, 1, 5);

                ListViewItem item = new ListViewItem(values);

                notesList.Items.Add(item);
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count != 1) return;

            controllerInstance.RestoreNote(int.Parse(notesList.SelectedItems[0].SubItems[1].Text));
            LoadNotesToListView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count != 1) return;

            controllerInstance.DeleteNotePermanently(int.Parse(notesList.SelectedItems[0].SubItems[1].Text));
            LoadNotesToListView();
        }
    }
}
