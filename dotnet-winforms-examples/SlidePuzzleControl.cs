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
	public partial class SlidePuzzleControl : UserControl
	{
		bool Animating = false;
		public Panel[,] Tiles { get; private set; }

		public SlidePuzzleControl() : this(4, 4) { }

		public SlidePuzzleControl(int rows, int columns)
		{
			InitializeComponent();
			Tiles = new Panel[rows, columns];
			int[] indeces = new int[rows * columns - 1];
			for (int i = 0; i < indeces.Length; i++)
			{
				indeces[i] = i + 1;
			}
			Random random = new Random();
			for (int i = 0; i < indeces.Length; i++)
			{
				int b = random.Next(indeces.Length);
				int temp = indeces[i];
				indeces[i] = indeces[b];
				indeces[b] = temp;
			}
			int index = 0;
			for (int row = 0; row < Tiles.GetLength(0); row++)
			{
				for (int column = 0; column < Tiles.GetLength(1); column++)
				{
					if (row is 0 && column is 0)
					{
						continue;
					}
					Panel panel = new();
					Label label = new();
					label.Text = indeces[index++].ToString();
					panel.BackColor = GetRandomColor();
					bool isDark = panel.BackColor.R + panel.BackColor.G + panel.BackColor.B / 3 < 255 / 2;
					panel.ForeColor = isDark ? Color.White : Color.Black;
					panel.Click += Tile_Click;
					panel.Controls.Add(label);
					Tiles[row, column] = panel;
					Controls.Add(panel);
				}
			}
			Layout();
		}

		public void Layout()
		{
			int tileWidth = Width / Tiles.GetLength(0);
			int tileHeight = Height / Tiles.GetLength(1);
			int left = 0;
			int top = 0;
			for (int row = 0; row < Tiles.GetLength(0); row++)
			{
				for (int column = 0; column < Tiles.GetLength(1); column++)
				{
					if (Tiles[row, column] is not null)
					{
						Tiles[row, column].Left = left;
						Tiles[row, column].Top = top;
						Tiles[row, column].Width = tileWidth;
						Tiles[row, column].Height = tileHeight;
					}
					left += tileWidth;
				}
				top += tileHeight;
				left = 0;
			}
			Refresh();
		}

		private void SlidePuzzleControl_Resize(object sender, EventArgs e)
		{
			Layout();
		}

		private Color GetRandomColor(Random random = null)
		{
			random ??= new();
			return Color.FromArgb(
				random.Next(256),
				random.Next(256),
				random.Next(256));
		}

		private void Tile_Click(object sender, EventArgs e)
		{
			if (Animating)
			{
				return;
			}

			(int Row, int Column) tileLocation = default;
			for (int row = 0; row < Tiles.GetLength(0); row++)
			{
				for (int column = 0; column < Tiles.GetLength(1); column++)
				{
					if (Tiles[row, column] == sender)
					{
						tileLocation = (row, column);
					}
				}
			}
			(int Row, int Column)? targetLocation = default;
			foreach (var (row, column) in Adjacent(tileLocation.Row, tileLocation.Column))
			{
				if (Tiles[row, column] is null)
				{
					targetLocation = (row, column);
				}
			}

			if (!targetLocation.HasValue)
			{
				return;
			}

			Tiles[targetLocation.Value.Row, targetLocation.Value.Column] = Tiles[tileLocation.Row, tileLocation.Column];
			Tiles[tileLocation.Row, tileLocation.Column] = null;

			Animating = true;
			Panel tile = (Panel)sender;
			TimeSpan animationTime = TimeSpan.FromMilliseconds(500);
			DateTime start = DateTime.Now;
			Timer timer = new Timer();
			timer.Interval = 16;
			timer.Tick += (_, _) =>
			{
				if (DateTime.Now - start > animationTime)
				{
					Layout();
					timer.Enabled = false;
					Animating = false;
				}
				else
				{
					// still some view bug in these calculations
					int tileWidth = Width / Tiles.GetLength(0);
					int tileHeight = Height / Tiles.GetLength(1);
					double ratio = (DateTime.Now - start) / animationTime;
					if (targetLocation.Value.Row > tileLocation.Row)
					{
						tile.Top = Math.Min((int)(tileLocation.Row * tileWidth + ratio * tileWidth), targetLocation.Value.Row * tileHeight);
					}
					if (targetLocation.Value.Column > tileLocation.Column)
					{
						tile.Left = Math.Min((int)(tileLocation.Column * tileHeight + ratio * tileHeight), targetLocation.Value.Column * tileWidth);
					}
					if (targetLocation.Value.Row < tileLocation.Row)
					{
						tile.Top = Math.Max((int)(tileLocation.Row * tileWidth - ratio * tileWidth), targetLocation.Value.Row * tileHeight);
					}
					if (targetLocation.Value.Column < tileLocation.Column)
					{
						tile.Left = Math.Max((int)(tileLocation.Column * tileHeight - ratio * tileHeight), targetLocation.Value.Column * tileWidth);
					}
					tile.Refresh();
				}
			};
			timer.Enabled = true;
		}

		private IEnumerable<(int Row, int Column)> Adjacent(int row, int column)
		{
			int rows = Tiles.GetLength(0);
			int columns = Tiles.GetLength(1);

			if (row > 0) yield return (row - 1, column);
			if (column > 0) yield return (row, column - 1);
			if (row < rows - 1) yield return (row + 1, column);
			if (column < columns - 1) yield return (row, column + 1);
		}
	}
}
