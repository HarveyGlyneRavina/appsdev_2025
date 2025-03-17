namespace SimpleFormsAppWithComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CuisineComboBox = new System.Windows.Forms.ComboBox();
            this.Selectbutton4 = new System.Windows.Forms.Button();
            this.FavoriteListBox = new System.Windows.Forms.ListBox();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.FoodCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.RemoveButton2 = new System.Windows.Forms.Button();
            this.ClearButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CuisineComboBox
            // 
            this.CuisineComboBox.FormattingEnabled = true;
            this.CuisineComboBox.Location = new System.Drawing.Point(95, 107);
            this.CuisineComboBox.Name = "CuisineComboBox";
            this.CuisineComboBox.Size = new System.Drawing.Size(150, 21);
            this.CuisineComboBox.TabIndex = 0;
            this.CuisineComboBox.SelectedIndexChanged += new System.EventHandler(this.CuisineComboBox_SelectedIndexChanged);
            // 
            // Selectbutton4
            // 
            this.Selectbutton4.Location = new System.Drawing.Point(104, 136);
            this.Selectbutton4.Name = "Selectbutton4";
            this.Selectbutton4.Size = new System.Drawing.Size(125, 23);
            this.Selectbutton4.TabIndex = 1;
            this.Selectbutton4.Text = "select";
            this.Selectbutton4.UseVisualStyleBackColor = true;
            this.Selectbutton4.Click += new System.EventHandler(this.Selectbutton4_Click);
            // 
            // FavoriteListBox
            // 
            this.FavoriteListBox.FormattingEnabled = true;
            this.FavoriteListBox.Location = new System.Drawing.Point(460, 83);
            this.FavoriteListBox.Name = "FavoriteListBox";
            this.FavoriteListBox.Size = new System.Drawing.Size(153, 199);
            this.FavoriteListBox.TabIndex = 2;
            this.FavoriteListBox.SelectedIndexChanged += new System.EventHandler(this.FavoriteListBox_SelectedIndexChanged);
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(319, 289);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(75, 23);
            this.Addbutton1.TabIndex = 3;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // FoodCheckedListBox
            // 
            this.FoodCheckedListBox.FormattingEnabled = true;
            this.FoodCheckedListBox.Location = new System.Drawing.Point(281, 84);
            this.FoodCheckedListBox.Name = "FoodCheckedListBox";
            this.FoodCheckedListBox.Size = new System.Drawing.Size(152, 199);
            this.FoodCheckedListBox.TabIndex = 4;
            this.FoodCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.FoodCheckedListBox_SelectedIndexChanged);
            // 
            // RemoveButton2
            // 
            this.RemoveButton2.Location = new System.Drawing.Point(619, 107);
            this.RemoveButton2.Name = "RemoveButton2";
            this.RemoveButton2.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton2.TabIndex = 5;
            this.RemoveButton2.Text = "Remove";
            this.RemoveButton2.UseVisualStyleBackColor = true;
            this.RemoveButton2.Click += new System.EventHandler(this.RemoveButton2_Click);
            // 
            // ClearButton3
            // 
            this.ClearButton3.Location = new System.Drawing.Point(619, 136);
            this.ClearButton3.Name = "ClearButton3";
            this.ClearButton3.Size = new System.Drawing.Size(75, 23);
            this.ClearButton3.TabIndex = 6;
            this.ClearButton3.Text = "Clear";
            this.ClearButton3.UseVisualStyleBackColor = true;
            this.ClearButton3.Click += new System.EventHandler(this.ClearButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Simple Favorite Food Picker App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cuisine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Food List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "My Favorite Food List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton3);
            this.Controls.Add(this.RemoveButton2);
            this.Controls.Add(this.FoodCheckedListBox);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.FavoriteListBox);
            this.Controls.Add(this.Selectbutton4);
            this.Controls.Add(this.CuisineComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CuisineComboBox;
        private System.Windows.Forms.Button Selectbutton4;
        private System.Windows.Forms.ListBox FavoriteListBox;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.CheckedListBox FoodCheckedListBox;
        private System.Windows.Forms.Button RemoveButton2;
        private System.Windows.Forms.Button ClearButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

