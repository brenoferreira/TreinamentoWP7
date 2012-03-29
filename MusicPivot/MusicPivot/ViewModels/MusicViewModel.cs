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

namespace MusicPivot
{
    public class Artirst
    {
        public String Name { get; set; }
    }

    public class Album
    {
        public String Name { get; set; }
    }

    public class MusicViewModel
    {
        public MusicViewModel()
        {
            this.Artists = new List<Artirst>()
            {
                new Artirst() { Name = "Joe Satriani"},
                new Artirst() { Name = "Steve Vai"},
                new Artirst() { Name = "Dream Theater"},
                new Artirst() { Name = "Queen"},
                new Artirst() { Name = "Paul Gilbert"},
                new Artirst() { Name = "Iron Maiden"},
            };

            this.Albuns = new List<Album>()
            {
                new Album() { Name = "Album 1"},
                new Album() { Name = "Album 2"},
                new Album() { Name = "Album 3"},
                new Album() { Name = "Album 4"},
                new Album() { Name = "Album 5"},
                new Album() { Name = "Album 6"},
            };
        }

        public IEnumerable<Artirst> Artists { get; set; }

        public IEnumerable<Album> Albuns { get; set; }
    }
}
