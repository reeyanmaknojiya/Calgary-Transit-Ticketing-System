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
using TransitHubXAML.Models;

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int currentIcon;

        public MainWindow()
        {
            windowAccess.Wnd = this;
            currentIcon = 1;
            User.loggedIn = false;
            InitializeComponent();
            Show();

            image1.Source = new BitmapImage(new Uri("Resources/store_selected.png", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            resetCurrentWindow();
            currentIcon = 1;
            image1.Source = new BitmapImage(new Uri("Resources/store_selected.png", UriKind.Relative));
            
            mainFrame.Navigate(new storePage());
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            resetCurrentWindow();
            currentIcon = 2;
            image2.Source = new BitmapImage(new Uri("Resources/cart_selected.png", UriKind.Relative));
            mainFrame.Navigate(new cartPage());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            resetCurrentWindow();
            currentIcon = 3;
            image3.Source = new BitmapImage(new Uri("Resources/my_tickets_selected.png", UriKind.Relative));
            mainFrame.Navigate(new Wallet());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        { 
            
            resetCurrentWindow();
            currentIcon = 4;
            image4.Source = new BitmapImage(new Uri("Resources/help_selected.png", UriKind.Relative));
            mainFrame.Navigate(new Help());
        }

        //We go to cart page and we send it the array of items
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            resetCurrentWindow();
            currentIcon = 5;
            image5.Source = new BitmapImage(new Uri("Resources/account_selected.png", UriKind.Relative));
            if (User.loggedIn == false)
                mainFrame.Navigate(new chooseLoginPage());//TODO switch account to a page to make this work
            else if (User.loggedIn == true)
                mainFrame.Navigate(new accountPage());
        }

        private void resetCurrentWindow()
        {
            switch (currentIcon)
            {
                case 0:
                    break;
                case 1:
                    image1.Source = new BitmapImage(new Uri("Resources/store.png", UriKind.Relative));
                    break;
                case 2:
                    image2.Source = new BitmapImage(new Uri("Resources/cart.png", UriKind.Relative));
                    break;
                case 3:
                    image3.Source = new BitmapImage(new Uri("Resources/my_tickets.png", UriKind.Relative));
                    break;
                case 4:
                    image4.Source = new BitmapImage(new Uri("Resources/help.png", UriKind.Relative));
                    break;
                case 5:
                    image5.Source = new BitmapImage(new Uri("Resources/accountNav.png", UriKind.Relative));
                    break;

            }
        }

        /*
        private void chooseLogin_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new chooseLoginPage());
        }
        */
        // hide nav bar
        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            Type pageType = e.Content.GetType();

            if (pageType == typeof(loginPage) || pageType == typeof(signUpPage) || pageType == typeof(AccountEditPage) || pageType == typeof(EditAccountBirthdayPage) || pageType == typeof(EditAccountEmailPage) || pageType == typeof(EditAccountPhonePage) || pageType == typeof(EditAccountNamePage) || pageType == typeof(EditAccountPasswordPage))
            {
                //hide nav bar
                navBar.Visibility = System.Windows.Visibility.Hidden;
                navBarBorder.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                //display nav bar
                navBar.Visibility = System.Windows.Visibility.Visible;
                navBarBorder.Visibility = System.Windows.Visibility.Visible;
            }
        }
        
       
    }
}
