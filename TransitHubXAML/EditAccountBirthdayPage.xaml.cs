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
    /// Interaction logic for EditAccountBirthdayPage.xaml
    /// </summary>
    public partial class EditAccountBirthdayPage : Page
    {
        bool valid = true;
        public EditAccountBirthdayPage()
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
            dayText.BorderBrush = System.Windows.Media.Brushes.Gray;
            yearText.BorderBrush = System.Windows.Media.Brushes.Gray;
            monthText.BorderBrush = System.Windows.Media.Brushes.Gray;
            valid = true;

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
            ComboBoxItem typeItem = (ComboBoxItem)monthText.SelectedItem;
            string month = typeItem.Content.ToString();

            if (month == "Month")
            {
                monthText.BorderBrush = System.Windows.Media.Brushes.Red;
                valid = false;
            }
            if (valid == true)
            {
                User.bMonth = monthText.Text;
                User.bDay = dayText.Text;
                User.bYear = yearText.Text;
                this.NavigationService.Navigate(new AccountEditPage());
            }
        }
    }
}
