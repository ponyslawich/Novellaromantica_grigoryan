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
    /// Логика взаимодействия для Page20.xaml
    /// </summary>
    public partial class Page20 : Page
    {
        public Page20()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("pages/page21.xaml", UriKind.Relative));
        }
    }
}
