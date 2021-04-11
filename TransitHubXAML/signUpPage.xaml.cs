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
            User.bMonth = monthText.Text;
            User.bDay = dayText.Text;
            User.bYear = yearText.Text;
            User.email = emailText.Text;
            User.phone = phoneText.Text;
            User.password = passText1.Text;
            User.loggedIn = true;

            string fname = firstNameText.Text;
            string lname = lastNameText.Text;
            string bmonth = monthText.Text;
            string bday = dayText.Text;
            string byear = yearText.Text;
            string emailID = emailText.Text;
            string phoneN = phoneText.Text;
            string pass = passText1.Text;
            //firstNameText.Text, lastNameText.Text, monthText.Text, dayText.Text, yearText.Text, emailText.Text, phoneText.Text, passText1.Text
            List<string> account = new List<string>();
            account.Add(emailID);
            account.Add(pass);
            account.Add(fname);
            account.Add(lname);
            account.Add(bmonth);
            account.Add(bday);
            account.Add(byear);     
            account.Add(phoneN);
            account.Add("");

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                string _filePath = System.IO.Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
                _filePath += @"\Accounts.txt";

                StreamReader sr = new StreamReader(_filePath);
                
                string line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    account.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                StreamWriter sw = new StreamWriter(_filePath);
                foreach (string s in account)
                {
                    sw.WriteLine(s);
                }
                //close the file
                sw.Close();
            }
            catch (Exception er)
            {
                Console.WriteLine("Exception: " + er.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            this.NavigationService.Navigate(new storePage());
        }
    }
}
