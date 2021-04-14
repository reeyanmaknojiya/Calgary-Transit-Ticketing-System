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
    /// Interaction logic for EditAccountNamePage.xaml
    /// </summary>
    public partial class EditAccountNamePage : Page
    {
        bool valid = true;
        public EditAccountNamePage()
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
            firstNameText.BorderBrush = System.Windows.Media.Brushes.Gray;
            lastNameText.BorderBrush = System.Windows.Media.Brushes.Gray;

            valid = true;

            if (String.IsNullOrEmpty(firstNameText.Text))
            {
                //nameError.Visibility = Visibility.Visible;
                firstNameText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (String.IsNullOrEmpty(lastNameText.Text))
            {
                lastNameText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (valid == true)
            {
                User.firstName = firstNameText.Text;
                User.lastName = lastNameText.Text;
                this.NavigationService.Navigate(new AccountEditPage());
            }
        }
    }
}
