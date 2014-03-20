using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace northwindstock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private NorthWindDataContext db;

        public MainWindow()
        {
            InitializeComponent();
            db = new NorthWindDataContext();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxSupplier.ItemsSource = db.Suppliers;
            lbxSupplier.DisplayMemberPath = "CompanyName";
            lbxCountry.ItemsSource = (from s in db.Suppliers
                                         select s.Country).Distinct();
        }

        private void lbxStockLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lbx = (ListBox)sender;
            ListBoxItem lbxItem = (ListBoxItem)lbx.SelectedItem;
            string choice = (String)lbxItem.Content;

            switch (choice)
            {
                case "Low":
                    lbxProducts.ItemsSource = from p in db.Products
                                              where p.UnitsInStock < 20
                                              select p;
                    break;
                case "Normal":
                    lbxProducts.ItemsSource = from p in db.Products
                                              where (p.UnitsInStock >= 20 &&
                                                p.UnitsInStock <100)
                                              select p;
                    break;
                case "Over-stocked":
                    lbxProducts.ItemsSource = from p in db.Products
                                              where p.UnitsInStock >= 100
                                              select p;
                    break;
                default:
                    lbxProducts.ItemsSource = from p in db.Products
                                              select p;
                    break;
            }
        }


    }   // end class
}
