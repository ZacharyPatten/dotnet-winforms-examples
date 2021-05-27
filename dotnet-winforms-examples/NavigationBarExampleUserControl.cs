using System;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class NavigationBarExampleUserControl : UserControl
	{
		public NavigationBarExampleUserControl()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			label1.Text = ((Button)sender).Text + " Screen";
		}
	}
}
