
namespace dotnet_winforms_examples
{
	partial class ResizeAnimationUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.resizingButton = new System.Windows.Forms.Button();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.widthSelector = new System.Windows.Forms.NumericUpDown();
			this.widthLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.heightSelector = new System.Windows.Forms.NumericUpDown();
			this.durationLabel = new System.Windows.Forms.Label();
			this.durationSelector = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.widthSelector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightSelector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.durationSelector)).BeginInit();
			this.SuspendLayout();
			// 
			// resizingButton
			// 
			this.resizingButton.BackColor = System.Drawing.Color.Silver;
			this.resizingButton.FlatAppearance.BorderSize = 0;
			this.resizingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resizingButton.Location = new System.Drawing.Point(39, 71);
			this.resizingButton.Name = "resizingButton";
			this.resizingButton.Size = new System.Drawing.Size(77, 39);
			this.resizingButton.TabIndex = 0;
			this.resizingButton.Text = "Click Me";
			this.resizingButton.UseVisualStyleBackColor = false;
			this.resizingButton.Click += new System.EventHandler(this.ResizingButton_Click);
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(15, 15);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(508, 15);
			this.descriptionLabel.TabIndex = 1;
			this.descriptionLabel.Text = "This is a demo of animated control resizing. Click the button and it will animate" +
    " to the new size.";
			// 
			// widthSelector
			// 
			this.widthSelector.Location = new System.Drawing.Point(87, 42);
			this.widthSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.widthSelector.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.widthSelector.Name = "widthSelector";
			this.widthSelector.Size = new System.Drawing.Size(58, 23);
			this.widthSelector.TabIndex = 2;
			this.widthSelector.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(39, 44);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(42, 15);
			this.widthLabel.TabIndex = 3;
			this.widthLabel.Text = "Width:";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(155, 44);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(46, 15);
			this.heightLabel.TabIndex = 5;
			this.heightLabel.Text = "Height:";
			// 
			// heightSelector
			// 
			this.heightSelector.Location = new System.Drawing.Point(207, 42);
			this.heightSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.heightSelector.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.heightSelector.Name = "heightSelector";
			this.heightSelector.Size = new System.Drawing.Size(58, 23);
			this.heightSelector.TabIndex = 4;
			this.heightSelector.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// durationLabel
			// 
			this.durationLabel.AutoSize = true;
			this.durationLabel.Location = new System.Drawing.Point(282, 44);
			this.durationLabel.Name = "durationLabel";
			this.durationLabel.Size = new System.Drawing.Size(133, 15);
			this.durationLabel.TabIndex = 7;
			this.durationLabel.Text = "Duration (milliseconds):";
			// 
			// durationSelector
			// 
			this.durationSelector.Location = new System.Drawing.Point(421, 42);
			this.durationSelector.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.durationSelector.Name = "durationSelector";
			this.durationSelector.Size = new System.Drawing.Size(58, 23);
			this.durationSelector.TabIndex = 6;
			this.durationSelector.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// ResizeAnimationUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.durationLabel);
			this.Controls.Add(this.durationSelector);
			this.Controls.Add(this.heightLabel);
			this.Controls.Add(this.heightSelector);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.widthSelector);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.resizingButton);
			this.Name = "ResizeAnimationUserControl";
			this.Size = new System.Drawing.Size(574, 339);
			((System.ComponentModel.ISupportInitialize)(this.widthSelector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightSelector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.durationSelector)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resizingButton;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.NumericUpDown widthSelector;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label heightLabel;
		private System.Windows.Forms.NumericUpDown heightSelector;
		private System.Windows.Forms.Label durationLabel;
		private System.Windows.Forms.NumericUpDown durationSelector;
	}
}
