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
    /// Interaction logic for loginPage.xaml
    /// </summary>
    public partial class loginPage : Page
    {
        public loginPage()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (EmailInput.Text == "johnson@gmail.com" & PasswordInput.Text == "johnson123")
            {
                User.loggedIn = true;
                User.firstName = "John";
                User.lastName = "Johnson";
                User.bMonth = "March";
                User.bDay = "1";
                User.bYear = "1989";
                User.email = "johnjohnson@gmail.com";
                User.password = "johnson123";
                User.phone = "(403)123-4567";

                TempUser.loggedIn = false;
            }
            this.NavigationService.Navigate(new storePage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new signUpPage());
        }
    }
}
