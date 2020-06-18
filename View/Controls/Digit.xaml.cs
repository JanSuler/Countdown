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
    /// Interaction logic for Digit.xaml
    /// </summary>
    public partial class Digit : UserControl
    {
        public Number Number
        {
            set
            {
                TopSegment.Color = value.Segments.ElementAt(0) ? value.Color : Colors.Black;
                TopLeftSegment.Color = value.Segments.ElementAt(1) ? value.Color : Colors.Black;
                TopRightSegment.Color = value.Segments.ElementAt(2) ? value.Color : Colors.Black;
                MiddleSegment.Color = value.Segments.ElementAt(3) ? value.Color : Colors.Black;
                BottomLeftSegment.Color = value.Segments.ElementAt(4) ? value.Color : Colors.Black;
                BottomRightSegment.Color = value.Segments.ElementAt(5) ? value.Color : Colors.Black;
                BottomSegment.Color = value.Segments.ElementAt(6) ? value.Color : Colors.Black;
            }
        }

        public Digit()
        {
            InitializeComponent();
            Number = Numbers.None;
        }
    }
}
