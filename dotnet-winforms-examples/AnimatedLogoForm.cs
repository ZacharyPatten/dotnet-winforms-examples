using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace dotnet_winforms_examples;
public partial class AnimatedLogoForm : Form
{
	private FrameDimension dimension;
	private int frameCount;
	private int currentFrame = -1;
	private Stopwatch stopWatch;

	public AnimatedLogoForm()
	{
		InitializeComponent();
		dimension = new FrameDimension(pictureBox1.Image.FrameDimensionsList[0]);
		frameCount = pictureBox1.Image.GetFrameCount(dimension);
		stopWatch = Stopwatch.StartNew();
		Timer timer = new();
		timer.Interval = 1;
		timer.Tick += (_, _) =>
		{
			NextFrame();
			if (stopWatch.Elapsed > TimeSpan.FromSeconds(10))
			{
				timer.Enabled = false;
				Close();
			}
		};
		timer.Enabled = true;
	}

	public void NextFrame()
	{
		currentFrame += 1;
		if (currentFrame >= frameCount || currentFrame < 0)
		{
			currentFrame = 0;
		}
		pictureBox1.Image.SelectActiveFrame(dimension, currentFrame);
	}

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
}
