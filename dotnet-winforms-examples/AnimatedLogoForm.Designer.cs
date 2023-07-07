namespace dotnet_winforms_examples;

partial class AnimatedLogoForm
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
		pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		// 
		// pictureBox1
		// 
		pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		pictureBox1.Image = Properties.Resources.circle;
		pictureBox1.Location = new System.Drawing.Point(0, 0);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(100, 100);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		pictureBox1.MouseDown += Move_MouseDown;
		pictureBox1.MouseMove += Move_MouseMove;
		pictureBox1.MouseUp += Move_MouseUp;
		// 
		// AnimatedLogoForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(100, 100);
		Controls.Add(pictureBox1);
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		Name = "AnimatedLogoForm";
		Text = "AnimatedLogoForm";
		TransparencyKey = System.Drawing.SystemColors.Control;
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private System.Windows.Forms.PictureBox pictureBox1;
}