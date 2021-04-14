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

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for Wallet.xaml
    /// </summary>
    public partial class Wallet : Page
    {
        public Wallet()
        {
            InitializeComponent();
        }

        private void Ticket_1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ticketDisplay(ticket1.Content.ToString(), ticketDate1.Content.ToString()));
        }

        private void Ticket_2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ticketDisplay(ticket2.Content.ToString(), ticketDate2.Content.ToString()));
        }

        private void Ticket_3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ticketDisplay(ticket3.Content.ToString(), ticketDate3.Content.ToString()));
        }

    }
}
