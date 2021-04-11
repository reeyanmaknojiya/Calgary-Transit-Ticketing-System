using System;
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
    /// Interaction logic for AccountPaymentMethodsPage.xaml
    /// </summary>
    public partial class AccountPaymentMethodsPage : Page
    {
        public AccountPaymentMethodsPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new accountPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DefaultButton2.Visibility = System.Windows.Visibility.Visible;
            DefaultLabel2.Visibility = System.Windows.Visibility.Hidden;
            DefaultButton.Visibility = System.Windows.Visibility.Hidden;
            DefaultLabel.Visibility = System.Windows.Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DefaultButton2.Visibility = System.Windows.Visibility.Hidden;
            DefaultLabel2.Visibility = System.Windows.Visibility.Visible;
            DefaultButton.Visibility = System.Windows.Visibility.Visible;
            DefaultLabel.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountSaveCardPage());
        }
    }
}
