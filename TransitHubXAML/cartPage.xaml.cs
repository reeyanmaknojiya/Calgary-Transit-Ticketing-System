﻿using System;
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
using TransitHubXAML.Models;

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for cartPage.xaml
    /// </summary>
    public partial class cartPage : Page
    {
        public cartPage(int[] items)
        {
            adultTicketAmountLabel.Content = items[(int)Enums.adultTicket].ToString();
            InitializeComponent();
        }
    }
}