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

            if (!User.loggedIn)
            {
                oneTimeCard.Margin = new Thickness(33, 200, 0, 0);
                labelNotSaved.Margin = new Thickness(33, 258, 0, 0);
                oneTimeCard.Content = "Guest Checkout";
                visaRectangle.Visibility = System.Windows.Visibility.Hidden;
                visaLabel1.Visibility = System.Windows.Visibility.Hidden;
                visaLabel2.Visibility = System.Windows.Visibility.Hidden;
                visaImage.Visibility = System.Windows.Visibility.Hidden;

                msRectangle.Visibility = System.Windows.Visibility.Hidden;
                msLabel1.Visibility = System.Windows.Visibility.Hidden;
                msLabel2.Visibility = System.Windows.Visibility.Hidden;
                msImage.Visibility = System.Windows.Visibility.Hidden;

                ppRectangle.Visibility = System.Windows.Visibility.Hidden;
                ppLabel1.Visibility = System.Windows.Visibility.Hidden;
                ppImage.Visibility = System.Windows.Visibility.Hidden;
            }
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
            ppRectangle.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF4F4F5"));
            App.Current.Properties["paymentMethod"] = "paypal";

            Window wnd = new popUp();
            wnd.Show();
            //this.NavigationService.Navigate(new thankYou());
        }

        private void MasterCard_Click(object sender, MouseButtonEventArgs e)
        {
            msRectangle.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF4F4F5"));
            App.Current.Properties["paymentMethod"] = "mastercard";

            Window wnd = new popUp();
            wnd.Show();
            //this.NavigationService.Navigate(new thankYou());
        }

        private void Visa_Click(object sender, MouseButtonEventArgs e)
        {
            visaRectangle.Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF4F4F5"));
            App.Current.Properties["paymentMethod"] = "visa";

            Window wnd = new popUp();
            wnd.Show();
            
            //this.NavigationService.Navigate(new thankYou());
        }

        private void back_button(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new cartPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new paymentInformationPage());
        }
    }
}
