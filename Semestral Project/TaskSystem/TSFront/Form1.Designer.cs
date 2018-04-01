namespace TSFront
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(13, 9);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(40, 16);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(13, 47);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(72, 16);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(92, 95);
			this.loginButton.Margin = new System.Windows.Forms.Padding(4);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(100, 28);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Log In";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(92, 9);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(132, 22);
			this.nameTextBox.TabIndex = 3;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(92, 47);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(132, 22);
			this.passwordTextBox.TabIndex = 4;
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(10, 130);
			this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(266, 31);
			this.errorLabel.TabIndex = 5;
			this.errorLabel.Text = "Incorrect Credentials";
			// 
			// Form1
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 170);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.nameLabel);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task System : Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label errorLabel;
	}
}

