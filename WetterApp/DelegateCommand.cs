using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WetterApp
{
    public class DelegateCommand : ICommand
    {

        Action<object> executeDelegate;
        Func<object, bool> canExecuteDelegate;

        public DelegateCommand(Action<object> executeDelegate, Func<object, bool> caenExecuteDelegate = null)
        {
            this.executeDelegate = executeDelegate;
            this.canExecuteDelegate = caenExecuteDelegate;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            if(canExecuteDelegate == null)
            {
                return true;
            }
            return canExecuteDelegate(parameter);
        }

        public void Execute(object parameter)
        {
            executeDelegate?.Invoke(parameter);
        }
    }
}
