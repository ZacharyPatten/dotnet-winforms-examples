using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class FadeInFadeOutControl : UserControl
	{
		readonly Color originalColor;

		public FadeInFadeOutControl()
		{
			InitializeComponent();
			originalColor = label.ForeColor;
		}

		private void Label_Click(object sender, EventArgs e)
		{
			// Note: I should be using a Timer here instead of locking the UI thread, but this was
			// just to demonstrate fade-in-fade-out, not using timers.

			DateTime start = DateTime.Now;
			TimeSpan duration = TimeSpan.FromSeconds(1);
			TimeSpan interpolation;
			Color a = label.ForeColor;
			Color b = a != originalColor
				? originalColor
				: label.Parent.BackColor;
			while ((interpolation = DateTime.Now - start) < duration)
			{
				double ratio = interpolation.TotalSeconds / duration.TotalSeconds;
				double alpha = a.A - ((a.A - b.A) * ratio);
				double red = a.R - ((a.R - b.R) * ratio);
				double green = a.G - ((a.G - b.G) * ratio);
				double blue = a.B - ((a.B - b.B) * ratio);
				label.ForeColor = Color.FromArgb((byte)alpha, (byte)red, (byte)green, (byte)blue);
				label.Refresh();
			}
			label.ForeColor = b;
			label.Refresh();
		}
	}
}
