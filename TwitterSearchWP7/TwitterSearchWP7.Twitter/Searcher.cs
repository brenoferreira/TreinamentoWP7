using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitterSearchWP7.Twitter
{
    public class Searcher
    {
        public void Search(String searchQuery, Action<IEnumerable<Tweet>> onSearchCompleted)
        {
            WebClient client = new WebClient();

            var searchUri = new Uri(String.Format("http://search.twitter.com/search.json?q={0}", searchQuery));

            client.DownloadStringCompleted += (sender, e) =>
            {
                var result = JsonConvert.DeserializeObject<TwitterResult>(e.Result);

                if (onSearchCompleted != null)
                    onSearchCompleted(result.results);
            };
            client.DownloadStringAsync(searchUri);
        }
    }
}
