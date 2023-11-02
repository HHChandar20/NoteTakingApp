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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
