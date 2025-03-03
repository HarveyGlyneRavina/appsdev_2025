using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpIeFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string fnameValue = FirstName.Text;
            string lnameValue = LastName.Text;

            MessageBox.Show($"Hello There! {fnameValue} {lnameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
