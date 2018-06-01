using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Voting_System_Overlay
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            f2_vote1.Text = Form1.vote1;
            f2_vote2.Text = Form1.vote2;
            f2_vote3.Text = Form1.vote3;
        }




    }
}
