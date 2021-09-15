namespace GimpiesWinForm
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
            this.usernameField = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(51, 42);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(118, 30);
            this.usernameField.TabIndex = 0;
            this.usernameField.Text = "Gebruikersnaam:";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(51, 72);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(118, 30);
            this.passwordField.TabIndex = 1;
            this.passwordField.Text = "Wachtwoord:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginButton.Location = new System.Drawing.Point(425, 42);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(189, 43);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(175, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(156, 22);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(175, 72);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(156, 22);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Laat wachtwoord zien.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(212, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 27);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;

        private System.Windows.Forms.Button loginButton;

        private System.Windows.Forms.Label usernameField;
        private System.Windows.Forms.Label passwordField;

        #endregion
    }
}