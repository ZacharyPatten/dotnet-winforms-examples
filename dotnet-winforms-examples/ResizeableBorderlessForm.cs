using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class ResizeableBorderlessForm : Form
	{
		public ResizeableBorderlessForm()
		{
			InitializeComponent();
		}

		#region Resize (Horizontal + Vertical)

		bool Resizing;
		bool VerticalResizing;
		bool HorizontalResizing;
		(int X, int Y) ResizingMouseOrigin;

		private void resize_MouseDown(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Resizing = true;
				((Control)sender).Capture = true;
				ResizingMouseOrigin = (e.X, e.Y);
				VerticalResizing = sender == resizePanel || sender == verticalResizePanel;
				HorizontalResizing = sender == resizePanel || sender == horizontalResizePanel;
			}
		}

		private void resize_MouseUp(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Resizing = false;
				((Control)sender).Capture = false;
			}
		}

		private void resize_MouseMove(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				if (Resizing)
				{
					if (HorizontalResizing)
					{
						Width += e.X - ResizingMouseOrigin.X;
					}
					if (VerticalResizing)
					{
						Height += e.Y - ResizingMouseOrigin.Y;
					}
				}
			}
			else
			{
				Resizing = false;
				((Control)sender).Capture = false;
			}
		}

		#endregion

		#region Move

		bool Moving;
		(int X, int Y) MovingMouseOrigin;

		private void move_MouseDown(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Moving = true;
				movePanel.Capture = true;
				MovingMouseOrigin = (e.X, e.Y);
			}
		}

		private void move_MouseUp(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Moving = false;
				movePanel.Capture = false;
			}
		}

		private void move_MouseMove(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				if (Moving)
				{
					Left += e.X - MovingMouseOrigin.X;
					Top += e.Y - MovingMouseOrigin.Y;
				}
			}
			else
			{
				Moving = false;
				movePanel.Capture = false;
			}
		}

		#endregion

		private void closePanel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void maximizePanel_Click(object sender, EventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
			}
			else if (WindowState is FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
		}

		private void minimizePanel_Click(object sender, EventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}
			else if (WindowState is FormWindowState.Minimized)
			{
				WindowState = FormWindowState.Normal;
			}
		}
	}
}
