namespace SimpleFormsAppWithMessageBoxes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suffix";
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(89, 103);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(205, 20);
            this.Firstname.TabIndex = 4;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(89, 158);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(205, 20);
            this.Middlename.TabIndex = 5;
            this.Middlename.TextChanged += new System.EventHandler(this.Middlename_TextChanged);
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(92, 210);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(202, 20);
            this.Lastname.TabIndex = 6;
            this.Lastname.TextChanged += new System.EventHandler(this.Lastname_TextChanged);
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(89, 256);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(205, 20);
            this.Suffix.TabIndex = 7;
            this.Suffix.TextChanged += new System.EventHandler(this.Suffix_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(135, 282);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(108, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Simple Form Application";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox Suffix;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label5;
    }
}

