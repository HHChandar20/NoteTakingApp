using FontAwesome.Sharp;
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
    public partial class MainMenu : Form
    {
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;

        // Constructor
        public MainMenu()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderButton);
        }

        //Methods
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableButton();

                //Current button
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(43, 43, 43);
                currentButton.ForeColor = Color.FromArgb(240, 121, 0);
                currentButton.IconColor = Color.FromArgb(240, 121, 0);
                currentButton.Padding = new Padding(15, 0, 10, 0);

                //Left border button
                leftBorderButton.BackColor = Color.FromArgb(248, 161, 69);
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(21, 21, 21);
                currentButton.ForeColor = Color.FromArgb(248, 161, 69);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(248, 161, 69);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void myNotesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void updateNoteButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
