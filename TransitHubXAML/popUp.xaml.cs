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
    /// Interaction logic for popUp.xaml
    /// </summary>
    public partial class popUp : Window
    {
        public popUp()
        {
            InitializeComponent();
            string paymentType = (string)App.Current.Properties["paymentMethod"];
            switch (paymentType)
            {
                case "visa":
                    _label.Content = "Proceed with Visa?";
                    break;
                case "mastercard":
                    _label.Content = "Proceed with Mastercard?";
                    break;
                case "paypal":
                    _label.Content = "Proceed with paypal?";
                    break;
            }
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void proceed_Click(object sender, RoutedEventArgs e)
        {
            windowAccess.Wnd.mainFrame.Navigate(new thankYou());
            windowAccess.Wnd.image5.Source = new BitmapImage(new Uri("Resources/accountNav.png", UriKind.Relative));
            windowAccess.Wnd.image2.Source = new BitmapImage(new Uri("Resources/cart.png", UriKind.Relative));
            windowAccess.Wnd.currentIcon = 0;
            this.Close();
        }
    }
}
