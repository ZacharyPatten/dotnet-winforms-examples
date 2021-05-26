
namespace dotnet_winforms_examples
{
	partial class RoundButtonExamplesUserControl
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
			this.roundButton1 = new dotnet_winforms_examples.RoundButton();
			this.roundButton2 = new dotnet_winforms_examples.RoundButton();
			this.roundButton3 = new dotnet_winforms_examples.RoundButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// roundButton1
			// 
			this.roundButton1.BackColor = System.Drawing.SystemColors.Control;
			this.roundButton1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.roundButton1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButton1.Image = null;
			this.roundButton1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			this.roundButton1.Location = new System.Drawing.Point(48, 64);
			this.roundButton1.MouseDownColor = System.Drawing.Color.Maroon;
			this.roundButton1.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.roundButton1.Name = "roundButton1";
			this.roundButton1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.roundButton1.Size = new System.Drawing.Size(50, 50);
			this.roundButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.roundButton1.TabIndex = 0;
			this.roundButton1.Text = "roundButton1";
			this.roundButton1.Click += new System.EventHandler(this.roundButton_Click);
			// 
			// roundButton2
			// 
			this.roundButton2.BackColor = System.Drawing.SystemColors.Control;
			this.roundButton2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.roundButton2.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButton2.Image = null;
			this.roundButton2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			this.roundButton2.Location = new System.Drawing.Point(23, 143);
			this.roundButton2.MouseDownColor = System.Drawing.Color.Navy;
			this.roundButton2.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.roundButton2.Name = "roundButton2";
			this.roundButton2.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.roundButton2.Size = new System.Drawing.Size(50, 50);
			this.roundButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.roundButton2.TabIndex = 1;
			this.roundButton2.Text = "roundButton2";
			this.roundButton2.Click += new System.EventHandler(this.roundButton_Click);
			// 
			// roundButton3
			// 
			this.roundButton3.BackColor = System.Drawing.SystemColors.Control;
			this.roundButton3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.roundButton3.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButton3.Image = global::dotnet_winforms_examples.Properties.Resources.ButtonImage;
			this.roundButton3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			this.roundButton3.Location = new System.Drawing.Point(153, 111);
			this.roundButton3.MouseDownColor = System.Drawing.Color.Purple;
			this.roundButton3.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.roundButton3.Name = "roundButton3";
			this.roundButton3.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.roundButton3.Size = new System.Drawing.Size(50, 50);
			this.roundButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.roundButton3.TabIndex = 2;
			this.roundButton3.Text = "roundButton3";
			this.roundButton3.Click += new System.EventHandler(this.roundButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "These circles are buttons. Click them.";
			// 
			// RoundButtonExamplesUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.roundButton3);
			this.Controls.Add(this.roundButton2);
			this.Controls.Add(this.roundButton1);
			this.Name = "RoundButtonExamplesUserControl";
			this.Size = new System.Drawing.Size(266, 252);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RoundButton roundButton1;
		private RoundButton roundButton2;
		private RoundButton roundButton3;
		private System.Windows.Forms.Label label1;
	}
}
