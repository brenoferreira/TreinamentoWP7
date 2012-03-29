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

namespace Map
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            System.Device.Location.GeoCoordinateWatcher watcher = new System.Device.Location.GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<System.Device.Location.GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate>>(watcher_PositionChanged);
            watcher.Start();
        }

        void watcher_PositionChanged(object sender, System.Device.Location.GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate> e)
        {
            this.map1.Center = e.Position.Location;
        }
    }
}