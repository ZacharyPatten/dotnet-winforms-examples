using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public class RoundButton : Control
	{
		private bool _mouseDown = false;
		private bool _mouseOver = false;
		private Color _color = Color.Red;
		public Color Color { get { return _color; } set { _color = value; Refresh(); } }
		private Color _mouseOverColor = Color.DarkRed;
		public Color MouseOverColor { get { return _mouseOverColor; } set { _mouseOverColor = value; Refresh(); } }
		private Color _mouseDownColor = Color.Salmon;
		public Color MouseDownColor { get { return _mouseDownColor; } set { _mouseDownColor = value; Refresh(); } }
		private InterpolationMode _interpolationMode = InterpolationMode.High;
		public InterpolationMode InterpolationMode { get { return _interpolationMode; } set { _interpolationMode = value; Refresh(); } }
		private CompositingQuality _compositingQuality = CompositingQuality.HighQuality;
		public CompositingQuality CompositingQuality { get { return _compositingQuality; } set { _compositingQuality = value; Refresh(); } }
		private PixelOffsetMode _pixelOffsetMode = PixelOffsetMode.HighQuality;
		public PixelOffsetMode PixelOffsetMode { get { return _pixelOffsetMode; } set { _pixelOffsetMode = value; Refresh(); } }
		private SmoothingMode _smoothingMode = SmoothingMode.HighQuality;
		public SmoothingMode SmoothingMode { get { return _smoothingMode; } set { _smoothingMode = value; Refresh(); } }
		private Image _image;
		public Image Image { get { return _image; } set { _image = value; Refresh(); } }

		public RoundButton()
		{
			Width = 50;
			Height = 50;
			Cursor = Cursors.Hand;
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			_mouseOver = true;
			base.OnMouseEnter(e);
			Refresh();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			_mouseOver = false;
			base.OnMouseLeave(e);
			Refresh();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			_mouseDown = true;
			base.OnMouseDown(e);
			Refresh();
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			_mouseDown = false;
			base.OnMouseUp(e);
			Refresh();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (Parent is not null) BackColor = Parent.BackColor;
			Color color =
				_mouseDown ? _mouseDownColor :
				_mouseOver ? _mouseOverColor :
				_color;
			SolidBrush solidBrush = new(color);
			e.Graphics.InterpolationMode = _interpolationMode;
			e.Graphics.CompositingQuality = _compositingQuality;
			e.Graphics.PixelOffsetMode = _pixelOffsetMode;
			e.Graphics.SmoothingMode = _smoothingMode;
			e.Graphics.FillEllipse(solidBrush, new(0, 0, Width, Height));

			if (_image is not null)
			{
				int left = (Width - _image.Width) / 2;
				int top = (Height - _image.Height) / 2;
				e.Graphics.DrawImage(_image, new Point(left, top));
			}
		}
	}
}
