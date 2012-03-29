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
using GalaSoft.MvvmLight.Command;

namespace TwitterSearchWP7.Commands
{
    public class TwitterSearchCommand : RelayCommand
    {
        public TwitterSearchCommand(Action execute)
            : base(execute)
        {

        }
    }
}
