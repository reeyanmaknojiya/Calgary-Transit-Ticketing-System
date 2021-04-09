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
    /// Interaction logic for checkout.xaml
    /// </summary>
    public partial class checkout : Page
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void visaChange(object sender, MouseButtonEventArgs e)
        {
            visaRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.AliceBlue);
        }

        private void msChange(object sender, MouseButtonEventArgs e)
        {
            msRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.AliceBlue);
        }

        private void ppChange(object sender, MouseButtonEventArgs e)
        {
            ppRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.AliceBlue);
        }

        private void Paypal_Click(object sender, MouseButtonEventArgs e)
        {
            App.Current.Properties["paymentMethod"] = "paypal";
            this.NavigationService.Navigate(new thankYou());
        }

        private void MasterCard_Click(object sender, MouseButtonEventArgs e)
        {
            App.Current.Properties["paymentMethod"] = "mastercard";
            this.NavigationService.Navigate(new thankYou());
        }

        private void Visa_Click(object sender, MouseButtonEventArgs e)
        {
            App.Current.Properties["paymentMethod"] = "visa";
            this.NavigationService.Navigate(new thankYou());
        }

        private void back_button(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new cartPage());
        }
    }
}
