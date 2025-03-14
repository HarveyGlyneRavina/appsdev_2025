namespace SimpleFormsAppWithCheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MovieCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.RemoveButton2 = new System.Windows.Forms.Button();
            this.ClearButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieCheckedListBox
            // 
            this.MovieCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCheckedListBox.FormattingEnabled = true;
            this.MovieCheckedListBox.Location = new System.Drawing.Point(55, 96);
            this.MovieCheckedListBox.Name = "MovieCheckedListBox";
            this.MovieCheckedListBox.Size = new System.Drawing.Size(225, 259);
            this.MovieCheckedListBox.TabIndex = 0;
            this.MovieCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.MovieCheckedListBox_SelectedIndexChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 16;
            this.MovieListBox.Location = new System.Drawing.Point(305, 96);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(212, 260);
            this.MovieListBox.TabIndex = 1;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // AddButton1
            // 
            this.AddButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton1.ForeColor = System.Drawing.Color.Black;
            this.AddButton1.Location = new System.Drawing.Point(132, 362);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(61, 26);
            this.AddButton1.TabIndex = 2;
            this.AddButton1.Text = "ADD";
            this.AddButton1.UseVisualStyleBackColor = false;
            this.AddButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // RemoveButton2
            // 
            this.RemoveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton2.Location = new System.Drawing.Point(404, 362);
            this.RemoveButton2.Name = "RemoveButton2";
            this.RemoveButton2.Size = new System.Drawing.Size(87, 26);
            this.RemoveButton2.TabIndex = 3;
            this.RemoveButton2.Text = "REMOVE";
            this.RemoveButton2.UseVisualStyleBackColor = true;
            this.RemoveButton2.Click += new System.EventHandler(this.RemoveButton2_Click);
            // 
            // ClearButton3
            // 
            this.ClearButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton3.Location = new System.Drawing.Point(320, 362);
            this.ClearButton3.Name = "ClearButton3";
            this.ClearButton3.Size = new System.Drawing.Size(61, 26);
            this.ClearButton3.TabIndex = 4;
            this.ClearButton3.Text = "CLEAR";
            this.ClearButton3.UseVisualStyleBackColor = true;
            this.ClearButton3.Click += new System.EventHandler(this.ClearButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Movies/Series List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "My Movies/Series List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton3);
            this.Controls.Add(this.RemoveButton2);
            this.Controls.Add(this.AddButton1);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.MovieCheckedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox MovieCheckedListBox;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Button RemoveButton2;
        private System.Windows.Forms.Button ClearButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

