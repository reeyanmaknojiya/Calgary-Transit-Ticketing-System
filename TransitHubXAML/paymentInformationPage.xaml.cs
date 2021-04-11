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
            //MatchCollection match = ;
            //if (!Regex.Matches(cardHolder.Text, "/ ^[a - z,.'-]+$/i").Success)
            //{
            //    MessageBox.Show("Bad cardholder name");
            //    return;
            //}

            App.Current.Properties["paymentMethod"] = "newCard";
            this.NavigationService.Navigate(new thankYou());
        }
    }
}
