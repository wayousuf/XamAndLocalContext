using LocalContext.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalContext
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            versionNumberLabel.Text = DependencyService.Get<IVersionHelper>().GetVersionNumber();
		}
	}
}
