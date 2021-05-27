using System;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class RoundButtonExamplesUserControl : UserControl
	{
		public RoundButtonExamplesUserControl()
		{
			InitializeComponent();
		}

		private void RoundButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"You clicked button {((Control)sender).Name}.");
		}
	}
}
