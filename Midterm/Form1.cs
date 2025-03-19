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

namespace MidtermExamination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] iPhones = {"12 months","24 months","30 months","36 months"};
            ComboBox.Items.AddRange(iPhones);
            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox.SelectedIndex = 0;
            
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void CheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
         
        }
    }
}
