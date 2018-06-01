using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;



namespace Voting_System_Overlay
{
    public partial class Form1 : Form
    {
        // Access var globaly
        public static string vote1 = "";
        public static string vote2 = "";
        public static string vote3 = "";

        // Greenscreen var
        Form2 f2 = new Form2();

        // load all Coponents
        public Form1() // on Startup
        {
            InitializeComponent();
        }

        // Buttons
          // on Start
        public void b_start_Click(object sender, EventArgs e)
        {
            // Transfer input to global var
            vote1 = text_v1.Text;
            vote2 = text_v2.Text;
            vote3 = text_v3.Text;

            // Open Greenscreen
            f2.Show();
            
            // Switch Enable Buttons
            b_start.Enabled = false;
            b_stop.Enabled = true;
        }
          // on stop
        private void b_stop_Click(object sender, EventArgs e)
        {
            // close Greenscreen
            f2.Hide();

            // Switch Enable Buttons
            b_start.Enabled = true;
            b_stop.Enabled = false;
        }
    }
}



