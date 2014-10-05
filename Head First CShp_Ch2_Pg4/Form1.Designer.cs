namespace Head_First_CShp_Ch2_Pg4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.changeTextButton = new System.Windows.Forms.Button();
			this.enableCheckbox = new System.Windows.Forms.CheckBox();
			this.labelToChange = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// changeTextButton
			// 
			this.changeTextButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.changeTextButton.Location = new System.Drawing.Point(25, 36);
			this.changeTextButton.Name = "changeTextButton";
			this.changeTextButton.Size = new System.Drawing.Size(286, 23);
			this.changeTextButton.TabIndex = 0;
			this.changeTextButton.Text = "Change the label if checked. Changed text manually.";
			this.changeTextButton.UseVisualStyleBackColor = false;
			this.changeTextButton.Click += new System.EventHandler(this.changeText_Click);
			// 
			// enableCheckbox
			// 
			this.enableCheckbox.AutoSize = true;
			this.enableCheckbox.Checked = true;
			this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableCheckbox.Location = new System.Drawing.Point(420, 40);
			this.enableCheckbox.Name = "enableCheckbox";
			this.enableCheckbox.Size = new System.Drawing.Size(131, 17);
			this.enableCheckbox.TabIndex = 1;
			this.enableCheckbox.Text = "Enable label changing";
			this.enableCheckbox.UseVisualStyleBackColor = true;
			// 
			// labelToChange
			// 
			this.labelToChange.Location = new System.Drawing.Point(-2, 75);
			this.labelToChange.Name = "labelToChange";
			this.labelToChange.Size = new System.Drawing.Size(582, 23);
			this.labelToChange.TabIndex = 2;
			this.labelToChange.Text = "Press the button to change my text if checked";
			this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(72, 101);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(441, 262);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 375);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelToChange);
			this.Controls.Add(this.enableCheckbox);
			this.Controls.Add(this.changeTextButton);
			this.Name = "Form1";
			this.Text = "My Desktop App";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button changeTextButton;
		private System.Windows.Forms.CheckBox enableCheckbox;
		private System.Windows.Forms.Label labelToChange;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

