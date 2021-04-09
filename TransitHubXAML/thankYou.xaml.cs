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
using System.Windows.Shapes;
using TransitHubXAML.Models;


namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for thankYou.xaml
    /// </summary>
    public partial class thankYou : Page
    {
        public thankYou()
        {
            InitializeComponent();
            
            if (App.Current.Properties.Contains("itemsToCart"))
            {
                int[] inCart = (int[])App.Current.Properties["itemsToCart"];
                fillOutOrder(inCart); 
            }
        }

        private void fillOutOrder(int[] inCart)
        {
            OrderDetailsText.Text = "";
            if(inCart[(int)Enums.adultTicket] > 0)
                OrderDetailsText.Text = OrderDetailsText.Text + "Adult Ticket x" + inCart[(int)Enums.adultTicket].ToString() + "\n";

            if (inCart[(int)Enums.youthTicket] > 0)
                OrderDetailsText.Text = OrderDetailsText.Text + "Youth Ticket x" + inCart[(int)Enums.youthTicket].ToString() + "\n";
            
            if (inCart[(int)Enums.adultMonthly] > 0)
                OrderDetailsText.Text = OrderDetailsText.Text + "Adult Monthly Pass x" + inCart[(int)Enums.adultMonthly].ToString() + "\n";

            if (inCart[(int)Enums.youthMonthly] > 0)
                OrderDetailsText.Text = OrderDetailsText.Text + "Youth Monthly Pass x" + inCart[(int)Enums.youthMonthly].ToString() + "\n";

            if (inCart[(int)Enums.lowIncomeMonthly] > 0)
                OrderDetailsText.Text = OrderDetailsText.Text + "Low Income Pass x" + inCart[(int)Enums.lowIncomeMonthly].ToString() + "\n";
            
            totalLabel.Content = "$" + App.Current.Properties["currCost"];
            Random rand = new Random();
            receiptNumber.Content = rand.Next(9999, 99999).ToString();

            DateTime date = DateTime.Now;
            dateLabel.Content = date.Day + "/" + date.Month + "/" + date.Year; 
        }
    }
}
