
namespace Lisa
{
    partial class Auth
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
            this.Login1 = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.RegLabel = new System.Windows.Forms.Label();
            this.AuthCancelButton = new System.Windows.Forms.Button();
            this.AuthEntButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login1
            // 
            this.Login1.AutoSize = true;
            this.Login1.Location = new System.Drawing.Point(49, 64);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(33, 13);
            this.Login1.TabIndex = 1;
            this.Login1.Text = "Login";
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.Location = new System.Drawing.Point(49, 120);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(53, 13);
            this.Password1.TabIndex = 2;
            this.Password1.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(143, 113);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(160, 20);
            this.Password.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(143, 61);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 20);
            this.Login.TabIndex = 4;
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Location = new System.Drawing.Point(109, 148);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(170, 13);
            this.RegLabel.TabIndex = 6;
            this.RegLabel.Text = "Do not have an account? Sign Up";
            this.RegLabel.Click += new System.EventHandler(this.RegLabel_Click);
            // 
            // AuthCancelButton
            // 
            this.AuthCancelButton.Location = new System.Drawing.Point(49, 183);
            this.AuthCancelButton.Name = "AuthCancelButton";
            this.AuthCancelButton.Size = new System.Drawing.Size(91, 39);
            this.AuthCancelButton.TabIndex = 8;
            this.AuthCancelButton.Text = "Cancel";
            this.AuthCancelButton.UseVisualStyleBackColor = true;
            this.AuthCancelButton.Click += new System.EventHandler(this.AuthCancelButton_Click);
            // 
            // AuthEntButton
            // 
            this.AuthEntButton.Location = new System.Drawing.Point(236, 183);
            this.AuthEntButton.Name = "AuthEntButton";
            this.AuthEntButton.Size = new System.Drawing.Size(91, 39);
            this.AuthEntButton.TabIndex = 7;
            this.AuthEntButton.Text = "Enter";
            this.AuthEntButton.UseVisualStyleBackColor = true;
            this.AuthEntButton.Click += new System.EventHandler(this.AuthEntButton_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 249);
            this.Controls.Add(this.AuthCancelButton);
            this.Controls.Add(this.AuthEntButton);
            this.Controls.Add(this.RegLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.Login1);
            this.Name = "Auth";
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login1;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.Button AuthCancelButton;
        private System.Windows.Forms.Button AuthEntButton;
    }
}