using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Model.Numbers
{
    /**
     * This class represents displayable number by its individual segments and color
     **/
    public class Number
    {
        public Color Color { get; set; }

        public IReadOnlyList<bool> Segments { get; private set; }

        public Number(bool top, bool topLeft, bool topRight, bool midle, bool bottomleft, bool bottomRight, bool bottom)
        {
            Color = Colors.Black;
            Segments = new List<bool> { top, topLeft, topRight, midle, bottomleft, bottomRight, bottom };
        }

        public Number(Color color, bool top, bool topLeft, bool topRight, bool midle, bool bottomleft, bool bottomRight, bool bottom)
        {
            Color = color;
            Segments = new List<bool> { top, topLeft, topRight, midle, bottomleft, bottomRight, bottom };
        }
    }
}
