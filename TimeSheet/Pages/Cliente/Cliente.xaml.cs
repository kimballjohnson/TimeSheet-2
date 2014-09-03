using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Timesheet.Domain;
using Timesheet.Persistencia;

namespace TimeSheet.Pages
{
    public partial class Cliente : PhoneApplicationPage
    {
        private ClientePersistencia _clientePersistencia;

        public ClientePersistencia ClientePersistencia
        {
            get { return _clientePersistencia; }
            set { _clientePersistencia = value; }
        }



        public Cliente()
        {
            InitializeComponent();
            this.DataBindListaClientes();
        }

        private void DataBindListaClientes()
        {
            IList<Timesheet.Domain.Cliente> _lista = null;

            _lista = Timesheet.Persistencia.ClientePersistencia.BuscarTodos(0);

            if (_lista != null && _lista.Count > 0)
            {
                ListaClientes.ItemsSource = _lista;
            }
        }

        private void ListaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Timesheet.Domain.Cliente _cliente = (sender as ListBox).SelectedItem as Timesheet.Domain.Cliente;
            MessageBox.Show(_cliente.Nome);            
        }

        private void IconBack_Click(object sender, EventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void IconAddTime_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Cliente/ClienteAdd.xaml", UriKind.Relative));
        }

    }
}