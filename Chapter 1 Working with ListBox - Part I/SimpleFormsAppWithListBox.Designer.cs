namespace SimpleFormsAppWithListBox
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Name Viewer";
            // 
            // lstBox
            // 
            this.lstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 24;
            this.lstBox.Location = new System.Drawing.Point(57, 59);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(326, 364);
            this.lstBox.TabIndex = 1;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(91, 455);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(64, 60);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(91, 429);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(244, 20);
            this.txtBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(173, 455);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(70, 60);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(260, 455);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 60);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 531);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

