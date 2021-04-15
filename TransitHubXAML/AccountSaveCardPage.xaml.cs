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
    /// Interaction logic for AccountSaveCardPage.xaml
    /// </summary>
    public partial class AccountSaveCardPage : Page
    {
        public AccountSaveCardPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountPaymentMethodsPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool badInput = false;
            if (!Regex.IsMatch(cardHolder.Text, "^(\\s)*[A-Za-z]+((\\s)?((\\'|\\-|\\.)?([A-Za-z])+))*(\\s)*$"))
            {
                //Bad name
                cardHolder.BorderBrush = System.Windows.Media.Brushes.Red;
                cardholderLabel.Content = "Cardholder Name";
                badInput = true;
            }
            else
            {
                cardHolder.BorderBrush = System.Windows.Media.Brushes.White;
                cardholderLabel.Content = "Cardholder Name";
            }

            if (!Regex.IsMatch(cardNumber.Text, "\\b\\d{4}[ -]?\\d{4}[ -]?\\d{4}[ -]?\\d{4}\\b"))
            {
                //Bad credit card
                cardNumber.BorderBrush = System.Windows.Media.Brushes.Red;
                cardNumberLabel.Content = "Card Number";
                badInput = true;
            }
            else
            {
                cardNumber.BorderBrush = System.Windows.Media.Brushes.White;
                cardNumberLabel.Content = "Card Number";
            }

            if (monthBox.SelectedIndex == -1)
            {
                monthBox.BorderBrush = System.Windows.Media.Brushes.Red;
                // dateLabel.Content = "Date";
                badInput = true;
            }
            else
            {
                monthBox.BorderBrush = System.Windows.Media.Brushes.White;
                //  dateLabel.Content = "Date";
            }

            if (yearBox.SelectedIndex == -1)
            {
                yearBox.BorderBrush = System.Windows.Media.Brushes.Red;
                //dateLabel.Content = "Date";
                badInput = true;
            }
            else
            {
                yearBox.BorderBrush = System.Windows.Media.Brushes.White;
                //dateLabel.Content = "Date";
            }

            if (!Regex.IsMatch(cvvIn.Text, "\\d{3}"))
            {
                //bad cvv
                cvvIn.BorderBrush = System.Windows.Media.Brushes.Red;
                cvvLabel.Content = "CVV";
                badInput = true;
            }
            else
            {
                cvvIn.BorderBrush = System.Windows.Media.Brushes.White;
                cvvLabel.Content = "CVV";
            }

            if (!Regex.IsMatch(zipIn.Text, "([A-Z]\\d){3}"))
            {
                //bad postal code
                zipIn.BorderBrush = System.Windows.Media.Brushes.Red;
                zipLabel.Content = "Postal Code";
                badInput = true;
            }
            else
            {
                zipIn.BorderBrush = System.Windows.Media.Brushes.White;
                zipLabel.Content = "Postal Code";
            }

            if (!badInput)
            {
                this.NavigationService.Navigate(new CardConfirmationPage());
            }
        }
    }
}
