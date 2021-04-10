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
    /// Interaction logic for cartPage.xaml
    /// </summary>
    public partial class cartPage : Page
    {
        private const double adultTicketPrice = 3.50;
        private const double youthTicketPrice = 2.40;
        private const double adultMonthlyPrice = 109.00;
        private const double youthMonthlyPrice = 79.00;
        private const double lowIncomeMonthlyPrice = 38.15;
        private int adultTicketAmount = 0;
        private int youthTicketAmount = 0;
        private int adultMonthlyAmount = 0;
        private int youthMonthlyAmount = 0;
        private int lowIncomeMonthlyAmount = 0;
        public cartPage()
        {
            InitializeComponent();
            if (App.Current.Properties.Contains("itemsToCart"))
            {
                int[] inCart = (int[])App.Current.Properties["itemsToCart"];

                adultTicketAmount = inCart[(int)Enums.adultTicket];
                youthTicketAmount = inCart[(int)Enums.youthTicket];
                adultMonthlyAmount = inCart[(int)Enums.adultMonthly];
                youthMonthlyAmount = inCart[(int)Enums.youthMonthly];
                lowIncomeMonthlyAmount = inCart[(int)Enums.lowIncomeMonthly];


                adultTicketAmountLabel.Content = inCart[(int)Enums.adultTicket].ToString();
                youthTicketAmountLabel.Content = inCart[(int)Enums.youthTicket].ToString();
                adultMonthlyAmountLabel.Content = inCart[(int)Enums.adultMonthly].ToString();
                youthMonthlyAmountLabel.Content = inCart[(int)Enums.youthMonthly].ToString();
                lowIncomeAmountLabel.Content = inCart[(int)Enums.lowIncomeMonthly].ToString();
            }

            checkoutButton.Content = "CHECKOUT $" + string.Format("{0:0.00}",App.Current.Properties["currCost"]);
            
        }
        private double calcCurrentCartTotal()
        {
            double val = (adultTicketPrice * adultTicketAmount) +
                         (youthTicketPrice * youthTicketAmount) +
                         (adultMonthlyPrice * adultMonthlyAmount) +
                         (youthMonthlyPrice * youthMonthlyAmount) +
                         (lowIncomeMonthlyPrice * lowIncomeMonthlyAmount);

            return val;
        }
        private void adultTicketPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultTicketAmountLabel.Content.ToString());
            curr++;
            adultTicketAmount++;
            adultTicketAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;

        }

        private void adultTicketMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultTicketAmountLabel.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            adultTicketAmount--;
            adultTicketAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void youthTicketMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthTicketAmountLabel.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            youthTicketAmount--;
            youthTicketAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void youthTicketPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthTicketAmountLabel.Content.ToString());
            curr++;
            youthTicketAmount++;
            youthTicketAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void adultMonthlyMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultMonthlyAmountLabel.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            adultMonthlyAmount--;
            adultMonthlyAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void adultMonthlyPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultMonthlyAmountLabel.Content.ToString());
            curr++;
            adultMonthlyAmount++;
            adultMonthlyAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void youthMonthlyMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthMonthlyAmountLabel.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            youthMonthlyAmount--;
            youthMonthlyAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void youthMonthlyPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthMonthlyAmountLabel.Content.ToString());
            curr++;
            youthMonthlyAmount++;
            youthMonthlyAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void lowIncomeMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(lowIncomeAmountLabel.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            lowIncomeMonthlyAmount--;
            lowIncomeAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;
        }

        private void lowIncomePlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(lowIncomeAmountLabel.Content.ToString());
            curr++;
            lowIncomeMonthlyAmount++;
            lowIncomeAmountLabel.Content = curr.ToString();
            string temp = string.Format("{0:0.00}", calcCurrentCartTotal());
            checkoutButton.Content = "CHECKOUT $" + temp;

        }

        private void checkoutButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO, we have to send the data to 
            this.NavigationService.Navigate(new checkout());
        }

        
    }
}
