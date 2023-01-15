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
using System.Windows.Shapes;

namespace Retailer_App.Views.Home
{
    public partial class LoginDialog : Window
    {
        public LoginDialog()
        {
            vm = new UserViewModel();
            InitializeComponent();
            vm.OnCallBack += Close;
            DataContext = vm;
        }

        private readonly UserViewModel vm;

        private void TxtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            vm.Model.Keypass = TxtPass.Password;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
