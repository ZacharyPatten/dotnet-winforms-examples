using System;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ResizeableBorderlessFormExampleButton_Click(object sender, EventArgs e)
		{
			ResizeableBorderlessForm resizeableBorderlessForm = new();
			resizeableBorderlessForm.Show();
		}

		private void SliderPuzzleExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new();
			form.Text = "Slider Puzzle Example";
			SlidePuzzleControl slidePuzzleControl = new();
			slidePuzzleControl.Dock = DockStyle.Fill;
			form.Controls.Add(slidePuzzleControl);
			form.Show();
		}

		private void FadeInFadeOutExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new();
			form.Text = "Fade In/Out Example";
			FadeInFadeOutControl fadeInFadeOutControl = new();
			fadeInFadeOutControl.Dock = DockStyle.Fill;
			form.Controls.Add(fadeInFadeOutControl);
			form.Show();
		}

		private void CollisionExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new();
			form.Text = "Collision Example";
			CollisionDetectionExampleControl collisionDetectionExampleControl = new();
			collisionDetectionExampleControl.Dock = DockStyle.Fill;
			form.Controls.Add(collisionDetectionExampleControl);
			form.Show();
		}

		private void CustomButtonExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new();
			form.Text = "Custom Button Examples";
			CustomButtonExamplesUserControl customButtonExamplesUserControl = new();
			form.Width = customButtonExamplesUserControl.Width;
			form.Height = customButtonExamplesUserControl.Height;
			customButtonExamplesUserControl.Dock = DockStyle.Fill;
			form.Controls.Add(customButtonExamplesUserControl);
			form.Show();
		}

		private void NavigationBarExampleButton_Click(object sender, EventArgs e)
		{
			Form form = new() { Width = Width, Height = Height };
			form.Text = "Navigation Bar Example";
			NavigationBarExampleUserControl navigationBarExampleUserControl = new();
			navigationBarExampleUserControl.Dock = DockStyle.Fill;
			form.Controls.Add(navigationBarExampleUserControl);
			form.Show();
		}

		private void TransparentScreenSelectorFormExampleButton_Click(object sender, EventArgs e)
		{
			TransparentScreenSelectorForm transparentScreenSelectorForm = new();
			transparentScreenSelectorForm.Show();
		}

		private void AnimatedControlResizeButton_Click(object sender, EventArgs e)
		{
			Form form = new() { Width = Width, Height = Height };
			form.Text = "Navigation Bar Example";
			ResizeAnimationUserControl resizeAnimationUserControl = new();
			resizeAnimationUserControl.Dock = DockStyle.Fill;
			form.Controls.Add(resizeAnimationUserControl);
			form.Show();
		}

		private void panelsWithRoundedCornersButton_Click(object sender, EventArgs e)
		{
			Form form = new();
			form.Text = "Panels With Rounded Corners";
			PanelWithRoundedCornersUserControl panelWithRoundedCornersUserControl = new();
			form.ClientSize = panelWithRoundedCornersUserControl.ClientSize;
			form.Controls.Add(panelWithRoundedCornersUserControl);
			form.Show();
		}

		private void animatedLogoOnLaunchButton_Click(object sender, EventArgs e)
		{
			Form form = new AnimatedLogoForm();
			form.Show();
		}
	}
}
