using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace VideoResuming
{
    public partial class MainPage : PhoneApplicationPage
    {
        TimeSpan tempo;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            this.DataContext = tempo;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            this.tempo = new TimeSpan();
            if (State.ContainsKey("Time"))
                this.tempo = (TimeSpan)State["Time"];

            this.videoPlayer.MediaOpened += (sender, ev) =>
            {
                this.videoPlayer.Position = this.tempo;
                this.videoPlayer.Play();
            };

            this.videoPlayer.Source = new Uri("Video/Maid with the Flaxen Hair.mp3", UriKind.RelativeOrAbsolute);
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            State["Time"] = this.videoPlayer.Position;
            base.OnNavigatedFrom(e);
        }
    }
}