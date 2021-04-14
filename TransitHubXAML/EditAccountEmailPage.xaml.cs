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
    /// Interaction logic for EditAccountEmailPage.xaml
    /// </summary>
    public partial class EditAccountEmailPage : Page
    {
        bool valid = true;
        public EditAccountEmailPage()
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
            emailText.BorderBrush = System.Windows.Media.Brushes.Gray;
            confirmEmailText.BorderBrush = System.Windows.Media.Brushes.Gray;

            valid = true;

            if (!Regex.IsMatch(emailText.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                //emailError.Visibility = Visibility.Visible;
                emailText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (!Regex.IsMatch(confirmEmailText.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                //emailError.Visibility = Visibility.Visible;
                confirmEmailText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            string emailtext = emailText.Text;
            string confirmemailtext = confirmEmailText.Text;
            if (emailtext.Equals(confirmemailtext) == false)
            {
                //emailError.Visibility = Visibility.Visible;
                confirmEmailText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (valid == true)
            {
                User.email = emailText.Text;
                this.NavigationService.Navigate(new AccountEditPage());
            }
        }
    }
}
