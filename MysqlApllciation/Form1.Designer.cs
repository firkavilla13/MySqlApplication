namespace MysqlApllciation
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
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.jelszoTextBox = new System.Windows.Forms.TextBox();
            this.szuletesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(27, 27);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(209, 20);
            this.nevTextBox.TabIndex = 0;
            // 
            // jelszoTextBox
            // 
            this.jelszoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.jelszoTextBox.Location = new System.Drawing.Point(27, 54);
            this.jelszoTextBox.Name = "jelszoTextBox";
            this.jelszoTextBox.PasswordChar = '*';
            this.jelszoTextBox.Size = new System.Drawing.Size(209, 20);
            this.jelszoTextBox.TabIndex = 1;
            // 
            // szuletesDateTimePicker
            // 
            this.szuletesDateTimePicker.Location = new System.Drawing.Point(27, 80);
            this.szuletesDateTimePicker.Name = "szuletesDateTimePicker";
            this.szuletesDateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.szuletesDateTimePicker.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(27, 116);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Regisztracio";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(27, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Törlés";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(27, 205);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.szuletesDateTimePicker);
            this.Controls.Add(this.jelszoTextBox);
            this.Controls.Add(this.nevTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox jelszoTextBox;
        private System.Windows.Forms.DateTimePicker szuletesDateTimePicker;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}

