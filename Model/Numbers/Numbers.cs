using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Model.Numbers
{
    /**
     * Implements set of predefined numbers and methods to get them from ints
     **/
    public static class Numbers
    {
        public static Number None
        {
            get
            {
                return new Number(false, false, false, false, false, false, false);
            }
        }

        public static Number Zero
        {
            get
            {
                return new Number(true, true, true, false, true, true, true);
            }
        }

        public static Number One
        {
            get
            {
                return new Number(false, false, true, false, false, true, false);
            }
        }

        public static Number Two
        {
            get
            {
                return new Number(true, false, true, true, true, false, true);
            }
        }

        public static Number Three
        {
            get
            {
                return new Number(true, false, true, true, false, true, true);
            }
        }

        public static Number Four
        {
            get
            {
                return new Number(false, true, true, true, false, true, false);
            }
        }

        public static Number Five
        {
            get
            {
                return new Number(true, true, false, true, false, true, true);
            }
        }

        public static Number Six
        {
            get
            {
                return new Number(true, true, false, true, true, true, true);
            }
        }

        public static Number Seven
        {
            get
            {
                return new Number(true, false, true, false, false, true, false);
            }
        }

        public static Number Eight
        {
            get
            {
                return new Number(true, true, true, true, true, true, true);
            }
        }

        public static Number Nine
        {
            get
            {
                return new Number(true, true, true, true, false, true, true);
            }
        }

        /**
         * Returns Number class for given int
         * Throws ArgumentOutOfRange for i smaller than 0 or greater than 9
         **/
        public static Number Get(int? i)
        {
            if (i == null)
                return None;

            switch (i)
            {
                case 0:
                    return Zero;
                case 1:
                    return One;
                case 2:
                    return Two;
                case 3:
                    return Three;
                case 4:
                    return Four;
                case 5:
                    return Five;
                case 6:
                    return Six;
                case 7:
                    return Seven;
                case 8:
                    return Eight;
                case 9:
                    return Nine;
                default:
                    throw new ArgumentOutOfRangeException("i", "Argument i is smaller than 0 or greater than 9");
            }
        }

        /**
         * Returns Number class for given int and color
         * Throws ArgumentOutOfRange for i smaller than 0 or greater than 9
         **/
        public static Number Get(int? i, Color color)
        {
            Number number = Get(i);
            number.Color = color;
            return number;
        }
    }
}
