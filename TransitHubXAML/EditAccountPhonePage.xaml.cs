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
    /// Interaction logic for EditAccountPhonePage.xaml
    /// </summary>
    public partial class EditAccountPhonePage : Page
    {
        bool valid = true;
        public EditAccountPhonePage()
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
            phoneText.BorderBrush = System.Windows.Media.Brushes.Gray;
            valid = true;

            if (!Regex.IsMatch(phoneText.Text, "\\d{10}") & !Regex.IsMatch(phoneText.Text, "[(]\\d{3}[)]\\d{3}[-]?\\d{4}"))
            {
                phoneText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (valid == true)
            {
                User.phone = phoneText.Text;
                this.NavigationService.Navigate(new AccountEditPage());
            }
        }
    }
}
