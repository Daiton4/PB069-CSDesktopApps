namespace TSFront
{
	partial class ChangeUserForm
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
			this.usersListBox = new System.Windows.Forms.ListBox();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.emailRadioButton = new System.Windows.Forms.RadioButton();
			this.nameRadioButton = new System.Windows.Forms.RadioButton();
			this.searchModePanel = new System.Windows.Forms.Panel();
			this.selectButton = new System.Windows.Forms.Button();
			this.searchModePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// usersListBox
			// 
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.ItemHeight = 16;
			this.usersListBox.Location = new System.Drawing.Point(16, 97);
			this.usersListBox.Margin = new System.Windows.Forms.Padding(4);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.Size = new System.Drawing.Size(408, 292);
			this.usersListBox.TabIndex = 4;
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(16, 15);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(132, 22);
			this.searchTextBox.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(325, 11);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(100, 28);
			this.searchButton.TabIndex = 3;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// emailRadioButton
			// 
			this.emailRadioButton.AutoSize = true;
			this.emailRadioButton.Checked = true;
			this.emailRadioButton.Location = new System.Drawing.Point(4, 4);
			this.emailRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.emailRadioButton.Name = "emailRadioButton";
			this.emailRadioButton.Size = new System.Drawing.Size(74, 20);
			this.emailRadioButton.TabIndex = 1;
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
			this.nameRadioButton.TabIndex = 2;
			this.nameRadioButton.Text = "Name";
			this.nameRadioButton.UseVisualStyleBackColor = true;
			// 
			// searchModePanel
			// 
			this.searchModePanel.Controls.Add(this.emailRadioButton);
			this.searchModePanel.Controls.Add(this.nameRadioButton);
			this.searchModePanel.Location = new System.Drawing.Point(159, 15);
			this.searchModePanel.Margin = new System.Windows.Forms.Padding(4);
			this.searchModePanel.Name = "searchModePanel";
			this.searchModePanel.Size = new System.Drawing.Size(159, 62);
			this.searchModePanel.TabIndex = 5;
			// 
			// selectButton
			// 
			this.selectButton.Location = new System.Drawing.Point(163, 391);
			this.selectButton.Margin = new System.Windows.Forms.Padding(4);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(100, 28);
			this.selectButton.TabIndex = 6;
			this.selectButton.Text = "Select";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			// 
			// ChangeUserForm
			// 
			this.AcceptButton = this.selectButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 434);
			this.Controls.Add(this.selectButton);
			this.Controls.Add(this.searchModePanel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.usersListBox);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ChangeUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Change User";
			this.searchModePanel.ResumeLayout(false);
			this.searchModePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox usersListBox;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.RadioButton emailRadioButton;
		private System.Windows.Forms.RadioButton nameRadioButton;
		private System.Windows.Forms.Panel searchModePanel;
		private System.Windows.Forms.Button selectButton;
	}
}