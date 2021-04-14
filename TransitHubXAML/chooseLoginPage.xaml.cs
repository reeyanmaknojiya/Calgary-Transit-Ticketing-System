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
    /// Interaction logic for chooseLoginPage.xaml
    /// </summary>
    public partial class chooseLoginPage : Page
    {
        public chooseLoginPage()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new loginPage());
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new signUpPage());
        }
    }
}
