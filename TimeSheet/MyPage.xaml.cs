using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TimeSheet
{
    public partial class MyPage : PhoneApplicationPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente fechar o aplicativo?", "Aviso", MessageBoxButton.OKCancel);

            if (result.ToString() == "OK")
            {
                base.OnBackKeyPress(e);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconConfigButton_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Config/MinhaConfiguracao.xaml", UriKind.Relative));
        }

        private void BtnCliente_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Cliente/Cliente.xaml", UriKind.Relative));
        }

        private void BtnTimeSheet_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Time/TimeSheet.xaml", UriKind.Relative));
        }
   
    }
}