using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieR
{
    public partial class MovieInstructions : Form
    {
        public MovieInstructions()
        {
            InitializeComponent();
        }

        private void lblInst_Click(object sender, EventArgs e)
        {

        }

        private void MovieInstructions_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MovieForm mf = new MovieForm();
            mf.Show();
            this.Hide();
        }
    }
}
