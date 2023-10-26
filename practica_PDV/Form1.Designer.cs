namespace practica_PDV
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
            this.email = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(368, 118);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 16);
            this.email.TabIndex = 0;
            this.email.Text = "EMAIL";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(354, 311);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 2;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(296, 160);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(198, 22);
            this.txt_email.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(343, 217);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 16);
            this.password.TabIndex = 1;
            this.password.Text = "PASSWORD";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(296, 248);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(198, 22);
            this.txt_password.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_password;
    }
}

