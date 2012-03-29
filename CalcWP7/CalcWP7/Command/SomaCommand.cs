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

namespace CalcWP7.Command
{
    public class SomaCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            Soma soma = (Soma)parameter;

            soma.Resultado = soma.Operador1 + soma.Operador2;
        }
    }
}
