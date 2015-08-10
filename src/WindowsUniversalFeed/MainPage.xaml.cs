using Windows.UI.Xaml.Controls;
using WindowsUniversalFeed.Core.Services;
using WindowsUniversalFeed.Core.ViewModels;

namespace WindowsUniversalFeed
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();

			DataContext = new MainPageViewModel(new TwitterService());
		}
	}
}
