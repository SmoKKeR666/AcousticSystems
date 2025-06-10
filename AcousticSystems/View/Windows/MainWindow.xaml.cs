﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AcousticSystems.AppData;
using AcousticSystems.View.Pages;

namespace AcousticSystems
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.mainFrame = FunctionalFrame;
            ClassFrame.mainFrame.Navigate(new CatalogPage());
        }

        private void CatalogBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new CatalogPage());
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new MyOrdersPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
