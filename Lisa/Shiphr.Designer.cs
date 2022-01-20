
namespace Lisa
{
    partial class Shiphr
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
            this.label1 = new System.Windows.Forms.Label();
            this.SizeTableRight = new System.Windows.Forms.TextBox();
            this.SizeTableLeft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnteredMessage = new System.Windows.Forms.TextBox();
            this.ResultedString = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DeCryptButton = new System.Windows.Forms.Button();
            this.WriteToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login1
            // 
            this.Login1.AutoSize = true;
            this.Login1.Location = new System.Drawing.Point(12, 26);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(142, 13);
            this.Login1.TabIndex = 2;
            this.Login1.Text = "Введите размер таблицы :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "х";
            // 
            // SizeTableRight
            // 
            this.SizeTableRight.Location = new System.Drawing.Point(218, 22);
            this.SizeTableRight.Name = "SizeTableRight";
            this.SizeTableRight.Size = new System.Drawing.Size(34, 20);
            this.SizeTableRight.TabIndex = 6;
            // 
            // SizeTableLeft
            // 
            this.SizeTableLeft.Location = new System.Drawing.Point(160, 22);
            this.SizeTableLeft.Name = "SizeTableLeft";
            this.SizeTableLeft.Size = new System.Drawing.Size(34, 20);
            this.SizeTableLeft.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите сообщение :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат : ";
            // 
            // EnteredMessage
            // 
            this.EnteredMessage.Location = new System.Drawing.Point(15, 84);
            this.EnteredMessage.Name = "EnteredMessage";
            this.EnteredMessage.Size = new System.Drawing.Size(429, 20);
            this.EnteredMessage.TabIndex = 10;
            // 
            // ResultedString
            // 
            this.ResultedString.Location = new System.Drawing.Point(15, 143);
            this.ResultedString.Name = "ResultedString";
            this.ResultedString.Size = new System.Drawing.Size(429, 20);
            this.ResultedString.TabIndex = 11;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(121, 179);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(91, 39);
            this.EncryptButton.TabIndex = 12;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DeCryptButton
            // 
            this.DeCryptButton.Location = new System.Drawing.Point(15, 179);
            this.DeCryptButton.Name = "DeCryptButton";
            this.DeCryptButton.Size = new System.Drawing.Size(91, 39);
            this.DeCryptButton.TabIndex = 13;
            this.DeCryptButton.Text = "Decrypt";
            this.DeCryptButton.UseVisualStyleBackColor = false;
            this.DeCryptButton.Click += new System.EventHandler(this.DeCryptButton_Click);
            // 
            // WriteToFile
            // 
            this.WriteToFile.Location = new System.Drawing.Point(353, 179);
            this.WriteToFile.Name = "WriteToFile";
            this.WriteToFile.Size = new System.Drawing.Size(91, 39);
            this.WriteToFile.TabIndex = 14;
            this.WriteToFile.Text = "Write";
            this.WriteToFile.UseVisualStyleBackColor = false;
            this.WriteToFile.Click += new System.EventHandler(this.WriteToFile_Click);
            // 
            // Shiphr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 262);
            this.Controls.Add(this.WriteToFile);
            this.Controls.Add(this.DeCryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ResultedString);
            this.Controls.Add(this.EnteredMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeTableLeft);
            this.Controls.Add(this.SizeTableRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login1);
            this.Name = "Shiphr";
            this.Text = "Shiphr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SizeTableRight;
        private System.Windows.Forms.TextBox SizeTableLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnteredMessage;
        private System.Windows.Forms.TextBox ResultedString;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DeCryptButton;
        private System.Windows.Forms.Button WriteToFile;
    }
}