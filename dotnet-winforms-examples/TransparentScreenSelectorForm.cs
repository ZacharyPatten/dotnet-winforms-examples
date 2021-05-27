using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class TransparentScreenSelectorForm : Form
	{
		public TransparentScreenSelectorForm()
		{
			InitializeComponent();
		}

		#region Resize (Horizontal + Vertical)

		bool Resizing;
		bool VerticalResizing;
		bool HorizontalResizing;
		(int X, int Y) ResizingMouseOrigin;
		bool ResizeInvertHorizontal;
		bool ResizeInvertVertical;

		private void Resize_MouseDown(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Resizing = true;
				((Control)sender).Capture = true;
				ResizingMouseOrigin = (e.X, e.Y);
				VerticalResizing =
					sender == resizeTopLeftPanel ||
					sender == resizeBottomLeftPanel ||
					sender == resizeTopRightPanel ||
					sender == resizeBottomRightPanel ||
					sender == verticalResizeTopPanel ||
					sender == verticalResizeBottomPanel;
				HorizontalResizing =
					sender == resizeTopLeftPanel ||
					sender == resizeBottomLeftPanel ||
					sender == resizeTopRightPanel ||
					sender == resizeBottomRightPanel ||
					sender == horizontalResizeLeftPanel ||
					sender == horizontalResizeRightPanel;
				ResizeInvertHorizontal =
					sender == horizontalResizeLeftPanel ||
					sender == resizeTopLeftPanel ||
					sender == resizeBottomLeftPanel;
				ResizeInvertVertical =
					sender == verticalResizeTopPanel ||
					sender == resizeTopLeftPanel ||
					sender == resizeTopRightPanel;

			}
		}

		private void Resize_MouseUp(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Resizing = false;
				((Control)sender).Capture = false;
			}
		}

		private void Resize_MouseMove(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				if (Resizing)
				{
					if (HorizontalResizing)
					{
						if (ResizeInvertHorizontal)
						{
							Width -= e.X - ResizingMouseOrigin.X;
							Left += e.X - ResizingMouseOrigin.X;
						}
						else
						{
							Width += e.X - ResizingMouseOrigin.X;
						}
					}
					if (VerticalResizing)
					{
						if (ResizeInvertVertical)
						{
							Height -= e.Y - ResizingMouseOrigin.Y;
							Top += e.Y - ResizingMouseOrigin.Y;
						}
						else
						{
							Height += e.Y - ResizingMouseOrigin.Y;
						}
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

		private void Move_MouseDown(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Moving = true;
				((Control)sender).Capture = true;
				MovingMouseOrigin = (e.X, e.Y);
			}
		}

		private void Move_MouseUp(object sender, MouseEventArgs e)
		{
			if (WindowState is FormWindowState.Normal)
			{
				Moving = false;
				((Control)sender).Capture = false;
			}
		}

		private void Move_MouseMove(object sender, MouseEventArgs e)
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
				((Control)sender).Capture = false;
			}
		}

		#endregion

		private void ScreenSelectorForm_Paint(object sender, PaintEventArgs e)
		{
			SolidBrush solidBrush = new(Color.Blue);
			Pen pen = new(solidBrush, 5);
			e.Graphics.DrawRectangle(pen, 0, 0, Width, Height);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
