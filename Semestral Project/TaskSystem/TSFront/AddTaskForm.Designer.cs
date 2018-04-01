namespace TSFront
{
	partial class AddTaskForm
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
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.timeNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(44, 108);
			this.addButton.Margin = new System.Windows.Forms.Padding(4);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(100, 28);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(152, 108);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 28);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(40, 15);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(48, 16);
			this.nameLabel.TabIndex = 2;
			this.nameLabel.Text = "Name:";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(40, 52);
			this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(40, 16);
			this.timeLabel.TabIndex = 3;
			this.timeLabel.Text = "Time";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(96, 15);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(155, 22);
			this.nameTextBox.TabIndex = 0;
			// 
			// timeNumericUpDown
			// 
			this.timeNumericUpDown.Location = new System.Drawing.Point(96, 52);
			this.timeNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.timeNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.timeNumericUpDown.Name = "timeNumericUpDown";
			this.timeNumericUpDown.Size = new System.Drawing.Size(64, 22);
			this.timeNumericUpDown.TabIndex = 1;
			// 
			// timeNumericUpDown2
			// 
			this.timeNumericUpDown2.DecimalPlaces = 2;
			this.timeNumericUpDown2.Location = new System.Drawing.Point(169, 52);
			this.timeNumericUpDown2.Margin = new System.Windows.Forms.Padding(4);
			this.timeNumericUpDown2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.timeNumericUpDown2.Name = "timeNumericUpDown2";
			this.timeNumericUpDown2.Size = new System.Drawing.Size(83, 22);
			this.timeNumericUpDown2.TabIndex = 2;
			// 
			// AddTaskForm
			// 
			this.AcceptButton = this.addButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(304, 154);
			this.Controls.Add(this.timeNumericUpDown2);
			this.Controls.Add(this.timeNumericUpDown);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddTaskForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Enter Task Data";
			((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.NumericUpDown timeNumericUpDown;
		private System.Windows.Forms.NumericUpDown timeNumericUpDown2;
	}
}