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
                string[] values = new string[6];

                Array.Copy(line.Split(","), 0, values, 1, 5);

                ListViewItem item = new ListViewItem(values);

                notesList.Items.Add(item);
            }
        }

        private void notesList_DoubleClick(object sender, EventArgs e)
        {
            if (notesList.SelectedItems.Count > 0)
            {

            }
        }
    }
}