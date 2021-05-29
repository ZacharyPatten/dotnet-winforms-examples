using System;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class CustomButtonExamplesUserControl : UserControl
	{
		public CustomButtonExamplesUserControl()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"You clicked button {((Control)sender).Name}.");
		}
	}
}
