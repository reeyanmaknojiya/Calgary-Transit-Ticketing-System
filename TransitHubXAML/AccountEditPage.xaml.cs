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
    /// Interaction logic for AccountEditPage.xaml
    /// </summary>
    public partial class AccountEditPage : Page
    {
        public AccountEditPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new accountPage());
        }
        private void Name_Loaded(object sender, RoutedEventArgs e)
        {
            name.Content = User.firstName + " " + User.lastName;
        }
        private void Birthday_Loaded(object sender, RoutedEventArgs e)
        {
            birthday.Content = User.bMonth + " " + User.bDay + ", " + User.bYear;
        }
        private void Email_Loaded(object sender, RoutedEventArgs e)
        {
            email.Content = User.email;
        }
        private void Phone_Loaded(object sender, RoutedEventArgs e)
        {
            phone.Content = User.phone;
        }
    }
}
