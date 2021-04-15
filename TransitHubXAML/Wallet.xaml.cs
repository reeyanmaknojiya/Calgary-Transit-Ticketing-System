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
        private Boolean isTicket1;
        private Boolean isTicket2;
        private Boolean isTicket3;

        public Wallet()
        {
            InitializeComponent();
        }

        private void Ticket_1_Click(object sender, RoutedEventArgs e)
        {
            if (!isTicket1)
            {
                isTicket1 = true;
                this.NavigationService.Navigate(new ticketDisplay(ticket1.Content.ToString(), ticketDate1.Content.ToString(), this));
            } else
            {
                this.NavigationService.Navigate(new activatedTicketDisplay(ticket1.Content.ToString(), ticketDate1.Content.ToString(), this));
            }
        }

        private void Ticket_2_Click(object sender, RoutedEventArgs e)
        {
            if (!isTicket2)
            {
                isTicket2 = true;
                this.NavigationService.Navigate(new ticketDisplay(ticket2.Content.ToString(), ticketDate2.Content.ToString(), this));
            }
            else
            {
                this.NavigationService.Navigate(new activatedTicketDisplay(ticket2.Content.ToString(), ticketDate2.Content.ToString(), this));
            }
        }

        private void Ticket_3_Click(object sender, RoutedEventArgs e)
        {
            if (!isTicket3)
            {
                isTicket3 = true;
                this.NavigationService.Navigate(new ticketDisplay(ticket3.Content.ToString(), ticketDate3.Content.ToString(), this));
            }
            else
            {
                this.NavigationService.Navigate(new activatedTicketDisplay(ticket3.Content.ToString(), ticketDate3.Content.ToString(), this));
            }
        }

        private void Adult_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new adultPass(this));
        }

        private void Youth_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new youthPass(this));
        }

        private void Senior_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new seniorPass(this));
        }

    }
}
