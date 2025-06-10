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
using AcousticSystems.Model;
using Microsoft.Win32;

namespace AcousticSystems.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();

            //MakeOrderGrid.DataContext = ProductsListLv.SelectedItem as Products;
            MakeOrderGrid.DataContext = App.context.Products.ToList();
        }

        private void ProductsListLv_Loaded(object sender, RoutedEventArgs e)
        {
            ProductsListLv.ItemsSource = App.context.Products.ToList();
        }

        private void ProductsListLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MakeOrderGrid.DataContext = ProductsListLv.SelectedItem as Products;

        }

        private void MakeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
         
                App.context.SaveChanges();
                MessageBox.Show("Заказ оформлен!", "Оформление заказа", MessageBoxButton.OK, MessageBoxImage.Information);

                OrderNameTxblk.Text = "";
                OrderBrandTxblk.Text = "";
                OrderModelTxblk.Text = "";
                OrderPriceTxblk.Text = "";
                OrderAmountInStockTxblk.Text = "";
                OrderDescriptionTxblk.Text = "";
        }
    }
}
