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

namespace TimeSheet.Pages.Config
{
    public partial class MinhaConfiguracao : PhoneApplicationPage
    {
        public MinhaConfiguracao()
        {
            InitializeComponent();

            ListHorasAlm.InputScope = new System.Windows.Input.InputScope() { Names = { new System.Windows.Input.InputScopeName() { NameValue = System.Windows.Input.InputScopeNameValue.Number } } };
            ListHorasComp.InputScope = new System.Windows.Input.InputScope() { Names = { new System.Windows.Input.InputScopeName() { NameValue = System.Windows.Input.InputScopeNameValue.Number } } };
            ListHorasTrab.InputScope = new System.Windows.Input.InputScope() { Names = { new System.Windows.Input.InputScopeName() { NameValue = System.Windows.Input.InputScopeNameValue.Number } } };

            this.DataBindTela();
        }

        private void DataBindTela()
        {
            Configuracao c = null;

            c = (from a in Timesheet.Persistencia.DefaultDataBase.Context.ConfigSystem select a).FirstOrDefault();

            if (c != null)
            {
                TxtEmail.Text = c.Email;
                ChkEnviaEmail.IsChecked = c.EnviarPorEmail;
                ChkGerarExcel.IsChecked = c.ExportarExcel;
                ListHorasAlm.Text = c.HorasAlmoco.ToString();
                ListHorasComp.Text = c.HorasCompensacao.ToString();
                ListHorasTrab.Text = c.HorasTrabalho.ToString();

            }

        }


        private void IconSave_Click(Object sender, EventArgs e) {
            Configuracao c = null;

            c = (from a in Timesheet.Persistencia.DefaultDataBase.Context.ConfigSystem select a).FirstOrDefault();
            if (c == null)
                c = new Configuracao();

            c.HorasTrabalho = Convert.ToInt32("0" + ListHorasTrab.Text);
            c.HorasCompensacao = Convert.ToInt32("0" + ListHorasComp.Text);
            c.HorasAlmoco = Convert.ToInt32("0" + ListHorasAlm.Text);
            c.Email = TxtEmail.Text;
            c.EnviarPorEmail = ((ChkEnviaEmail.IsChecked==true) ? true : false);
            c.ExportarExcel = ((ChkGerarExcel.IsChecked==true) ? true : false);


            if (c.Id == 0)
                ConfiguracaoPersistencia.Inserir(ref c);
            else
                ConfiguracaoPersistencia.Alterar(ref c);

            if (c != null && c.Id > 0)
            {
                MessageBox.Show("Dados salvos com sucesso");
                this.NavigationService.Navigate(new Uri("/Pages/Config/MinhaConfiguracao.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Configuração não salva");
            }

            

        }

        private void IconBack_Click(Object sender, EventArgs e) {
            this.NavigationService.GoBack();
        }


    }
}