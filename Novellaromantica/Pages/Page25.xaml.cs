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
using System.Windows.Shapes;

namespace Novellaromantica.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page25.xaml
    /// </summary>
    public partial class Page25 : Page
    {
        public Page25()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("pages/page.xaml", UriKind.Relative));
        }

        private void buttonB_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("pages/page.xaml", UriKind.Relative));
        }
    }
}
