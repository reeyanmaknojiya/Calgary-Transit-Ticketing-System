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
using System.Text.RegularExpressions;

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for loginPage.xaml
    /// </summary>
    public partial class loginPage : Page
    {
        String password;
        public loginPage()
        {
            InitializeComponent();
            loginErrorText.Content = "";
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // get password
            if (passwordUnmask.Visibility != Visibility.Visible)
            {
                password = passwordBox.Password;
            }
            else
            {
                password = passwordUnmask.Text;
            }


            if (textBoxEmail.Text == "johnson@gmail.com" & passwordBox.Password == "johnson123")
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
                this.NavigationService.Navigate(new storePage());

            } else {
                loginErrorText.Content = "Incorrect login or password";
                textBoxEmail.BorderBrush = System.Windows.Media.Brushes.Red;
                passwordBox.BorderBrush = System.Windows.Media.Brushes.Red;
                passwordUnmask.BorderBrush = System.Windows.Media.Brushes.Red;
                passwordLabel.Margin = new Thickness(11, 223, 0, 0);
                passwordBox.Margin = new Thickness(18, 263, 0, 0);
                passwordUnmask.Margin = new Thickness(18, 263, 0, 0);
                rememberCheckBox.Margin = new Thickness(18, 319, 0, 0);
                rememberText.Margin = new Thickness(30, 310, 0, 0);
                forgotPassText.Margin = new Thickness(250, 310, 0, 0);
                viewEye.Margin = new Thickness(331, 267, 0, 0);
                hideEye.Margin = new Thickness(331, 267, 0, 0);
                //textBoxEmail.Select(0, textBoxEmail.Text.Length);
                //textBoxEmail.Focus();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            passwordUnmask.Visibility = Visibility.Visible;
            passwordBox.Visibility = Visibility.Hidden;
            passwordUnmask.Text = passwordBox.Password;
            //this.NavigationService.Navigate(new signUpPage());
        }

        private void View_Password_Click(object sender, RoutedEventArgs e)
        {
            passwordUnmask.Visibility = Visibility.Visible;
            passwordBox.Visibility = Visibility.Collapsed;
            passwordUnmask.Text = passwordBox.Password;
            viewEye.Visibility = Visibility.Collapsed;
            hideEye.Visibility = Visibility.Visible;
        }

        private void Hide_Password_Click(object sender, RoutedEventArgs e)
        {
            passwordUnmask.Visibility = Visibility.Collapsed;
            passwordBox.Visibility = Visibility.Visible;
            passwordBox.Password = passwordUnmask.Text;
            viewEye.Visibility = Visibility.Visible;
            hideEye.Visibility = Visibility.Collapsed;
        }

    }
}
