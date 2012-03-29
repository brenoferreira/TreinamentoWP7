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

namespace PagingWP7.Views
{
    public partial class Song : PhoneApplicationPage
    {
        public Song()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var songName = NavigationContext.QueryString["Song"];
            this.songPlayer.Source = new Uri(songName, UriKind.RelativeOrAbsolute);
            this.songPlayer.Play();
            base.OnNavigatedTo(e);
        }
    }
}