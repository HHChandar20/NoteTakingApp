using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Form currentForm;

        // Constructor
        public MainMenu()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderButton);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        //Methods
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableButton();

                // Current button
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(43, 43, 43);
                currentButton.ForeColor = Color.FromArgb(240, 121, 0);
                currentButton.IconColor = Color.FromArgb(240, 121, 0);
                currentButton.Padding = new Padding(25, 0, 10, 0);

                // Left border button
                leftBorderButton.BackColor = Color.FromArgb(248, 161, 69);
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                // Navbar icon
                navbarIcon.IconChar = currentButton.IconChar;
                navbarLabel.Text = currentButton.Text;
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
                currentButton.Padding = new Padding(10, 0, 10, 0);
            }
        }

        private void OpenForm(Form newForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelCurrentMenu.Controls.Add(newForm);
            panelCurrentMenu.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void myNotesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenForm(new MyNotes());
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenForm(new AddNote());
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderButton.Visible = false;
            navbarIcon.IconChar = IconChar.HomeLg;
            navbarLabel.Text = "Home";
        }


        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
