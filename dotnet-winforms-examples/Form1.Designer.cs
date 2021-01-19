
namespace dotnet_winforms_examples
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.resizeableBorderlessFormExampleButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.sliderPuzzleExampleButton = new System.Windows.Forms.Button();
			this.fadeInFadeOutExampleButton = new System.Windows.Forms.Button();
			this.collisionExampleButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// resizeableBorderlessFormExampleButton
			// 
			this.resizeableBorderlessFormExampleButton.Location = new System.Drawing.Point(12, 27);
			this.resizeableBorderlessFormExampleButton.Name = "resizeableBorderlessFormExampleButton";
			this.resizeableBorderlessFormExampleButton.Size = new System.Drawing.Size(234, 23);
			this.resizeableBorderlessFormExampleButton.TabIndex = 0;
			this.resizeableBorderlessFormExampleButton.Text = "Resizeable Borderless Form Example";
			this.resizeableBorderlessFormExampleButton.UseVisualStyleBackColor = true;
			this.resizeableBorderlessFormExampleButton.Click += new System.EventHandler(this.resizeableBorderlessFormExampleButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Examples:";
			// 
			// sliderPuzzleExampleButton
			// 
			this.sliderPuzzleExampleButton.Location = new System.Drawing.Point(12, 56);
			this.sliderPuzzleExampleButton.Name = "sliderPuzzleExampleButton";
			this.sliderPuzzleExampleButton.Size = new System.Drawing.Size(234, 23);
			this.sliderPuzzleExampleButton.TabIndex = 2;
			this.sliderPuzzleExampleButton.Text = "Slider Puzzle Example";
			this.sliderPuzzleExampleButton.UseVisualStyleBackColor = true;
			this.sliderPuzzleExampleButton.Click += new System.EventHandler(this.sliderPuzzleExampleButton_Click);
			// 
			// fadeInFadeOutExampleButton
			// 
			this.fadeInFadeOutExampleButton.Location = new System.Drawing.Point(12, 85);
			this.fadeInFadeOutExampleButton.Name = "fadeInFadeOutExampleButton";
			this.fadeInFadeOutExampleButton.Size = new System.Drawing.Size(234, 23);
			this.fadeInFadeOutExampleButton.TabIndex = 3;
			this.fadeInFadeOutExampleButton.Text = "Fade In Fade Out Example";
			this.fadeInFadeOutExampleButton.UseVisualStyleBackColor = true;
			this.fadeInFadeOutExampleButton.Click += new System.EventHandler(this.fadeInFadeOutExampleButton_Click);
			// 
			// collisionExampleButton
			// 
			this.collisionExampleButton.Location = new System.Drawing.Point(12, 114);
			this.collisionExampleButton.Name = "collisionExampleButton";
			this.collisionExampleButton.Size = new System.Drawing.Size(234, 23);
			this.collisionExampleButton.TabIndex = 4;
			this.collisionExampleButton.Text = "2D Collision Example";
			this.collisionExampleButton.UseVisualStyleBackColor = true;
			this.collisionExampleButton.Click += new System.EventHandler(this.collisionExampleButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.collisionExampleButton);
			this.Controls.Add(this.fadeInFadeOutExampleButton);
			this.Controls.Add(this.sliderPuzzleExampleButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resizeableBorderlessFormExampleButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resizeableBorderlessFormExampleButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button sliderPuzzleExampleButton;
		private System.Windows.Forms.Button fadeInFadeOutExampleButton;
		private System.Windows.Forms.Button collisionExampleButton;
	}
}

