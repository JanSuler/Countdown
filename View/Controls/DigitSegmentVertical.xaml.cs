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
    /// Interaction logic for DigitSegmentVertical.xaml
    /// </summary>
    public partial class DigitSegmentVertical : UserControl
    {
        private Color color;

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Segment.Fill = new SolidColorBrush(value);
            }
        }

        public DigitSegmentVertical()
        {
            InitializeComponent();
            Color = Colors.DarkSlateGray;
        }
    }
}
