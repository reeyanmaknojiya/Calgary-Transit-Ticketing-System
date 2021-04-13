using System;
using System.Collections.Generic;
using System.IO;
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

            string email = textBoxEmail.Text;
            bool valid = false;

            //Pass the filepath and filename to the StreamWriter Constructor
            string _filePath = System.IO.Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\Accounts.txt";

            StreamReader sr = new StreamReader(_filePath);

            string line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                if (line.Equals(email))
                {
                    string passwordString = sr.ReadLine();
                    if (passwordString.Equals(password))
                    {
                        valid = true;
                        string fname = sr.ReadLine();
                        string lname = sr.ReadLine();
                        string bmonth = sr.ReadLine();
                        string bday = sr.ReadLine();
                        string byear = sr.ReadLine();
                        string phoneN = sr.ReadLine();

                        User.firstName = fname;
                        User.lastName = lname;
                        User.bMonth = bmonth;
                        User.bDay = bday;
                        User.bYear = byear;
                        User.email = email;
                        User.phone = phoneN;
                        User.password = password;
                        User.loggedIn = true;
                        TempUser.loggedIn = false;
                        this.NavigationService.Navigate(new storePage());
                    }
                }
                //account.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();

            if (valid == false)
            {
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
            }
            else if (valid == true)
            {
                this.NavigationService.Navigate(new storePage());
                windowAccess.Wnd.image1.Source = new BitmapImage(new Uri("Resources/store_selected.png", UriKind.Relative));
                windowAccess.Wnd.image5.Source = new BitmapImage(new Uri("Resources/accountNav.png", UriKind.Relative));
                windowAccess.Wnd.currentIcon = 1;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new signUpPage());
        }
        private void Forgot_Click(object sender, RoutedEventArgs e)
        {
            forgotPassText.Foreground = Brushes.Red;
            this.NavigationService.Navigate(new forgotPassPage());
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
