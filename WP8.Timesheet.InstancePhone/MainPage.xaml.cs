using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP8.Timesheet.InstancePhone.Resources;

namespace WP8.Timesheet.InstancePhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }

        
        private void ExibeProgress() {
            MyProgress.Visibility = System.Windows.Visibility.Visible;
        }

        private void HideProgress() {
            MyProgress.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void ExibePanelPrincipal() {
            FormLogin.Visibility = System.Windows.Visibility.Visible;
        }
        
        private void HidePanelPrincipal() {
            FormLogin.Visibility = System.Windows.Visibility.Collapsed;
        }



        private void BtnLogar_Click(object sender, EventArgs e) {

            this.ExibeProgress();
            this.HidePanelPrincipal();




        
        }

        private void BtnEsqueciSenha_Click(object sender, EventArgs e) {
            this.NavigationService.Navigate(new Uri("/Page/Usuario/ResetPassword.xaml", UriKind.Relative));
        }

        private void BtnNovoCadastro_Click(object sender, EventArgs e) {
            this.NavigationService.Navigate(new Uri("/Page/Usuario/NewUser.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarButtonText;
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            ApplicationBar.MenuItems.Add(appBarMenuItem);


        }
    }
}