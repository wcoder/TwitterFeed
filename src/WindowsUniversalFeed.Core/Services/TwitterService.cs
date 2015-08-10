using System.Collections.Generic;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core.Interfaces;

namespace WindowsUniversalFeed.Core.Services
{
	public class TwitterService
	{
		private const string ConsumerKey = "hypa5NhtFMEC0FWUvy9abcz7d";
		private const string ConsumerSecret = "AwQGr5jc33ORqjh9bslNwgXVc0Ean1AXqUHm07vBPApaqtkYtS";

		public TwitterService()
		{
			Authorize();
		}

		private void Authorize()
		{
			var appCreds = Auth.SetApplicationOnlyCredentials(ConsumerKey, ConsumerSecret);

			// This method execute the required webrequest to set the bearer Token
			Auth.InitializeApplicationOnlyCredentials(appCreds, true);
		}

		public async Task<IEnumerable<ITweet>> GetTweets(string query)
		{
			return await Task.Factory.StartNew(() => Search.SearchTweets(query));
		}
	}
}
