using DemoDownloadTweets.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Web.Syndication;

namespace DemoDownloadTweets
{
    /// <summary>
    /// The TweetDownloader handles the download of tweets. They are managed by adding them to the first group in the GridView.
    /// </summary>
    public class TweetDownloader
    {
        /// <summary>
        /// Default twitter search url.
        /// </summary>
        public const string twitterUri = "http://search.twitter.com/search.rss?q={0}";

        /// <summary>
        /// Currently selected tweet, or null if none.
        /// </summary>
        public static Tweet SelectedTweet = null;
        
        /// <summary>
        /// Property representing the current search result as a list.
        /// </summary>
        public static ObservableCollection<Tweet> Tweets
        {
            get
            {
                // TODO: what needs to be returned here?
                return null;
            }
        }

        /// <summary>
        /// Most important function of the TwitterSearcher.
        /// Downloads tweets based on a given keyword and adds them to the Tweets list.
        /// </summary>
        /// <param name="tag_string"></param>
        public static void DownloadTweets(string tag_string)
        {
            // download tweets, make async

            // update live tiles
        }

        /// <summary>
        /// Updates the live tile with the latest downloaded tweets.
        /// Remark: only five tweets can be shown per download.
        /// </summary>
        private static void UpdateLiveTile()
        {
            // update live tile with notifications
        }

    }
}
