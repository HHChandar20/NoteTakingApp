using NoteTakingApp.DAL.Models;
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

namespace NoteTakingApp.PL.Forms
{
    public partial class MyNotes : Form
    {
        private static NoteController controllerInstance = NoteController.GetInstance();

        public MyNotes()
        {
            InitializeComponent();

            string[] lines = controllerInstance.ReadFromCsvFile();

            foreach (string line in lines)
            {
                ListViewItem item = new ListViewItem(line.Split(","));
                // Add the item to the ListView and set the image for the image column
                listView1.Items.Add(item);
            }


        }
    }
}
