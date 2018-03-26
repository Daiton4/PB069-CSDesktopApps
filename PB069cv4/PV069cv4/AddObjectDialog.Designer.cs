namespace PV069cv4
{
	partial class AddObjectDialog
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.XnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.YnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.DXnumericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.DYnumericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.cancelButton = new System.Windows.Forms.Button();
			this.Xlabel = new System.Windows.Forms.Label();
			this.Ylabel = new System.Windows.Forms.Label();
			this.DXlabel = new System.Windows.Forms.Label();
			this.DYlabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.XnumericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YnumericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DXnumericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DYnumericUpDown4)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(97, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(108, 181);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// XnumericUpDown1
			// 
			this.XnumericUpDown1.Location = new System.Drawing.Point(158, 46);
			this.XnumericUpDown1.Name = "XnumericUpDown1";
			this.XnumericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.XnumericUpDown1.TabIndex = 2;
			// 
			// YnumericUpDown2
			// 
			this.YnumericUpDown2.Location = new System.Drawing.Point(158, 72);
			this.YnumericUpDown2.Name = "YnumericUpDown2";
			this.YnumericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.YnumericUpDown2.TabIndex = 3;
			// 
			// DXnumericUpDown3
			// 
			this.DXnumericUpDown3.Location = new System.Drawing.Point(158, 98);
			this.DXnumericUpDown3.Name = "DXnumericUpDown3";
			this.DXnumericUpDown3.Size = new System.Drawing.Size(120, 20);
			this.DXnumericUpDown3.TabIndex = 4;
			// 
			// DYnumericUpDown4
			// 
			this.DYnumericUpDown4.Location = new System.Drawing.Point(158, 125);
			this.DYnumericUpDown4.Name = "DYnumericUpDown4";
			this.DYnumericUpDown4.Size = new System.Drawing.Size(120, 20);
			this.DYnumericUpDown4.TabIndex = 5;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(190, 181);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// Xlabel
			// 
			this.Xlabel.AutoSize = true;
			this.Xlabel.Location = new System.Drawing.Point(94, 48);
			this.Xlabel.Name = "Xlabel";
			this.Xlabel.Size = new System.Drawing.Size(14, 13);
			this.Xlabel.TabIndex = 7;
			this.Xlabel.Text = "X";
			// 
			// Ylabel
			// 
			this.Ylabel.AutoSize = true;
			this.Ylabel.Location = new System.Drawing.Point(94, 72);
			this.Ylabel.Name = "Ylabel";
			this.Ylabel.Size = new System.Drawing.Size(14, 13);
			this.Ylabel.TabIndex = 8;
			this.Ylabel.Text = "Y";
			// 
			// DXlabel
			// 
			this.DXlabel.AutoSize = true;
			this.DXlabel.Location = new System.Drawing.Point(94, 98);
			this.DXlabel.Name = "DXlabel";
			this.DXlabel.Size = new System.Drawing.Size(22, 13);
			this.DXlabel.TabIndex = 9;
			this.DXlabel.Text = "DX";
			// 
			// DYlabel
			// 
			this.DYlabel.AutoSize = true;
			this.DYlabel.Location = new System.Drawing.Point(94, 125);
			this.DYlabel.Name = "DYlabel";
			this.DYlabel.Size = new System.Drawing.Size(22, 13);
			this.DYlabel.TabIndex = 10;
			this.DYlabel.Text = "DY";
			// 
			// AddObjectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 335);
			this.Controls.Add(this.DYlabel);
			this.Controls.Add(this.DXlabel);
			this.Controls.Add(this.Ylabel);
			this.Controls.Add(this.Xlabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.DYnumericUpDown4);
			this.Controls.Add(this.DXnumericUpDown3);
			this.Controls.Add(this.YnumericUpDown2);
			this.Controls.Add(this.XnumericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Name = "AddObjectDialog";
			this.Text = "AddObjectDialog";
			((System.ComponentModel.ISupportInitialize)(this.XnumericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YnumericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DXnumericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DYnumericUpDown4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown XnumericUpDown1;
		private System.Windows.Forms.NumericUpDown YnumericUpDown2;
		private System.Windows.Forms.NumericUpDown DXnumericUpDown3;
		private System.Windows.Forms.NumericUpDown DYnumericUpDown4;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label Xlabel;
		private System.Windows.Forms.Label Ylabel;
		private System.Windows.Forms.Label DXlabel;
		private System.Windows.Forms.Label DYlabel;
	}
}