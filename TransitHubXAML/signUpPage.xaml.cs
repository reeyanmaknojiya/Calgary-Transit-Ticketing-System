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
    /// Interaction logic for signUpPage.xaml
    /// </summary>
    public partial class signUpPage : Page
    {
        public signUpPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            User.firstName = firstNameText.Text;
            User.lastName = lastNameText.Text;

            this.NavigationService.Navigate(new storePage());
        }

    }
}
