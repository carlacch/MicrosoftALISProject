using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlStandard.BringToFront();            
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            i = 0;
            userControlAction.BringToFront();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            i = 0;
            userControlUrgency.BringToFront();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            i = 0;
            userControlLibrary.BringToFront();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            i = 0;
            userControlContact.BringToFront();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            i = 0;
            userControlLocation.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            i += 1;
            if (i%2 == 0)
            {
                userControlReact.BringToFront();
            }
            else { userControlStandard.BringToFront(); }
        }
    }
}
