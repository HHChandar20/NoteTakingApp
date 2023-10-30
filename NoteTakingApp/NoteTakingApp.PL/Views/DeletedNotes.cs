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
        private static MainMenu mainMenuInstance = MainMenu.GetInstance();

        public DeletedNotes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
