namespace TSFront
{
	partial class PrereqForm
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
			this.tasksListBox = new System.Windows.Forms.ListBox();
			this.addPrereqButton = new System.Windows.Forms.Button();
			this.removePrereqButton = new System.Windows.Forms.Button();
			this.prereqListBox = new System.Windows.Forms.ListBox();
			this.taskLabel = new System.Windows.Forms.Label();
			this.prereqLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tasksListBox
			// 
			this.tasksListBox.FormattingEnabled = true;
			this.tasksListBox.ItemHeight = 16;
			this.tasksListBox.Location = new System.Drawing.Point(17, 48);
			this.tasksListBox.Margin = new System.Windows.Forms.Padding(4);
			this.tasksListBox.Name = "tasksListBox";
			this.tasksListBox.Size = new System.Drawing.Size(243, 260);
			this.tasksListBox.TabIndex = 0;
			// 
			// addPrereqButton
			// 
			this.addPrereqButton.Location = new System.Drawing.Point(269, 75);
			this.addPrereqButton.Margin = new System.Windows.Forms.Padding(4);
			this.addPrereqButton.Name = "addPrereqButton";
			this.addPrereqButton.Size = new System.Drawing.Size(100, 28);
			this.addPrereqButton.TabIndex = 1;
			this.addPrereqButton.Text = "-->";
			this.addPrereqButton.UseVisualStyleBackColor = true;
			this.addPrereqButton.Click += new System.EventHandler(this.addPrereqButton_Click);
			// 
			// removePrereqButton
			// 
			this.removePrereqButton.Location = new System.Drawing.Point(269, 111);
			this.removePrereqButton.Margin = new System.Windows.Forms.Padding(4);
			this.removePrereqButton.Name = "removePrereqButton";
			this.removePrereqButton.Size = new System.Drawing.Size(100, 28);
			this.removePrereqButton.TabIndex = 2;
			this.removePrereqButton.Text = "<--";
			this.removePrereqButton.UseVisualStyleBackColor = true;
			this.removePrereqButton.Click += new System.EventHandler(this.removePrereqButton_Click);
			// 
			// prereqListBox
			// 
			this.prereqListBox.FormattingEnabled = true;
			this.prereqListBox.ItemHeight = 16;
			this.prereqListBox.Location = new System.Drawing.Point(377, 48);
			this.prereqListBox.Margin = new System.Windows.Forms.Padding(4);
			this.prereqListBox.Name = "prereqListBox";
			this.prereqListBox.Size = new System.Drawing.Size(243, 260);
			this.prereqListBox.TabIndex = 3;
			// 
			// taskLabel
			// 
			this.taskLabel.AutoSize = true;
			this.taskLabel.Location = new System.Drawing.Point(13, 11);
			this.taskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.taskLabel.Name = "taskLabel";
			this.taskLabel.Size = new System.Drawing.Size(48, 16);
			this.taskLabel.TabIndex = 4;
			this.taskLabel.Text = "Tasks";
			// 
			// prereqLabel
			// 
			this.prereqLabel.AutoSize = true;
			this.prereqLabel.Location = new System.Drawing.Point(373, 11);
			this.prereqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.prereqLabel.Name = "prereqLabel";
			this.prereqLabel.Size = new System.Drawing.Size(120, 16);
			this.prereqLabel.TabIndex = 5;
			this.prereqLabel.Text = "Prerequisities";
			this.prereqLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(269, 242);
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
			this.cancelButton.Location = new System.Drawing.Point(269, 278);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 28);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// PrereqForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 336);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.prereqLabel);
			this.Controls.Add(this.taskLabel);
			this.Controls.Add(this.prereqListBox);
			this.Controls.Add(this.removePrereqButton);
			this.Controls.Add(this.addPrereqButton);
			this.Controls.Add(this.tasksListBox);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PrereqForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox tasksListBox;
		private System.Windows.Forms.Button addPrereqButton;
		private System.Windows.Forms.Button removePrereqButton;
		private System.Windows.Forms.ListBox prereqListBox;
		private System.Windows.Forms.Label taskLabel;
		private System.Windows.Forms.Label prereqLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
	}
}