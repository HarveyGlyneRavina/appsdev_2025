using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foodCuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            CuisineComboBox.Items.AddRange(foodCuisine);
            CuisineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CuisineComboBox.SelectedItem = 0;
        }

        private void CuisineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FoodCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void FavoriteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            foreach (var item in FoodCheckedListBox.Items) {
                bool isSelected = FoodCheckedListBox.GetItemChecked(FoodCheckedListBox.Items.IndexOf(item));
                if (isSelected && !FavoriteListBox.Items.Contains(item)) 
                {
                    FavoriteListBox.Items.Add(item);
                }
                        
            }
        }

        private void RemoveButton2_Click(object sender, EventArgs e)
        {
            if (FavoriteListBox.Items.Count >= 1)
            {
                FavoriteListBox.Items.Remove(FavoriteListBox.SelectedItem);
            }
        }

        private void ClearButton3_Click(object sender, EventArgs e)
        {
           FavoriteListBox.Items.Clear();
        }

        private void Selectbutton4_Click(object sender, EventArgs e)
        {
            string[] FilipinoFood = { "Adobo", "Sinigang" };
            string[] JapaneseFood = { "Sushi" , "Omurice" };
            string[] ChineseFood = { "dumplings" , "Kung Pao chicken" };
            string[] KoreanFood = { "Jjigae" , "Jinju Kang" };

            FoodCheckedListBox.Items.Clear();

            if (CuisineComboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                FoodCheckedListBox.Items.AddRange(FilipinoFood);
            }
            else if (CuisineComboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                FoodCheckedListBox.Items.AddRange(JapaneseFood);
            }
            else if (CuisineComboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                FoodCheckedListBox.Items.AddRange(ChineseFood);
            }
            else if (CuisineComboBox.SelectedItem.ToString().Contains("Korean"))
            {
                FoodCheckedListBox.Items.AddRange(KoreanFood);
            }
        }
    }
}
