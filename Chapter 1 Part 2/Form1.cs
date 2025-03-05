using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Middlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suffix_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string fnameValue = Firstname.Text;
            string mnameValue = Middlename.Text;
            string lnameValue = Lastname.Text;
            string suffixValue = Suffix.Text;

            DialogResult Result = MessageBox.Show($"Are you sure you want to sumbit?","Confirmation!", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes) {
                MessageBox.Show($"Hello There! {fnameValue} {mnameValue} {lnameValue} {suffixValue}!", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
