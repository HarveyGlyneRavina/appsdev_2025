using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !lstBox.Items.Contains(txtBox.Text))
                lstBox.Items.Add(txtBox.Text);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
           lstBox.Items.Remove(lstBox.SelectedItem);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
