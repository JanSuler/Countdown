using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using View.Windows;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for CountdownWindow.xaml
    /// </summary>
    public partial class CountdownWindow : Window
    {
        public CountdownWindow()
        {
            InitializeComponent();
            showStartDialog();
        }

        private void showStartDialog()
        {
            StartDialog startDialog = new StartDialog((CountdownViewModel)DataContext);
            bool? dialogResult = startDialog.ShowDialog();
            if (dialogResult == null || !dialogResult.Value)
                Close();
        }
    }
}
