
namespace dotnet_winforms_examples
{
	partial class TransparentScreenSelectorForm
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
			this.movePanel = new System.Windows.Forms.Panel();
			this.horizontalResizePanel = new System.Windows.Forms.Panel();
			this.resizePanel = new System.Windows.Forms.Panel();
			this.verticalResizePanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// movePanel
			// 
			this.movePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.movePanel.BackColor = System.Drawing.Color.Blue;
			this.movePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.movePanel.Location = new System.Drawing.Point(365, 230);
			this.movePanel.Name = "movePanel";
			this.movePanel.Size = new System.Drawing.Size(57, 16);
			this.movePanel.TabIndex = 3;
			this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
			this.movePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
			// 
			// horizontalResizePanel
			// 
			this.horizontalResizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.horizontalResizePanel.BackColor = System.Drawing.Color.Blue;
			this.horizontalResizePanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.horizontalResizePanel.Location = new System.Drawing.Point(785, 28);
			this.horizontalResizePanel.Name = "horizontalResizePanel";
			this.horizontalResizePanel.Size = new System.Drawing.Size(15, 394);
			this.horizontalResizePanel.TabIndex = 4;
			this.horizontalResizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.horizontalResizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.horizontalResizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// resizePanel
			// 
			this.resizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resizePanel.BackColor = System.Drawing.Color.Blue;
			this.resizePanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizePanel.Location = new System.Drawing.Point(770, 420);
			this.resizePanel.Name = "resizePanel";
			this.resizePanel.Size = new System.Drawing.Size(30, 30);
			this.resizePanel.TabIndex = 5;
			this.resizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.resizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.resizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// verticalResizePanel
			// 
			this.verticalResizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.verticalResizePanel.BackColor = System.Drawing.Color.Blue;
			this.verticalResizePanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.verticalResizePanel.Location = new System.Drawing.Point(30, 438);
			this.verticalResizePanel.Name = "verticalResizePanel";
			this.verticalResizePanel.Size = new System.Drawing.Size(742, 12);
			this.verticalResizePanel.TabIndex = 2;
			this.verticalResizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.verticalResizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.verticalResizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Blue;
			this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.panel1.Location = new System.Drawing.Point(770, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(30, 30);
			this.panel1.TabIndex = 6;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Blue;
			this.panel2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(30, 30);
			this.panel2.TabIndex = 7;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel3.BackColor = System.Drawing.Color.Blue;
			this.panel3.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.panel3.Location = new System.Drawing.Point(0, 420);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(30, 30);
			this.panel3.TabIndex = 8;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BackColor = System.Drawing.Color.Blue;
			this.panel4.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.panel4.Location = new System.Drawing.Point(0, 28);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(15, 394);
			this.panel4.TabIndex = 9;
			this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel5.BackColor = System.Drawing.Color.Blue;
			this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.panel5.Location = new System.Drawing.Point(386, 213);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(16, 51);
			this.panel5.TabIndex = 10;
			this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
			this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.Color.Blue;
			this.panel6.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.panel6.Location = new System.Drawing.Point(30, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(742, 12);
			this.panel6.TabIndex = 11;
			this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(698, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 25);
			this.button1.TabIndex = 12;
			this.button1.Text = "CLOSE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ScreenSelectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.resizePanel);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.movePanel);
			this.Controls.Add(this.horizontalResizePanel);
			this.Controls.Add(this.verticalResizePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScreenSelectorForm";
			this.Text = "ScreenSelectorForm";
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenSelectorForm_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel movePanel;
		private System.Windows.Forms.Panel horizontalResizePanel;
		private System.Windows.Forms.Panel resizePanel;
		private System.Windows.Forms.Panel verticalResizePanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button button1;
	}
}