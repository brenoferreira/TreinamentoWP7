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

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            cliente.GetDataCompleted += new EventHandler<ServiceReference1.GetDataCompletedEventArgs>(cliente_GetDataCompleted);
            cliente.GetDataAsync(100);
        }

        void cliente_GetDataCompleted(object sender, ServiceReference1.GetDataCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }
    }
}