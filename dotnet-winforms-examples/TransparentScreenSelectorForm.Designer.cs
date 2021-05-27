
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
			this.move1Panel = new System.Windows.Forms.Panel();
			this.horizontalResizeRightPanel = new System.Windows.Forms.Panel();
			this.resizeBottomRightPanel = new System.Windows.Forms.Panel();
			this.verticalResizeBottomPanel = new System.Windows.Forms.Panel();
			this.resizeTopRightPanel = new System.Windows.Forms.Panel();
			this.resizeTopLeftPanel = new System.Windows.Forms.Panel();
			this.resizeBottomLeftPanel = new System.Windows.Forms.Panel();
			this.horizontalResizeLeftPanel = new System.Windows.Forms.Panel();
			this.move2Panel = new System.Windows.Forms.Panel();
			this.verticalResizeTopPanel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// move1Panel
			// 
			this.move1Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.move1Panel.BackColor = System.Drawing.Color.Blue;
			this.move1Panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.move1Panel.Location = new System.Drawing.Point(375, 220);
			this.move1Panel.Name = "move1Panel";
			this.move1Panel.Size = new System.Drawing.Size(50, 10);
			this.move1Panel.TabIndex = 3;
			this.move1Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			this.move1Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
			this.move1Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
			// 
			// horizontalResizeRightPanel
			// 
			this.horizontalResizeRightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.horizontalResizeRightPanel.BackColor = System.Drawing.Color.Blue;
			this.horizontalResizeRightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.horizontalResizeRightPanel.Location = new System.Drawing.Point(795, 10);
			this.horizontalResizeRightPanel.Name = "horizontalResizeRightPanel";
			this.horizontalResizeRightPanel.Size = new System.Drawing.Size(5, 428);
			this.horizontalResizeRightPanel.TabIndex = 4;
			this.horizontalResizeRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.horizontalResizeRightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.horizontalResizeRightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// resizeBottomRightPanel
			// 
			this.resizeBottomRightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resizeBottomRightPanel.BackColor = System.Drawing.Color.Blue;
			this.resizeBottomRightPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizeBottomRightPanel.Location = new System.Drawing.Point(780, 430);
			this.resizeBottomRightPanel.Name = "resizeBottomRightPanel";
			this.resizeBottomRightPanel.Size = new System.Drawing.Size(20, 20);
			this.resizeBottomRightPanel.TabIndex = 5;
			this.resizeBottomRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.resizeBottomRightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.resizeBottomRightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// verticalResizeBottomPanel
			// 
			this.verticalResizeBottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.verticalResizeBottomPanel.BackColor = System.Drawing.Color.Blue;
			this.verticalResizeBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.verticalResizeBottomPanel.Location = new System.Drawing.Point(10, 445);
			this.verticalResizeBottomPanel.Name = "verticalResizeBottomPanel";
			this.verticalResizeBottomPanel.Size = new System.Drawing.Size(790, 5);
			this.verticalResizeBottomPanel.TabIndex = 2;
			this.verticalResizeBottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.verticalResizeBottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.verticalResizeBottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// resizeTopRightPanel
			// 
			this.resizeTopRightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.resizeTopRightPanel.BackColor = System.Drawing.Color.Blue;
			this.resizeTopRightPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.resizeTopRightPanel.Location = new System.Drawing.Point(780, 0);
			this.resizeTopRightPanel.Name = "resizeTopRightPanel";
			this.resizeTopRightPanel.Size = new System.Drawing.Size(20, 20);
			this.resizeTopRightPanel.TabIndex = 6;
			this.resizeTopRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.resizeTopRightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.resizeTopRightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// resizeTopLeftPanel
			// 
			this.resizeTopLeftPanel.BackColor = System.Drawing.Color.Blue;
			this.resizeTopLeftPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizeTopLeftPanel.Location = new System.Drawing.Point(0, 0);
			this.resizeTopLeftPanel.Name = "resizeTopLeftPanel";
			this.resizeTopLeftPanel.Size = new System.Drawing.Size(20, 20);
			this.resizeTopLeftPanel.TabIndex = 7;
			this.resizeTopLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.resizeTopLeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.resizeTopLeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// resizeBottomLeftPanel
			// 
			this.resizeBottomLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resizeBottomLeftPanel.BackColor = System.Drawing.Color.Blue;
			this.resizeBottomLeftPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.resizeBottomLeftPanel.Location = new System.Drawing.Point(0, 430);
			this.resizeBottomLeftPanel.Name = "resizeBottomLeftPanel";
			this.resizeBottomLeftPanel.Size = new System.Drawing.Size(20, 20);
			this.resizeBottomLeftPanel.TabIndex = 8;
			this.resizeBottomLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.resizeBottomLeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.resizeBottomLeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// horizontalResizeLeftPanel
			// 
			this.horizontalResizeLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.horizontalResizeLeftPanel.BackColor = System.Drawing.Color.Blue;
			this.horizontalResizeLeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.horizontalResizeLeftPanel.Location = new System.Drawing.Point(0, 12);
			this.horizontalResizeLeftPanel.Name = "horizontalResizeLeftPanel";
			this.horizontalResizeLeftPanel.Size = new System.Drawing.Size(5, 426);
			this.horizontalResizeLeftPanel.TabIndex = 9;
			this.horizontalResizeLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.horizontalResizeLeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.horizontalResizeLeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// move2Panel
			// 
			this.move2Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.move2Panel.BackColor = System.Drawing.Color.Blue;
			this.move2Panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.move2Panel.Location = new System.Drawing.Point(395, 200);
			this.move2Panel.Name = "move2Panel";
			this.move2Panel.Size = new System.Drawing.Size(10, 50);
			this.move2Panel.TabIndex = 10;
			this.move2Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			this.move2Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
			this.move2Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
			// 
			// verticalResizeTopPanel
			// 
			this.verticalResizeTopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.verticalResizeTopPanel.BackColor = System.Drawing.Color.Blue;
			this.verticalResizeTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.verticalResizeTopPanel.Location = new System.Drawing.Point(10, 0);
			this.verticalResizeTopPanel.Name = "verticalResizeTopPanel";
			this.verticalResizeTopPanel.Size = new System.Drawing.Size(783, 5);
			this.verticalResizeTopPanel.TabIndex = 11;
			this.verticalResizeTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseDown);
			this.verticalResizeTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseMove);
			this.verticalResizeTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_MouseUp);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(722, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 25);
			this.button1.TabIndex = 12;
			this.button1.Text = "CLOSE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// TransparentScreenSelectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.resizeBottomRightPanel);
			this.Controls.Add(this.resizeBottomLeftPanel);
			this.Controls.Add(this.resizeTopLeftPanel);
			this.Controls.Add(this.resizeTopRightPanel);
			this.Controls.Add(this.verticalResizeTopPanel);
			this.Controls.Add(this.move2Panel);
			this.Controls.Add(this.horizontalResizeLeftPanel);
			this.Controls.Add(this.move1Panel);
			this.Controls.Add(this.horizontalResizeRightPanel);
			this.Controls.Add(this.verticalResizeBottomPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TransparentScreenSelectorForm";
			this.Text = "ScreenSelectorForm";
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenSelectorForm_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel move1Panel;
		private System.Windows.Forms.Panel horizontalResizeRightPanel;
		private System.Windows.Forms.Panel resizeBottomRightPanel;
		private System.Windows.Forms.Panel verticalResizeBottomPanel;
		private System.Windows.Forms.Panel resizeTopRightPanel;
		private System.Windows.Forms.Panel resizeTopLeftPanel;
		private System.Windows.Forms.Panel resizeBottomLeftPanel;
		private System.Windows.Forms.Panel horizontalResizeLeftPanel;
		private System.Windows.Forms.Panel move2Panel;
		private System.Windows.Forms.Panel verticalResizeTopPanel;
	}
}