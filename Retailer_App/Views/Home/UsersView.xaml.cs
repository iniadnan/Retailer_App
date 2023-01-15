using Retailer_App.Models;
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

namespace Retailer_App.Views.Home
{
    /// <summary>
    /// Interaction logic for UsersView.xaml
    /// </summary>
    public partial class UsersView : UserControl
    {
        public UsersView()
        {
            InitializeComponent();
            vm = new UserViewModel();
            DataContext = vm;
        }

        private readonly UserViewModel vm;

        private void ResetComponent()
        {
            TxtUid.IsReadOnly = true;

            BtnNew.Visibility = Visibility.Visible;
            BtnEdit.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Hidden;
            TxtUid.Visibility = Visibility.Hidden;

            TxtName.IsEnabled = false;
            TxtUser.IsEnabled = false;
            TxtPassword.IsEnabled = false;
            ChkStatus.IsEnabled = false;

            vm.Model = new User();
            BtnNew.Focus();
        }

        private void TblData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Hidden;
            BtnEdit.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Hidden;
        }


        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetComponent();
        }
        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Visible;
            BtnInsert.Visibility = Visibility.Visible;
            TxtName.IsEnabled = true;
            TxtUser.IsEnabled = true;
            TxtPassword.IsEnabled = true;
            ChkStatus.IsEnabled = true;
            vm.Model = new User();
            vm.IsChecked = true;
            TxtName.Focus();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            BtnEdit.Visibility = Visibility.Hidden;
            BtnInsert.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            TxtName.IsEnabled = true;
            TxtUser.IsEnabled = true;
            TxtPassword.IsEnabled = true;
            ChkStatus.IsEnabled = true;
            TxtUid.Visibility = Visibility.Visible;
            TxtName.Focus();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
