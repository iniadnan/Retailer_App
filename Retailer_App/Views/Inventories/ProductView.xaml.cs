using Retailer_App.ViewModels;
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

namespace Retailer_App.Views.Inventories
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
            vm = new ProductViewModel();
            DataContext = vm;
        }

        private readonly ProductViewModel vm;

        private void TblData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
        }
    }
}
