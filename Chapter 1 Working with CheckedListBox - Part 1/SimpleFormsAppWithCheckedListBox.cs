using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom", "Avengers Infinity","Avengers Endgame" };
            MovieCheckedListBox.Items.AddRange(movies);

            MovieCheckedListBox.CheckOnClick = true;
        }

        private void MovieCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            foreach (var movies in MovieCheckedListBox.Items) {
                bool isSelected = MovieCheckedListBox.GetItemChecked(MovieCheckedListBox.Items.IndexOf(movies));
                if (isSelected && !MovieListBox.Items.Contains(movies)) 
                {
                    MovieListBox.Items.Add(movies);
                }
            }
        }

        private void RemoveButton2_Click(object sender, EventArgs e)
        {
            if (MovieListBox.Items.Count >= 1) {
                MovieListBox.Items.Remove(MovieListBox.SelectedItem);
            }
        }

        private void ClearButton3_Click(object sender, EventArgs e)
        {
            MovieListBox.Items.Clear();
        }
    }
}
