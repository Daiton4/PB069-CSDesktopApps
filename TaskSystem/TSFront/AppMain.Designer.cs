namespace TSFront
{
	partial class AppMain
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
			this.taskListBox = new System.Windows.Forms.ListBox();
			this.tasksLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timeLabel = new System.Windows.Forms.Label();
			this.prereqListBox = new System.Windows.Forms.ListBox();
			this.prereqLabel = new System.Windows.Forms.Label();
			this.editPrereqButton = new System.Windows.Forms.Button();
			this.userLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// taskListBox
			// 
			this.taskListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taskListBox.FormattingEnabled = true;
			this.taskListBox.ItemHeight = 16;
			this.taskListBox.Location = new System.Drawing.Point(18, 112);
			this.taskListBox.Margin = new System.Windows.Forms.Padding(4);
			this.taskListBox.Name = "taskListBox";
			this.taskListBox.Size = new System.Drawing.Size(483, 324);
			this.taskListBox.TabIndex = 0;
			this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.taskListBox_SelectedIndexChanged);
			this.taskListBox.SelectedValueChanged += new System.EventHandler(this.taskListBox_SelectedValueChanged);
			// 
			// tasksLabel
			// 
			this.tasksLabel.AutoSize = true;
			this.tasksLabel.Location = new System.Drawing.Point(16, 71);
			this.tasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.tasksLabel.Name = "tasksLabel";
			this.tasksLabel.Size = new System.Drawing.Size(72, 16);
			this.tasksLabel.TabIndex = 1;
			this.tasksLabel.Text = "My Tasks";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(853, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// applicationToolStripMenuItem
			// 
			this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
			this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.applicationToolStripMenuItem.Text = "Application";
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// taskToolStripMenuItem
			// 
			this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem});
			this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
			this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
			this.taskToolStripMenuItem.Text = "Task";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem.Text = "Add...";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.editToolStripMenuItem.Text = "Edit...";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// administrationToolStripMenuItem
			// 
			this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserToolStripMenuItem,
            this.editUsersToolStripMenuItem});
			this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
			this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.administrationToolStripMenuItem.Text = "Administration";
			// 
			// changeUserToolStripMenuItem
			// 
			this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
			this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.changeUserToolStripMenuItem.Text = "Change User....";
			this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
			// 
			// editUsersToolStripMenuItem
			// 
			this.editUsersToolStripMenuItem.Name = "editUsersToolStripMenuItem";
			this.editUsersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.editUsersToolStripMenuItem.Text = "Edit Users...";
			this.editUsersToolStripMenuItem.Click += new System.EventHandler(this.editUsersToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.helpToolStripMenuItem.Text = "Help...";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(299, 71);
			this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(104, 16);
			this.timeLabel.TabIndex = 3;
			this.timeLabel.Text = "Total Time :";
			// 
			// prereqListBox
			// 
			this.prereqListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prereqListBox.FormattingEnabled = true;
			this.prereqListBox.ItemHeight = 16;
			this.prereqListBox.Location = new System.Drawing.Point(509, 144);
			this.prereqListBox.Margin = new System.Windows.Forms.Padding(4);
			this.prereqListBox.Name = "prereqListBox";
			this.prereqListBox.Size = new System.Drawing.Size(311, 292);
			this.prereqListBox.TabIndex = 4;
			// 
			// prereqLabel
			// 
			this.prereqLabel.AutoSize = true;
			this.prereqLabel.Location = new System.Drawing.Point(509, 111);
			this.prereqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.prereqLabel.Name = "prereqLabel";
			this.prereqLabel.Size = new System.Drawing.Size(120, 16);
			this.prereqLabel.TabIndex = 5;
			this.prereqLabel.Text = "Prerequisities";
			// 
			// editPrereqButton
			// 
			this.editPrereqButton.Location = new System.Drawing.Point(721, 105);
			this.editPrereqButton.Margin = new System.Windows.Forms.Padding(4);
			this.editPrereqButton.Name = "editPrereqButton";
			this.editPrereqButton.Size = new System.Drawing.Size(100, 28);
			this.editPrereqButton.TabIndex = 6;
			this.editPrereqButton.Text = "Edit...";
			this.editPrereqButton.UseVisualStyleBackColor = true;
			this.editPrereqButton.Click += new System.EventHandler(this.editPrereqButton_Click);
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point(16, 30);
			this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(72, 16);
			this.userLabel.TabIndex = 7;
			this.userLabel.Text = "As User:";
			this.userLabel.Visible = false;
			// 
			// AppMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 473);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.editPrereqButton);
			this.Controls.Add(this.prereqLabel);
			this.Controls.Add(this.prereqListBox);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.tasksLabel);
			this.Controls.Add(this.taskListBox);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AppMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AppMain";
			this.SizeChanged += new System.EventHandler(this.AppMain_SizeChanged);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox taskListBox;
		private System.Windows.Forms.Label tasksLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.ListBox prereqListBox;
		private System.Windows.Forms.Label prereqLabel;
		private System.Windows.Forms.Button editPrereqButton;
		private System.Windows.Forms.ToolStripMenuItem editUsersToolStripMenuItem;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
	}
}