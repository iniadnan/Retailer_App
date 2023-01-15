using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Retailer_App.Views.Home;
using Retailer_App.Views.Inventories;

namespace Retailer_App
{
    public partial class App : Application
    {
        public static Dashboard Dashboard;
        public static RulesDialog RulesDialog;
        public static InventoriesView InventoriesView;
        public static ProductView ProductView;
        public static StockDialog StockDialog;
        public static string SessionUid;
        public static string SessionUser;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            SessionUid = "";
            SessionUser = "";
            new LoginDialog().Show();
        }
    }
}
