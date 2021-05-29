using System.Drawing;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public class BorderedButton : Button
	{
		private ButtonBorderStyle _leftButtonBorderStyle = ButtonBorderStyle.Solid;
		public ButtonBorderStyle LeftButtonBorderStyle { get { return _leftButtonBorderStyle; } set { _leftButtonBorderStyle = value; Refresh(); } }
		private Color _leftColor = Color.Blue;
		public Color LeftColor { get { return _leftColor; } set { _leftColor = value; Refresh(); } }
		private int _leftWidth = 5;
		public int LeftWidth { get { return _leftWidth; } set { _leftWidth = value; Refresh(); } }

		private ButtonBorderStyle _rightButtonBorderStyle = ButtonBorderStyle.Solid;
		public ButtonBorderStyle RightButtonBorderStyle { get { return _rightButtonBorderStyle; } set { _rightButtonBorderStyle = value; Refresh(); } }
		private Color _rightColor = Color.DarkBlue;
		public Color RightColor { get { return _rightColor; } set { _rightColor = value; Refresh(); } }
		private int _rightWidth = 5;
		public int RightWidth { get { return _rightWidth; } set { _rightWidth = value; Refresh(); } }

		private ButtonBorderStyle _topButtonBorderStyle = ButtonBorderStyle.Solid;
		public ButtonBorderStyle TopButtonBorderStyle { get { return _topButtonBorderStyle; } set { _topButtonBorderStyle = value; Refresh(); } }
		private Color _topColor = Color.Cyan;
		public Color TopColor { get { return _topColor; } set { _topColor = value; Refresh(); } }
		private int _topWidth = 5;
		public int TopWidth { get { return _topWidth; } set { _topWidth = value; Refresh(); } }

		private ButtonBorderStyle _bottomButtonBorderStyle = ButtonBorderStyle.Solid;
		public ButtonBorderStyle BottomButtonBorderStyle { get { return _bottomButtonBorderStyle; } set { _bottomButtonBorderStyle = value; Refresh(); } }
		private Color _bottomColor = Color.DarkCyan;
		public Color BottomColor { get { return _bottomColor; } set { _bottomColor = value; Refresh(); } }
		private int _bottomWidth = 5;
		public int BottomWidth { get { return _bottomWidth; } set { _bottomWidth = value; Refresh(); } }

		public BorderedButton() : base()
		{
			Width = 50;
			Height = 50;
			Cursor = Cursors.Hand;
			FlatStyle = FlatStyle.Flat;
			FlatAppearance.BorderSize = 0;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
				_leftColor, _leftWidth, _leftButtonBorderStyle,
				_topColor, _topWidth, _topButtonBorderStyle,
				_rightColor, _rightWidth, _rightButtonBorderStyle,
				_bottomColor, _bottomWidth, _bottomButtonBorderStyle);
		}
	}
}
