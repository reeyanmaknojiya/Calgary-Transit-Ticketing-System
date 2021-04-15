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
    public partial class adultPass : Page
    {
        private Page wallet;
        public adultPass(Page wallet)
        { 
            InitializeComponent();

            this.wallet = wallet;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(wallet);
        }
    }
}
