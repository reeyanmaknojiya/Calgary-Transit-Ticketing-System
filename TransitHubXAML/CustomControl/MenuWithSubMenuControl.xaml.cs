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
using TransitHubXAML.ViewModel;

// Reference: https://www.youtube.com/watch?v=EedNnnzyQLw

namespace TransitHubXAML.CustomControl
{
    /// <summary>
    /// Interaction logic for MenuWithSubMenuControl.xaml
    /// </summary>
    public partial class MenuWithSubMenuControl : UserControl
    {
        public MenuWithSubMenuControl()
        {
            InitializeComponent();

            // binding viewModel withe the data context to read the menu and submenu 
            DataContext = new MenuViewModel();
        }

        public Thickness SubMenuPadding
        {
            get { return (Thickness)GetValue(SubMenuPaddingProperty); }
            set { SetValue(SubMenuPaddingProperty, value); }
        }

        // using dependencyproperty as the backing store for submenupadding
        // this enables animation,styling, binding, etc
        public static readonly DependencyProperty SubMenuPaddingProperty = DependencyProperty.Register("SubMenuPadding", typeof(Thickness), typeof(MenuWithSubMenuControl));
    }
}
