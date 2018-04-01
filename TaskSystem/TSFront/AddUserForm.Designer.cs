namespace TSFront
{
	partial class AddUserForm
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
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.passwordTextBox2 = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.adminRadioButton = new System.Windows.Forms.RadioButton();
			this.notAdminRadioButton = new System.Windows.Forms.RadioButton();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(95, 7);
			this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(132, 22);
			this.nameTextbox.TabIndex = 0;
			// 
			// passwordTextBox2
			// 
			this.passwordTextBox2.Location = new System.Drawing.Point(95, 103);
			this.passwordTextBox2.Margin = new System.Windows.Forms.Padding(4);
			this.passwordTextBox2.Name = "passwordTextBox2";
			this.passwordTextBox2.PasswordChar = '*';
			this.passwordTextBox2.Size = new System.Drawing.Size(132, 22);
			this.passwordTextBox2.TabIndex = 3;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(95, 39);
			this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(132, 22);
			this.emailTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(95, 71);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(132, 22);
			this.passwordTextBox.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.adminRadioButton);
			this.panel1.Controls.Add(this.notAdminRadioButton);
			this.panel1.Location = new System.Drawing.Point(95, 135);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 34);
			this.panel1.TabIndex = 4;
			// 
			// adminRadioButton
			// 
			this.adminRadioButton.AutoSize = true;
			this.adminRadioButton.Location = new System.Drawing.Point(4, 10);
			this.adminRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.adminRadioButton.Name = "adminRadioButton";
			this.adminRadioButton.Size = new System.Drawing.Size(50, 20);
			this.adminRadioButton.TabIndex = 4;
			this.adminRadioButton.TabStop = true;
			this.adminRadioButton.Text = "Yes";
			this.adminRadioButton.UseVisualStyleBackColor = true;
			// 
			// notAdminRadioButton
			// 
			this.notAdminRadioButton.AutoSize = true;
			this.notAdminRadioButton.Location = new System.Drawing.Point(69, 10);
			this.notAdminRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.notAdminRadioButton.Name = "notAdminRadioButton";
			this.notAdminRadioButton.Size = new System.Drawing.Size(42, 20);
			this.notAdminRadioButton.TabIndex = 5;
			this.notAdminRadioButton.TabStop = true;
			this.notAdminRadioButton.Text = "No";
			this.notAdminRadioButton.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(20, 177);
			this.saveButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(100, 28);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(128, 177);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 28);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "E-mail";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 75);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 107);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Repeat";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 148);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Admin ?";
			// 
			// AddUserForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(245, 220);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.passwordTextBox2);
			this.Controls.Add(this.nameTextbox);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New User";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.TextBox passwordTextBox2;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton adminRadioButton;
		private System.Windows.Forms.RadioButton notAdminRadioButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}