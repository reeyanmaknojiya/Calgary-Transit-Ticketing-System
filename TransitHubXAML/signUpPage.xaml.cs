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
    /// Interaction logic for signUpPage.xaml
    /// </summary>
    public partial class signUpPage : Page
    {
        String password;
        String confirmPassword;
        public signUpPage()
        {
            InitializeComponent();
            emailError.Visibility = Visibility.Hidden;
            nameError.Visibility = Visibility.Hidden;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            // get password
            if (passwordUnmask.Visibility == Visibility.Visible)
            {
                password = passwordBox.Password;
            } else
            {
                password = passwordUnmask.Text;
            }

            if (confirmPasswordUnmask.Visibility == Visibility.Visible)
            {
                password = confirmPasswordBox.Password;
            }
            else
            {
                password = confirmPasswordUnmask.Text;
            }

            if (firstNameText.Text == "" ^ lastNameText.Text == "") {
                nameError.Visibility = Visibility.Visible;
            }
            else if (!Regex.IsMatch(emailText.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                emailError.Visibility = Visibility.Visible;
            }
            else
            {
                User.firstName = firstNameText.Text;
                User.lastName = lastNameText.Text;
                User.bMonth = monthText.Text;
                User.bDay = dayText.Text;
                User.bYear = yearText.Text;
                User.email = emailText.Text;
                User.phone = phoneText.Text;
                User.password = passwordBox.Password;
                User.loggedIn = true;

                this.NavigationService.Navigate(new storePage());
            }
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

        private void View_Confirm_Password_Click(object sender, RoutedEventArgs e)
        {
            confirmPasswordUnmask.Visibility = Visibility.Visible;
            confirmPasswordBox.Visibility = Visibility.Collapsed;
            confirmPasswordUnmask.Text = confirmPasswordBox.Password;
            viewConfirmEye.Visibility = Visibility.Collapsed;
            hideConfirmEye.Visibility = Visibility.Visible;
        }

        private void Hide_Confirm_Password_Click(object sender, RoutedEventArgs e)
        {
            confirmPasswordUnmask.Visibility = Visibility.Collapsed;
            confirmPasswordBox.Visibility = Visibility.Visible;
            confirmPasswordBox.Password = confirmPasswordUnmask.Text;
            viewConfirmEye.Visibility = Visibility.Visible;
            hideConfirmEye.Visibility = Visibility.Collapsed;
        }
    }
}
