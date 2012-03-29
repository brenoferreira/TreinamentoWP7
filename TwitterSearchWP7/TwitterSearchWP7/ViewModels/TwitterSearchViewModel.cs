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
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using TwitterSearchWP7.Commands;
using Newtonsoft.Json;
using TwitterSearchWP7.Twitter;
using Microsoft.Phone.Scheduler;

namespace TwitterSearchWP7.ViewModels
{
    public class TwitterSearchViewModel : ViewModelBase
    {
        private Searcher searcher;

        public TwitterSearchViewModel()
        {
            this.searcher = new Searcher();
            this.SearchCommand = new TwitterSearchCommand(() =>
            {
                this.searcher.Search(this.SearchQuery, (tweets) =>
                {
                    this.Tweets = tweets;
                    this.RaisePropertyChanged("Tweets");
                });
            });

            this.BackgroundTaskComand = new GalaSoft.MvvmLight.Command.RelayCommand(() =>
            {
                PeriodicTask task = new PeriodicTask("TwitterSearch");
                task.Description = this.SearchQuery;
                task.ExpirationTime = DateTime.Now.AddDays(1);
                ScheduledActionService.Add(task);
            });
        }

        public String SearchQuery { get; set; }

        public ICommand SearchCommand { get; private set; }

        public ICommand BackgroundTaskComand { get; set; }

        public IEnumerable<Tweet> Tweets { get; private set; }
    }
}
