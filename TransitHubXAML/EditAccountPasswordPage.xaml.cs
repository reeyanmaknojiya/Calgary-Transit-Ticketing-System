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
    /// Interaction logic for EditAccountPasswordPage.xaml
    /// </summary>
    public partial class EditAccountPasswordPage : Page
    {
        String password;
        String confirmPassword;
        bool valid = true;
        public EditAccountPasswordPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountEditPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountEditPage());
        }

        // Confirm Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // reset
            passwordUnmask.BorderBrush = System.Windows.Media.Brushes.Gray;
            passwordBox.BorderBrush = System.Windows.Media.Brushes.Gray;
            confirmPasswordUnmask.BorderBrush = System.Windows.Media.Brushes.Gray;
            confirmPasswordBox.BorderBrush = System.Windows.Media.Brushes.Gray;
            valid = true;

            if (passwordUnmask.Visibility != Visibility.Visible)
            {
                password = passwordBox.Password;
            }
            else
            {
                password = passwordUnmask.Text;
            }

            if (confirmPasswordUnmask.Visibility != Visibility.Visible)
            {
                confirmPassword = confirmPasswordBox.Password;
            }
            else
            {
                confirmPassword = confirmPasswordUnmask.Text;
            }

            if (password != confirmPassword ^ String.IsNullOrEmpty(password))
            {
                passwordUnmask.BorderBrush = System.Windows.Media.Brushes.Red;
                passwordBox.BorderBrush = System.Windows.Media.Brushes.Red;
                confirmPasswordUnmask.BorderBrush = System.Windows.Media.Brushes.Red;
                confirmPasswordBox.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }

            if (valid == true)
            {
                User.password = password;
                this.NavigationService.Navigate(new AccountEditPage());
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
