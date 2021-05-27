
namespace dotnet_winforms_examples
{
	partial class FadeInFadeOutControl
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
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label.AutoSize = true;
			this.label.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label.Location = new System.Drawing.Point(97, 48);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(169, 15);
			this.label.TabIndex = 0;
			this.label.Text = "Click Me! I will fade in and out!";
			this.label.Click += new System.EventHandler(this.Label_Click);
			// 
			// FadeInFadeOutControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label);
			this.Name = "FadeInFadeOutControl";
			this.Size = new System.Drawing.Size(357, 117);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label;
	}
}
