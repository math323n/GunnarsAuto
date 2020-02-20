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

namespace GunnarsAuto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private ViewModel viewModel;
        public static Repository cars;

        public MainWindow()
        { 
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
            Repository.GetAllSellers();
            //database.ItemsSource = Repository.GetAllSellers();
           loginSeller.ItemsSource = Repository.GetAllSellers();
            
           
        }
        public void SalesPersonSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SalesPerson salesPerson = loginSeller.SelectedItem as SalesPerson;
            viewModel.SelectedSalesPerson = salesPerson;
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
