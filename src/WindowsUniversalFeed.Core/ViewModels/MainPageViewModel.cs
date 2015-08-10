using System.Collections.ObjectModel;
using WindowsUniversalFeed.Core.Services;
using Tweetinvi.Core.Interfaces;

namespace WindowsUniversalFeed.Core.ViewModels
{
	public class MainPageViewModel : BasePropertyChange
	{
		private readonly TwitterService _service;

		private string _query;
		private ObservableCollection<ITweet> _tweets;
		private bool _isBusy;

		public string Query
		{
			get { return _query; }
			set {
				_query = value.Trim();
				OnPropertyChanged();
				LoadData();
			}
		}

		public ObservableCollection<ITweet> Tweets
		{
			get { return _tweets; }
			set { _tweets = value; OnPropertyChanged(); }
		}

		public bool IsBusy
		{
			get { return _isBusy; }
			set { _isBusy = value; OnPropertyChanged(); }
		}

		public MainPageViewModel(TwitterService service)
		{
			_service = service;

			Query = "#Windows10";

			LoadData();
		}

		public async void LoadData()
		{
			if (!string.IsNullOrEmpty(_query))
			{
				IsBusy = true;

				var tweets = await _service.GetTweets(_query);

				Tweets = new ObservableCollection<ITweet>(tweets);

				IsBusy = false;
			}
		}

		
	}
}
