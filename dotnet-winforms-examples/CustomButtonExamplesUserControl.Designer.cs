
namespace dotnet_winforms_examples
{
	partial class CustomButtonExamplesUserControl
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
			this.label2 = new System.Windows.Forms.Label();
			this.borderedButton1 = new dotnet_winforms_examples.BorderedButton();
			this.borderedButton2 = new dotnet_winforms_examples.BorderedButton();
			this.borderedButton3 = new dotnet_winforms_examples.BorderedButton();
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
			this.roundButton1.Location = new System.Drawing.Point(66, 81);
			this.roundButton1.MouseDownColor = System.Drawing.Color.Maroon;
			this.roundButton1.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.roundButton1.Name = "roundButton1";
			this.roundButton1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.roundButton1.Size = new System.Drawing.Size(50, 50);
			this.roundButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.roundButton1.TabIndex = 0;
			this.roundButton1.Text = "roundButton1";
			this.roundButton1.Click += new System.EventHandler(this.Button_Click);
			// 
			// roundButton2
			// 
			this.roundButton2.BackColor = System.Drawing.SystemColors.Control;
			this.roundButton2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.roundButton2.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButton2.Image = null;
			this.roundButton2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			this.roundButton2.Location = new System.Drawing.Point(145, 81);
			this.roundButton2.MouseDownColor = System.Drawing.Color.Navy;
			this.roundButton2.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.roundButton2.Name = "roundButton2";
			this.roundButton2.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.roundButton2.Size = new System.Drawing.Size(50, 50);
			this.roundButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.roundButton2.TabIndex = 1;
			this.roundButton2.Text = "roundButton2";
			this.roundButton2.Click += new System.EventHandler(this.Button_Click);
			// 
			// roundButton3
			// 
			this.roundButton3.BackColor = System.Drawing.SystemColors.Control;
			this.roundButton3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.roundButton3.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButton3.Image = global::dotnet_winforms_examples.Properties.Resources.ButtonImage;
			this.roundButton3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			this.roundButton3.Location = new System.Drawing.Point(223, 81);
			this.roundButton3.MouseDownColor = System.Drawing.Color.Purple;
			this.roundButton3.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.roundButton3.Name = "roundButton3";
			this.roundButton3.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.roundButton3.Size = new System.Drawing.Size(50, 50);
			this.roundButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.roundButton3.TabIndex = 2;
			this.roundButton3.Text = "roundButton3";
			this.roundButton3.Click += new System.EventHandler(this.Button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Circle Buttons";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Custom Borders";
			// 
			// borderedButton1
			// 
			this.borderedButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.borderedButton1.BottomButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton1.BottomColor = System.Drawing.Color.DarkCyan;
			this.borderedButton1.BottomWidth = 5;
			this.borderedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.borderedButton1.FlatAppearance.BorderSize = 0;
			this.borderedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.borderedButton1.LeftButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton1.LeftColor = System.Drawing.Color.Blue;
			this.borderedButton1.LeftWidth = 5;
			this.borderedButton1.Location = new System.Drawing.Point(66, 194);
			this.borderedButton1.Name = "borderedButton1";
			this.borderedButton1.RightButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton1.RightColor = System.Drawing.Color.DarkBlue;
			this.borderedButton1.RightWidth = 5;
			this.borderedButton1.Size = new System.Drawing.Size(131, 50);
			this.borderedButton1.TabIndex = 5;
			this.borderedButton1.Text = "borderedButton1";
			this.borderedButton1.TopButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton1.TopColor = System.Drawing.Color.Cyan;
			this.borderedButton1.TopWidth = 5;
			this.borderedButton1.UseVisualStyleBackColor = false;
			this.borderedButton1.Click += new System.EventHandler(this.Button_Click);
			// 
			// borderedButton2
			// 
			this.borderedButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.borderedButton2.BottomButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.borderedButton2.BottomWidth = 5;
			this.borderedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.borderedButton2.FlatAppearance.BorderSize = 0;
			this.borderedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.borderedButton2.LeftButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton2.LeftColor = System.Drawing.Color.Blue;
			this.borderedButton2.LeftWidth = 0;
			this.borderedButton2.Location = new System.Drawing.Point(214, 194);
			this.borderedButton2.Name = "borderedButton2";
			this.borderedButton2.RightButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton2.RightColor = System.Drawing.Color.DarkBlue;
			this.borderedButton2.RightWidth = 0;
			this.borderedButton2.Size = new System.Drawing.Size(131, 50);
			this.borderedButton2.TabIndex = 6;
			this.borderedButton2.Text = "borderedButton2";
			this.borderedButton2.TopButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton2.TopColor = System.Drawing.Color.Cyan;
			this.borderedButton2.TopWidth = 0;
			this.borderedButton2.UseVisualStyleBackColor = false;
			this.borderedButton2.Click += new System.EventHandler(this.Button_Click);
			// 
			// borderedButton3
			// 
			this.borderedButton3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.borderedButton3.BottomButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton3.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.borderedButton3.BottomWidth = 0;
			this.borderedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.borderedButton3.FlatAppearance.BorderSize = 0;
			this.borderedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.borderedButton3.LeftButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton3.LeftColor = System.Drawing.Color.Blue;
			this.borderedButton3.LeftWidth = 0;
			this.borderedButton3.Location = new System.Drawing.Point(366, 194);
			this.borderedButton3.Name = "borderedButton3";
			this.borderedButton3.RightButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton3.RightColor = System.Drawing.Color.DarkBlue;
			this.borderedButton3.RightWidth = 10;
			this.borderedButton3.Size = new System.Drawing.Size(131, 50);
			this.borderedButton3.TabIndex = 7;
			this.borderedButton3.Text = "borderedButton3";
			this.borderedButton3.TopButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.borderedButton3.TopColor = System.Drawing.Color.Purple;
			this.borderedButton3.TopWidth = 10;
			this.borderedButton3.UseVisualStyleBackColor = false;
			this.borderedButton3.Click += new System.EventHandler(this.Button_Click);
			// 
			// CustomButtonExamplesUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.borderedButton3);
			this.Controls.Add(this.borderedButton2);
			this.Controls.Add(this.borderedButton1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.roundButton3);
			this.Controls.Add(this.roundButton2);
			this.Controls.Add(this.roundButton1);
			this.Name = "CustomButtonExamplesUserControl";
			this.Size = new System.Drawing.Size(632, 355);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RoundButton roundButton1;
		private RoundButton roundButton2;
		private RoundButton roundButton3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private BorderedButton borderedButton1;
		private BorderedButton borderedButton2;
		private BorderedButton borderedButton3;
	}
}
