using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Model.Commands
{
    public class StartCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action startAction;

        public StartCommand(Action startAction)
        {
            this.startAction = startAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            startAction.Invoke();
        }
    }
}
