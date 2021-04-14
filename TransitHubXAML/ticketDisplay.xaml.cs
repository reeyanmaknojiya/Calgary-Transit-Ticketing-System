using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    /// Interaction logic for ticketDisplay.xaml
    /// </summary>
    public partial class ticketDisplay : Page
    {
        private String type;
        private String purchaseDate;
        public ticketDisplay(String type, String date)
        { 
            InitializeComponent();

            ticketTypeLabel.Content = type;
            purchasedLabel.Content = date;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            Random r = new Random();
            String randomString = "";

            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 61)].ToString();
            }

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            var qRDate = qRCodeGenerator.CreateQrCode(randomString, QRCodeGenerator.ECCLevel.H);
            var qRCode = new QRCode(qRDate);
            Bitmap qRImage = qRCode.GetGraphic(50);

            image.Source = BitmapToImageSource(qRImage);

            var date1 = DateTime.Now;

            activateButton.Height = 0;
            activateButton.Width = 0;

            activatedLabel.Content = $"Activated on: {date1:MMMM dd, yyyy H:mm:ss}";
        }

        /*
         Reference: https://www.youtube.com/watch?v=x8iGCWt-4Og
         */
        private ImageSource BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }


        
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Wallet());
        }
    }
}
