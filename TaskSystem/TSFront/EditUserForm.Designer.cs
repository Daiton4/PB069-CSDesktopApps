namespace TSFront
{
	partial class EditUserForm
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
			this.searchModePanel = new System.Windows.Forms.Panel();
			this.emailRadioButton = new System.Windows.Forms.RadioButton();
			this.nameRadioButton = new System.Windows.Forms.RadioButton();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.usersListBox = new System.Windows.Forms.ListBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.notAdminRadioButton = new System.Windows.Forms.RadioButton();
			this.adminRadioButton = new System.Windows.Forms.RadioButton();
			this.passwordButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.addUserButton = new System.Windows.Forms.Button();
			this.searchModePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchModePanel
			// 
			this.searchModePanel.Controls.Add(this.emailRadioButton);
			this.searchModePanel.Controls.Add(this.nameRadioButton);
			this.searchModePanel.Location = new System.Drawing.Point(159, 4);
			this.searchModePanel.Margin = new System.Windows.Forms.Padding(4);
			this.searchModePanel.Name = "searchModePanel";
			this.searchModePanel.Size = new System.Drawing.Size(159, 62);
			this.searchModePanel.TabIndex = 10;
			// 
			// emailRadioButton
			// 
			this.emailRadioButton.AutoSize = true;
			this.emailRadioButton.Checked = true;
			this.emailRadioButton.Location = new System.Drawing.Point(4, 4);
			this.emailRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.emailRadioButton.Name = "emailRadioButton";
			this.emailRadioButton.Size = new System.Drawing.Size(74, 20);
			this.emailRadioButton.TabIndex = 3;
			this.emailRadioButton.TabStop = true;
			this.emailRadioButton.Text = "E-Mail";
			this.emailRadioButton.UseVisualStyleBackColor = true;
			// 
			// nameRadioButton
			// 
			this.nameRadioButton.AutoSize = true;
			this.nameRadioButton.Location = new System.Drawing.Point(4, 32);
			this.nameRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.nameRadioButton.Name = "nameRadioButton";
			this.nameRadioButton.Size = new System.Drawing.Size(58, 20);
			this.nameRadioButton.TabIndex = 4;
			this.nameRadioButton.Text = "Name";
			this.nameRadioButton.UseVisualStyleBackColor = true;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(325, 0);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(100, 28);
			this.searchButton.TabIndex = 9;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(16, 4);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(132, 22);
			this.searchTextBox.TabIndex = 8;
			// 
			// usersListBox
			// 
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.ItemHeight = 16;
			this.usersListBox.Location = new System.Drawing.Point(16, 86);
			this.usersListBox.Margin = new System.Windows.Forms.Padding(4);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.Size = new System.Drawing.Size(408, 292);
			this.usersListBox.TabIndex = 7;
			this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(433, 119);
			this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(132, 22);
			this.emailTextBox.TabIndex = 5;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(433, 87);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(132, 22);
			this.nameTextBox.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.notAdminRadioButton);
			this.panel1.Controls.Add(this.adminRadioButton);
			this.panel1.Location = new System.Drawing.Point(433, 151);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 33);
			this.panel1.TabIndex = 12;
			// 
			// notAdminRadioButton
			// 
			this.notAdminRadioButton.AutoSize = true;
			this.notAdminRadioButton.Location = new System.Drawing.Point(72, 5);
			this.notAdminRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.notAdminRadioButton.Name = "notAdminRadioButton";
			this.notAdminRadioButton.Size = new System.Drawing.Size(42, 20);
			this.notAdminRadioButton.TabIndex = 1;
			this.notAdminRadioButton.TabStop = true;
			this.notAdminRadioButton.Text = "No";
			this.notAdminRadioButton.UseVisualStyleBackColor = true;
			// 
			// adminRadioButton
			// 
			this.adminRadioButton.AutoSize = true;
			this.adminRadioButton.Location = new System.Drawing.Point(4, 5);
			this.adminRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.adminRadioButton.Name = "adminRadioButton";
			this.adminRadioButton.Size = new System.Drawing.Size(50, 20);
			this.adminRadioButton.TabIndex = 0;
			this.adminRadioButton.TabStop = true;
			this.adminRadioButton.Text = "Yes";
			this.adminRadioButton.UseVisualStyleBackColor = true;
			// 
			// passwordButton
			// 
			this.passwordButton.Location = new System.Drawing.Point(433, 192);
			this.passwordButton.Margin = new System.Windows.Forms.Padding(4);
			this.passwordButton.Name = "passwordButton";
			this.passwordButton.Size = new System.Drawing.Size(133, 28);
			this.passwordButton.TabIndex = 13;
			this.passwordButton.Text = "Set Pass...";
			this.passwordButton.UseVisualStyleBackColor = true;
			this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(433, 228);
			this.saveButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(133, 28);
			this.saveButton.TabIndex = 14;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(433, 263);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(133, 28);
			this.deleteButton.TabIndex = 15;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(437, 350);
			this.closeButton.Margin = new System.Windows.Forms.Padding(4);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(129, 28);
			this.closeButton.TabIndex = 16;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// addUserButton
			// 
			this.addUserButton.Location = new System.Drawing.Point(433, 1);
			this.addUserButton.Margin = new System.Windows.Forms.Padding(4);
			this.addUserButton.Name = "addUserButton";
			this.addUserButton.Size = new System.Drawing.Size(133, 28);
			this.addUserButton.TabIndex = 17;
			this.addUserButton.Text = "Add User...";
			this.addUserButton.UseVisualStyleBackColor = true;
			this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 416);
			this.Controls.Add(this.addUserButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.passwordButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.searchModePanel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.usersListBox);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "EditUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "User Management";
			this.searchModePanel.ResumeLayout(false);
			this.searchModePanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel searchModePanel;
		private System.Windows.Forms.RadioButton emailRadioButton;
		private System.Windows.Forms.RadioButton nameRadioButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.ListBox usersListBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton notAdminRadioButton;
		private System.Windows.Forms.RadioButton adminRadioButton;
		private System.Windows.Forms.Button passwordButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button addUserButton;
	}
}