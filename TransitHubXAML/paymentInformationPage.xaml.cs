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
    /// Interaction logic for paymentInformationPage.xaml
    /// </summary>
    public partial class paymentInformationPage : Page
    {
       
        public paymentInformationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Verify input
            bool badInput = false;
            if (!Regex.IsMatch(cardHolder.Text, "^(\\s)*[A-Za-z]+((\\s)?((\\'|\\-|\\.)?([A-Za-z])+))*(\\s)*$"))
            {
                //Bad name
                cardHolder.Background = new SolidColorBrush(System.Windows.Media.Colors.LightSalmon);
                cardholderLabel.Content =  "Cardholder Name:*";
                badInput = true;
            }
            else
            {
                cardHolder.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                cardholderLabel.Content = "Cardholder Name:";
            }

            if(!Regex.IsMatch(cardNumber.Text, "\\b\\d{4}[ -]?\\d{4}[ -]?\\d{4}[ -]?\\d{4}\\b"))
            {
                //Bad credit card
                cardNumber.Background = new SolidColorBrush(System.Windows.Media.Colors.LightSalmon);
                cardNumberLabel.Content = "Card Number:*";
                badInput = true;
            }
            else
            {
                cardNumber.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                cardNumberLabel.Content = "Card Number:";
            }

            if(monthBox.SelectedIndex == -1)
            {
                monthBox.Background = new SolidColorBrush(System.Windows.Media.Colors.LightSalmon);
                dateLabel.Content = "Date:*";
                badInput = true;
            }
            else
            {
                monthBox.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                dateLabel.Content = "Date:";
            }

            if(yearBox.SelectedIndex == -1)
            {
                yearBox.Background = new SolidColorBrush(System.Windows.Media.Colors.LightSalmon);
                dateLabel.Content = "Date:*";
                badInput = true;
            }
            else
            {
                yearBox.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                dateLabel.Content = "Date:";
            }

            if (!Regex.IsMatch(cvvIn.Text, "\\d{3}"))
            {
                //bad cvv
                cvvIn.Background = new SolidColorBrush(System.Windows.Media.Colors.LightSalmon);
                cvvLabel.Content = "CVV:*";
                badInput = true;
            }
            else
            {
                cvvIn.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                cvvLabel.Content = "CVV:";
            }

            if(!Regex.IsMatch(zipIn.Text, "([A-Z]\\d){3}") && !Regex.IsMatch(zipIn.Text, "^\\d{5}(?:[-\\s]\\d{4})?$"))
            {
                //bad postal code
                zipIn.Background = new SolidColorBrush(System.Windows.Media.Colors.LightSalmon);
                zipLabel.Content = "ZIP Code:*";
                badInput = true;
            }
            else
            {
                zipIn.Background = new SolidColorBrush(System.Windows.Media.Colors.White);
                zipLabel.Content = "ZIP Code:";
            }

            if (!badInput)
            {
                App.Current.Properties["paymentMethod"] = "newCard";
                this.NavigationService.Navigate(new thankYou());
            }
        }
    }
}
