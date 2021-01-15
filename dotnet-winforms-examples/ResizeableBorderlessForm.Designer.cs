
namespace dotnet_winforms_examples
{
	partial class ResizeableBorderlessForm
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
			this.verticalResizePanel = new System.Windows.Forms.Panel();
			this.resizePanel = new System.Windows.Forms.Panel();
			this.horizontalResizePanel = new System.Windows.Forms.Panel();
			this.movePanel = new System.Windows.Forms.Panel();
			this.closePanel = new System.Windows.Forms.Panel();
			this.maximizePanel = new System.Windows.Forms.Panel();
			this.minimizePanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// verticalResizePanel
			// 
			this.verticalResizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.verticalResizePanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.verticalResizePanel.Location = new System.Drawing.Point(0, 420);
			this.verticalResizePanel.Name = "verticalResizePanel";
			this.verticalResizePanel.Size = new System.Drawing.Size(764, 30);
			this.verticalResizePanel.TabIndex = 0;
			this.verticalResizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
			this.verticalResizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
			this.verticalResizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resize_MouseUp);
			// 
			// resizePanel
			// 
			this.resizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resizePanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizePanel.Location = new System.Drawing.Point(770, 420);
			this.resizePanel.Name = "resizePanel";
			this.resizePanel.Size = new System.Drawing.Size(30, 30);
			this.resizePanel.TabIndex = 1;
			this.resizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
			this.resizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
			this.resizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resize_MouseUp);
			// 
			// horizontalResizePanel
			// 
			this.horizontalResizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.horizontalResizePanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.horizontalResizePanel.Location = new System.Drawing.Point(770, 36);
			this.horizontalResizePanel.Name = "horizontalResizePanel";
			this.horizontalResizePanel.Size = new System.Drawing.Size(30, 378);
			this.horizontalResizePanel.TabIndex = 1;
			this.horizontalResizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
			this.horizontalResizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
			this.horizontalResizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resize_MouseUp);
			// 
			// movePanel
			// 
			this.movePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.movePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.movePanel.Location = new System.Drawing.Point(0, 0);
			this.movePanel.Name = "movePanel";
			this.movePanel.Size = new System.Drawing.Size(692, 30);
			this.movePanel.TabIndex = 1;
			this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_MouseDown);
			this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move_MouseMove);
			this.movePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_MouseUp);
			// 
			// closePanel
			// 
			this.closePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closePanel.Location = new System.Drawing.Point(770, 0);
			this.closePanel.Name = "closePanel";
			this.closePanel.Size = new System.Drawing.Size(30, 30);
			this.closePanel.TabIndex = 1;
			this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
			// 
			// maximizePanel
			// 
			this.maximizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maximizePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.maximizePanel.Location = new System.Drawing.Point(734, 0);
			this.maximizePanel.Name = "maximizePanel";
			this.maximizePanel.Size = new System.Drawing.Size(30, 30);
			this.maximizePanel.TabIndex = 1;
			this.maximizePanel.Click += new System.EventHandler(this.maximizePanel_Click);
			// 
			// minimizePanel
			// 
			this.minimizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.minimizePanel.Location = new System.Drawing.Point(698, 0);
			this.minimizePanel.Name = "minimizePanel";
			this.minimizePanel.Size = new System.Drawing.Size(30, 30);
			this.minimizePanel.TabIndex = 1;
			this.minimizePanel.Click += new System.EventHandler(this.minimizePanel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "This form has no border and is still moveable, \r\nresizeable, min/max-imizable, an" +
    "d has a close button.";
			// 
			// ResizeableBorderlessForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.minimizePanel);
			this.Controls.Add(this.maximizePanel);
			this.Controls.Add(this.closePanel);
			this.Controls.Add(this.movePanel);
			this.Controls.Add(this.horizontalResizePanel);
			this.Controls.Add(this.resizePanel);
			this.Controls.Add(this.verticalResizePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ResizeableBorderlessForm";
			this.Text = "ResizeableBorderlessForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel verticalResizePanel;
		private System.Windows.Forms.Panel resizePanel;
		private System.Windows.Forms.Panel horizontalResizePanel;
		private System.Windows.Forms.Panel movePanel;
		private System.Windows.Forms.Panel closePanel;
		private System.Windows.Forms.Panel maximizePanel;
		private System.Windows.Forms.Panel minimizePanel;
		private System.Windows.Forms.Label label1;
	}
}