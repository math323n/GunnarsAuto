using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow: Window , INotifyPropertyChanged
    {
        
        private ViewModel viewModel;
        /*public static Repository cars;
        public static Repository sellers;*/

        public MainWindow()
        { 
            InitializeComponent();
            Repository.GetAllSellers();
            viewModel = new ViewModel();
            DataContext = viewModel;
          
            //database.ItemsSource = Repository.GetAllSellers();
         // loginSeller.ItemsSource = Repository.GetAllSellers();

            
           
        }
        public void SalesPersonSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SalesPerson salesPerson = loginSeller.SelectedItem as SalesPerson;
            viewModel.SelectedSalesPerson = salesPerson;
            
        }
        private string _selectedItem;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedItem"));
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            loginButton.Content = $"{viewModel.SelectedSalesPerson.FirstName}";
        }
    }
}
