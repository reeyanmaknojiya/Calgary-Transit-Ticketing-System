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

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for loginPage.xaml
    /// </summary>
    public partial class loginPage : Page
    {
        public loginPage()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string email = emailText.Text;
            string password = passwordText.Text;
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

                        this.NavigationService.Navigate(new storePage());
                    }
                }
                //account.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new signUpPage());
        }
    }
}
