using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class CollisionDetectionExampleControl : UserControl
	{
		const float BallSpeed = 100f;

		public CollisionDetectionExampleControl()
		{
			InitializeComponent();
			Random random = new();
			Circle NewCircle((int, int) center, int radius)
			{
				float ratio = (float)random.NextDouble();
				return new Circle()
				{
					Left = center.Item1 - radius,
					Top = center.Item2 - radius,
					Width = radius,
					Height = radius,
					Velocity = Vector2.Normalize(new(ratio, 1 - ratio)),
					Color = GetRandomColor(),
				};
			}

			Controls.Add(NewCircle((050, 050), 50));
			Controls.Add(NewCircle((200, 200), 50));
			Controls.Add(NewCircle((050, 200), 50));
			Controls.Add(NewCircle((200, 050), 50));
			Timer timer = new();
			DateTime previous = DateTime.Now;
			Graphics graphics = CreateGraphics();
			timer.Tick += (_, _) =>
			{
				SuspendLayout();
				DateTime now = DateTime.Now;
				float movement = (float)(BallSpeed * (now - previous).TotalSeconds);

				HashSet<(Circle, Circle)> collisions = new();

				foreach (Circle a in Controls)
				{
					foreach (Circle b in Controls)
					{
						if (a == b)
						{
							continue;
						}
						if (!collisions.Contains((b, a)))
						{
							float distance = Vector2.Distance(a.Center, b.Center);
							if (distance < a.Radius + b.Radius)
							{
								collisions.Add((a, b));
							}
						}
					}
				}

				foreach (var (a, b) in collisions)
				{
					a.Velocity = Vector2.Normalize(a.Center - b.Center);
					b.Velocity = Vector2.Normalize(b.Center - a.Center);
				}

				foreach (Circle a in Controls)
				{
					if (a.Left < 0 && a.Velocity.X < 0)                       a.Velocity = new(Math.Abs(a.Velocity.X), a.Velocity.Y);
					else if (a.Left + a.Diameter > Width && a.Velocity.X > 0) a.Velocity = new(-Math.Abs(a.Velocity.X), a.Velocity.Y);
					if (a.Top < 0 && a.Velocity.Y < 0)                        a.Velocity = new(a.Velocity.X, Math.Abs(a.Velocity.Y));
					else if (a.Top + a.Diameter > Height && a.Velocity.Y > 0) a.Velocity = new(a.Velocity.X, -Math.Abs(a.Velocity.Y));

					a.Left += (int)(movement * a.Velocity).X;
					a.Top += (int)(movement * a.Velocity).Y;
				}
				previous = now;
				ResumeLayout();
			};
			timer.Interval = 16;
			timer.Enabled = true;
		}

		private static Color GetRandomColor(Random random = null)
		{
			random ??= new();
			return Color.FromArgb(
				random.Next(256),
				random.Next(256),
				random.Next(256));
		}

		class Circle : Panel
		{
			public int Diameter => Math.Min(Width, Height);
			public int Radius => Diameter / 2;
			public Vector2 Center => new(Left + Diameter / 2, Top + Diameter / 2);
			public Color Color { get; set; }
			public Vector2 Velocity { get; set; }
			public Graphics Graphics { get; set; }
			protected override void OnPaint(PaintEventArgs e)
			{
				e.Graphics.FillEllipse(new SolidBrush(Color), 0, 0, Diameter, Diameter);
			}
		}
	}
}
