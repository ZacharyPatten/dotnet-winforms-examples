using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class ResizeAnimationUserControl : UserControl
	{
		Action CancelAnimation = null;

		public ResizeAnimationUserControl()
		{
			InitializeComponent();
		}

		private void ResizingButton_Click(object sender, EventArgs e)
		{
			CancelAnimation?.Invoke();
			Size size = new((int)widthSelector.Value, (int)heightSelector.Value);
			TimeSpan duration = TimeSpan.FromMilliseconds((int)durationSelector.Value);
			if (size.Height < 20 || size.Height > 1000)
			{
				MessageBox.Show("size.Height is outside the range 20-1000");
				return;
			}
			if (size.Width < 20 || size.Width > 1000)
			{
				MessageBox.Show("Width is outside the range 20-1000");
				return;
			}
			if (durationSelector.Value < 0 || durationSelector.Value > 10000)
			{
				MessageBox.Show("Duration is outside the range 0-10000");
				return;
			}
			CancelAnimation = resizingButton.TryAnimateResize(size, duration, () => CancelAnimation = null);
			widthSelector.Value = resizingButton.Width;
			heightSelector.Value = resizingButton.Height;
		}
	}

	public static class AnimationHelper
	{
		/// <summary>Resizes a <see cref="Control"/> via animation.</summary>
		/// <param name="control">The control to resize.</param>
		/// <param name="newSize">The new size of the <paramref name="control"/>.</param>
		/// <param name="duration">The duration of the animation.</param>
		/// <param name="interval">The update interval in milliseconds.</param>
		/// <param name="callback">The callback when the animation is complete.</param>
		/// <returns>A cancelation delegate if the animation was started.</returns>
		public static Action TryAnimateResize(this Control control, Size newSize, TimeSpan duration, Action callback = null, int interval = 1)
		{
			if (newSize.Height < 0)
			{
				MessageBox.Show($"{nameof(newSize)}.{nameof(newSize.Height)} < 0");
				return null;
			}
			if (newSize.Width < 0)
			{
				MessageBox.Show($"{nameof(newSize)}.{nameof(newSize.Width)} < 0");
				return null;
			}
			interval = Math.Max(1, interval);
			Timer timer = new();
			DateTime start = DateTime.Now;
			Size original = control.Size;
			bool complete = false;
			timer.Tick += (s, e) =>
			{
				DateTime now = DateTime.Now;
				if (now - start > duration)
				{
					control.Width = newSize.Width;
					control.Height = newSize.Height;
					Clean();
					callback?.Invoke();
					complete = true;
				}
				else
				{
					double ratio = (now - start) / duration;
					control.Width = original.Width > newSize.Width
						? original.Width - (int)(ratio * (original.Width - newSize.Width))
						: original.Width + (int)(ratio * (newSize.Width - original.Width));
					control.Height = original.Height > newSize.Height
						? original.Height - (int)(ratio * (original.Height - newSize.Height))
						: original.Height + (int)(ratio * (newSize.Height - original.Height));
				}
			};
			timer.Interval = interval;
			timer.Enabled = true;
			void Clean()
			{
				if (!complete)
				{
					timer.Enabled = false;
					timer.Dispose();
				}
			}
			return Clean;
		}
	}
}
