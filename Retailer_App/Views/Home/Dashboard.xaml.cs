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
using System.Windows.Shapes;

namespace Retailer_App.Views.Home
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void MnuUsers_Click(object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            PnlContent.Children.Add(new UsersView());
        }

        private void MnuRelogin_Click(object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            Close();
        }

        private void MnuBackup_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MnuUser_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MnuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MnuInventory_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MnuStock_Click(object sender, RoutedEventArgs e)
        {
        }
        private void MnuProduct_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
