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
    public partial class ClienteAdd : PhoneApplicationPage
    {
        string urlBack = string.Empty;

        public ClienteAdd()
        {
            InitializeComponent();            
        }

        private void IconBack_Click(object sender, EventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void IconSave_Click(object sender, EventArgs e)
        {
            if (this.ValidaInclusao())
            {
                Timesheet.Domain.Cliente c = new Timesheet.Domain.Cliente();
                c.Endereco = TxtEndereco.Text;
                c.Nome = TxtNome.Text;
                c.Latitude = "-12111";
                c.Longitude = "3333";

                Timesheet.Persistencia.ClientePersistencia.Inserir(ref c);

                if (c != null && c.Id > 0)
                {
                    MessageBox.Show("Cliente Inserido com Sucesso.");
                    MessageBoxResult result = MessageBox.Show("Deseja cadastrar os TimeSheets para este cliente?", "Aviso", MessageBoxButton.OKCancel);

                    if (result.ToString() == "OK")
                    {
                        this.NavigationService.Navigate(new Uri("/Pages/Time/TimeSheet.xaml?cliente=" + c.Id, UriKind.Relative));
                    }
                }else{
                    MessageBox.Show("Cliente não foi incluido");
                }
            }
        }

        private bool ValidaInclusao()
        {
            string erro = string.Empty;
            if (string.IsNullOrEmpty(TxtNome.Text)) {
                erro += "Nome do Cliente deve ser informado.\\n";            
            }

            if (string.IsNullOrEmpty(TxtEndereco.Text))
            {
                erro += "Endereço do cliente deve ser informado.\\n";
            }

            if (string.IsNullOrEmpty(erro))
            {
                return true;
            }

            MessageBox.Show(erro, "Error", MessageBoxButton.OK);
            return false;
        }
    }
}