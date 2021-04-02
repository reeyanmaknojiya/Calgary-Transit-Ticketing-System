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
    /// Interaction logic for testPage.xaml
    /// </summary>
    public partial class storePage : Page
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
        public int[] items = new int[5];

        private double calcCurrentCartTotal()
        {
            double val = (adultTicketPrice * adultTicketAmount) +
                         (youthTicketPrice * youthTicketAmount) +
                         (adultMonthlyPrice * adultMonthlyAmount) +
                         (youthMonthlyPrice * youthMonthlyAmount) +
                         (lowIncomeMonthlyPrice * lowIncomeMonthlyAmount);

            return val;
        }

        public storePage()
        {   

            InitializeComponent();
        }

        //Both of these functions need to update both of the add to cart buttons, wipe out all existing items
        private void ticketsAddToCart_Click(object sender, RoutedEventArgs e)
        {
            //We go through all the amounts and set that as our 
            items[(int)Enums.adultTicket] = adultTicketAmount;
            items[(int)Enums.youthTicket] = youthTicketAmount;
            items[(int)Enums.adultMonthly] = adultMonthlyAmount;
            items[(int)Enums.youthMontly] = youthMonthlyAmount;
            items[(int)Enums.lowIncomeMonthly] = lowIncomeMonthlyAmount;
        }

        private void passesAddToCart_Click(object sender, RoutedEventArgs e)
        {
            items[(int)Enums.adultTicket] = adultTicketAmount;
            items[(int)Enums.youthTicket] = youthTicketAmount;
            items[(int)Enums.adultMonthly] = adultMonthlyAmount;
            items[(int)Enums.youthMontly] = youthMonthlyAmount;
            items[(int)Enums.lowIncomeMonthly] = lowIncomeMonthlyAmount;
        }

        private void adultMonthlyPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultMonthlyCount.Content.ToString());
            curr++;
            adultMonthlyAmount++;
            adultMonthlyCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }
        private void adultMonthlyMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultMonthlyCount.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            adultMonthlyAmount--;
            adultMonthlyCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void adultTicketPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultTicketCount.Content.ToString());
            curr++;
            adultTicketAmount++;
            adultTicketCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void adultTicketMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(adultTicketCount.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            adultTicketAmount--;
            adultTicketCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void youthTicketPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthTicketCount.Content.ToString());
            curr++;
            youthTicketAmount++;
            youthTicketCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void youthTicketMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthTicketCount.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            youthTicketAmount--;
            youthTicketCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;

        }

        private void youthMonthlyPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthMonthlyCount.Content.ToString());
            curr++;
            youthMonthlyAmount++;
            youthMonthlyCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void youthMonthlyMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(youthMonthlyCount.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            youthMonthlyAmount--;
            youthMonthlyCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void lowIncomeMonthlyPlus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(lowIncomeCount.Content.ToString());
            curr++;
            lowIncomeMonthlyAmount++;
            lowIncomeCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

        private void lowIncomeMonthlyMinus_Click(object sender, RoutedEventArgs e)
        {
            int curr = Int32.Parse(lowIncomeCount.Content.ToString());

            if (curr < 1)
                return;
            curr--;
            lowIncomeMonthlyAmount--;
            lowIncomeCount.Content = curr.ToString();
            ticketsAddToCart.Content = "ADD TO CART $" + calcCurrentCartTotal().ToString();
            passesAddToCart.Content = ticketsAddToCart.Content;
        }

    
    }
}
