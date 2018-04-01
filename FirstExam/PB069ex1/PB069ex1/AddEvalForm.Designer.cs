namespace PB069ex1
{
	partial class AddEvalForm
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
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gradeComboBox = new System.Windows.Forms.ComboBox();
			this.classComboBox = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(108, 46);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(121, 20);
			this.nameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Grade";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Class";
			// 
			// gradeComboBox
			// 
			this.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gradeComboBox.FormattingEnabled = true;
			this.gradeComboBox.Location = new System.Drawing.Point(108, 72);
			this.gradeComboBox.Name = "gradeComboBox";
			this.gradeComboBox.Size = new System.Drawing.Size(121, 21);
			this.gradeComboBox.TabIndex = 4;
			// 
			// classComboBox
			// 
			this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.classComboBox.FormattingEnabled = true;
			this.classComboBox.Location = new System.Drawing.Point(108, 99);
			this.classComboBox.Name = "classComboBox";
			this.classComboBox.Size = new System.Drawing.Size(121, 21);
			this.classComboBox.TabIndex = 5;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(59, 181);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(156, 181);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// AddEvalForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(314, 251);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.classComboBox);
			this.Controls.Add(this.gradeComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTextBox);
			this.Name = "AddEvalForm";
			this.Text = "Add New Evaluation";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox gradeComboBox;
		private System.Windows.Forms.ComboBox classComboBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
	}
}