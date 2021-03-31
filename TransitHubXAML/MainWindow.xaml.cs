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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Show();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new storePage());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new cartPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new paymentInformationPage());
        }

        private void chooseLogin_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new chooseLoginPage());
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            Type pageType = e.Content.GetType();

            if (pageType == typeof(loginPage) || pageType == typeof(signUpPage))
            {
                //hide nav bar
                navBar.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                //display nav bar
                navBar.Visibility = System.Windows.Visibility.Visible;
            }
        }
       
    }
}
