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
	public partial class RoundButtonExamplesUserControl : UserControl
	{
		public RoundButtonExamplesUserControl()
		{
			InitializeComponent();
		}

		private void roundButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"You clicked button {((Control)sender).Name}.");
		}
	}
}
