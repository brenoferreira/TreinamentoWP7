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
using System.ComponentModel;

namespace CalcWP7.Models
{
    public class Soma : INotifyPropertyChanged
    {
        private int operador1;

        public int Operador1
        {
            get { return operador1; }
            set { operador1 = value; RaisePropertyChanged("Operador1"); }
        }

        private int operador2;

        public int Operador2
        {
            get { return operador2; }
            set { operador2 = value; RaisePropertyChanged("Operador2"); }
        }

        private int resultado;

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; RaisePropertyChanged("Resultado"); }
        }

        private void RaisePropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
