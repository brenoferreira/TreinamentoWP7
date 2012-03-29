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
using CalcWP7.Models;
using CalcWP7.Command;

namespace CalcWP7.ViewModels
{
    public class SomaViewModel
    {
        public SomaViewModel()
        {
            this.Soma = new Soma();
            this.SomaCommand = new SomaCommand();
        }

        public Soma Soma { get; set; }

        public SomaCommand SomaCommand { get; set; }
    }
}
