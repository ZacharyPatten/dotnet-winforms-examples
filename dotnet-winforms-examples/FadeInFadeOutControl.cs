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
	public partial class FadeInFadeOutControl : UserControl
	{
		Color originalColor;

		public FadeInFadeOutControl()
		{
			InitializeComponent();
			originalColor = label.ForeColor;
		}

		private void label_Click(object sender, EventArgs e)
		{
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
