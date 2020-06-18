using Model.Numbers;
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

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for TripleDigit.xaml
    /// </summary>
    public partial class TripleDigit : UserControl
    {
        public static readonly DependencyProperty FirstNumberProperty = DependencyProperty.Register("FirstNumber", typeof(Number), typeof(TripleDigit), new PropertyMetadata(onFirstNumberChanged));

        public Number FirstNumber
        {
            get
            {
                return (Number)GetValue(FirstNumberProperty);
            }
            set
            {
                SetValue(FirstNumberProperty, value);
            }
        }

        public static readonly DependencyProperty SecondNumberProperty = DependencyProperty.Register("SecondNumber", typeof(Number), typeof(TripleDigit), new PropertyMetadata(onSecondNumberChanged));

        public Number SecondNumber
        {
            get
            {
                return (Number)GetValue(SecondNumberProperty);
            }
            set
            {
                SetValue(SecondNumberProperty, value);
            }
        }

        public static readonly DependencyProperty ThirdNumberProperty = DependencyProperty.Register("ThirdNumber", typeof(Number), typeof(TripleDigit), new PropertyMetadata(onThirdNumberChanged));

        public Number ThirdNumber
        {
            get
            {
                return (Number)GetValue(ThirdNumberProperty);
            }
            set
            {
                SetValue(ThirdNumberProperty, value);
            }
        }

        public static readonly DependencyProperty ColonVisibleProperty = DependencyProperty.Register("ColonVisible", typeof(bool), typeof(TripleDigit), new PropertyMetadata(onColonVisibleChanged));

        public bool ColonVisible
        {
            get
            {
                return (bool)GetValue(ColonVisibleProperty);
            }
            set
            {
                SetValue(ColonVisibleProperty, value);
            }
        }

        public TripleDigit()
        {
            InitializeComponent();
        }

        private static void onFirstNumberChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            TripleDigit sender = dependencyObject as TripleDigit;
            sender.SetFirstDigit();
        }

        private static void onSecondNumberChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            TripleDigit sender = dependencyObject as TripleDigit;
            sender.SetSecondDigit();
        }

        private static void onThirdNumberChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            TripleDigit sender = dependencyObject as TripleDigit;
            sender.SetThirdDigit();
        }
        private static void onColonVisibleChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            TripleDigit sender = dependencyObject as TripleDigit;
            sender.ToggleColon();
        }

        public void SetFirstDigit()
        {
            FirstDigit.Number = FirstNumber;
        }

        public void SetSecondDigit()
        {
            SecondDigit.Number = SecondNumber;
        }

        public void SetThirdDigit()
        {
            ThirdDigit.Number = ThirdNumber;
        }

        public void ToggleColon()
        {
            if (ColonVisible)
                Colon.Color = Colors.Green;
            else
                Colon.Color = Colors.Black;
        }
    }
}
