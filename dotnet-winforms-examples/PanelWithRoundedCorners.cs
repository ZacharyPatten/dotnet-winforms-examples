using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public class PanelWithRoundedCorners : Panel
	{
		public int CornerRadius { get; set; } = 20;

		public PanelWithRoundedCorners() : base() { }

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);

		protected override void OnPaint(PaintEventArgs e)
		{
			int cornerRadius = CornerRadius;
			if (cornerRadius < 0) cornerRadius = 0;
			if (cornerRadius > Width * 2) cornerRadius = Width * 2;
			if (cornerRadius > Height * 2) cornerRadius = Height * 2;
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, cornerRadius, cornerRadius));
			base.OnPaint(e);
		}
	}
}
