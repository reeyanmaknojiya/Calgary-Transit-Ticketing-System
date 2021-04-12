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
    /// Interaction logic for signUpPage.xaml
    /// </summary>
    public partial class signUpPage : Page
    {
        String password;
        String confirmPassword;
        bool valid = true;

        public signUpPage()
        {
            InitializeComponent();
            emailError.Visibility = Visibility.Hidden;
            nameError.Visibility = Visibility.Hidden;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new chooseLoginPage());
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            // reset
            firstNameText.BorderBrush = System.Windows.Media.Brushes.Gray;
            lastNameText.BorderBrush = System.Windows.Media.Brushes.Gray;
            dayText.BorderBrush = System.Windows.Media.Brushes.Gray;
            yearText.BorderBrush = System.Windows.Media.Brushes.Gray;
            monthText.BorderBrush = System.Windows.Media.Brushes.Gray;
            emailText.BorderBrush = System.Windows.Media.Brushes.Gray;
            phoneText.BorderBrush = System.Windows.Media.Brushes.Gray;
            passwordUnmask.BorderBrush = System.Windows.Media.Brushes.Gray;
            passwordBox.BorderBrush = System.Windows.Media.Brushes.Gray;
            confirmPasswordUnmask.BorderBrush = System.Windows.Media.Brushes.Gray;
            confirmPasswordBox.BorderBrush = System.Windows.Media.Brushes.Gray;
            valid = true;

            // get password
            if (passwordUnmask.Visibility != Visibility.Visible)
            {
                password = passwordBox.Password;
            } else
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

            if (String.IsNullOrEmpty(firstNameText.Text)) {
                //nameError.Visibility = Visibility.Visible;
                firstNameText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (String.IsNullOrEmpty(lastNameText.Text))
            {
                lastNameText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (!Regex.IsMatch(dayText.Text, "\\d{2}") & !Regex.IsMatch(dayText.Text, "\\d{1}"))
            {
                dayText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (!String.IsNullOrEmpty(dayText.Text))
            {
                if (int.Parse(dayText.Text) > 31 ^ int.Parse(dayText.Text) < 1)
                {
                    dayText.BorderBrush = System.Windows.Media.Brushes.Red;
                    valid = false;
                }
            }
            if (!Regex.IsMatch(yearText.Text, "\\d{4}"))
            {
                yearText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (!String.IsNullOrEmpty(yearText.Text))
            {
                if (int.Parse(yearText.Text) > 2021 ^ int.Parse(yearText.Text) < 1900)
                {
                    yearText.BorderBrush = System.Windows.Media.Brushes.Red;
                    valid = false;
                }
            }
            if (!Regex.IsMatch(emailText.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                //emailError.Visibility = Visibility.Visible;
                emailText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }

            ComboBoxItem typeItem = (ComboBoxItem)monthText.SelectedItem;
            string month = typeItem.Content.ToString();

            if (month == "Month")
            {
                monthText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }

            if (!Regex.IsMatch(phoneText.Text, "\\d{10}") & !Regex.IsMatch(phoneText.Text, "[(]\\d{3}[)]\\d{3}[-]?\\d{4}"))
            {
                phoneText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
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
                User.firstName = firstNameText.Text;
                User.lastName = lastNameText.Text;
                User.bMonth = monthText.Text;
                User.bDay = dayText.Text;
                User.bYear = yearText.Text;
                User.email = emailText.Text;
                User.phone = phoneText.Text;
                User.password = password;
                User.loggedIn = true;
            
                string fname = firstNameText.Text;
                string lname = lastNameText.Text;
                string bmonth = monthText.Text;
                string bday = dayText.Text;
                string byear = yearText.Text;
                string emailID = emailText.Text;
                string phoneN = phoneText.Text;
                string pass = password;
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
