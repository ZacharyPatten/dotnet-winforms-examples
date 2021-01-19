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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resizeableBorderlessFormExampleButton_Click(object sender, EventArgs e)
		{
			ResizeableBorderlessForm resizeableBorderlessForm = new();
			resizeableBorderlessForm.Show();
		}

		private void sliderPuzzleExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new Form();
			SlidePuzzleControl slidePuzzleControl = new SlidePuzzleControl();
			slidePuzzleControl.Dock = DockStyle.Fill;
			form.Controls.Add(slidePuzzleControl);
			form.Show();
		}

		private void fadeInFadeOutExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new Form();
			FadeInFadeOutControl fadeInFadeOutControl = new FadeInFadeOutControl();
			fadeInFadeOutControl.Dock = DockStyle.Fill;
			form.Controls.Add(fadeInFadeOutControl);
			form.Show();
		}

		private void collisionExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new Form();
			CollisionDetectionExampleControl collisionDetectionExampleControl = new CollisionDetectionExampleControl();
			collisionDetectionExampleControl.Dock = DockStyle.Fill;
			form.Controls.Add(collisionDetectionExampleControl);
			form.Show();
		}
	}
}
