using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Retailer_App.Setup
{
    public class RelayCommand : ICommand
    {
        public RelayCommand(Action cmdactone)
        {
            this.cmdactone = cmdactone;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cmdactone();
        }

        private readonly Action cmdactone;
    }
}
