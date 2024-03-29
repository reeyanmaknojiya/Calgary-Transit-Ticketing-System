﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for LogoutConfirmationPage.xaml
    /// </summary>
    public partial class LogoutConfirmationPage : Page
    {
        public LogoutConfirmationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User.loggedIn = false;
            TempUser.loggedIn = true;
            this.NavigationService.Navigate(new chooseLoginPage());
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new accountPage());
        }
    }
}
