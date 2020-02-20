using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GunnarsAuto
{
    public class ViewModel
    {
        private Repository repository;
        public static List<SalesPerson> sellersList = new List<SalesPerson>();

        public ViewModel()
        {
            repository = new Repository();
           // List<SalesPerson> sellersList = Repository.GetAllSellers();
            SalesPersons = new ObservableCollection<SalesPerson>(sellersList);
        }

        public ObservableCollection<SalesPerson> SalesPersons { get; set; }

        public SalesPerson SelectedSalesPerson { get; set; }
    }
}
