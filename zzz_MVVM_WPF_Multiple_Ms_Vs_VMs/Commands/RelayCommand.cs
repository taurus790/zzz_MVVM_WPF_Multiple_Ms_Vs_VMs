using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Input;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Commands
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action DoWork; // Delegate. 

        // Constructor. 
        public RelayCommand(Action work)
        {
            DoWork = work;
        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();

            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();

            DoWork();
        }
    }
}
