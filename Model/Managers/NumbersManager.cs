using Model.Numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Model.Managers
{
    public static class NumbersManager
    {
        /**
         * Returns tuple of Numbers representing given time in MSS format.
         * First Number represents Minutes
         * Second Number represents tens of Seconds
         * Third Number represents Seconds
         **/
        public static Tuple<Number, Number, Number> GetMSS(TimeSpan remainingTime)
        {
            Number minutesNumber = null;
            Number secondTensNumber = null;
            Number secondsNumber = null;

            int minutes = remainingTime.Minutes % 10;
            int secondTens = remainingTime.Seconds / 10;
            int seconds = remainingTime.Seconds % 10;

            minutesNumber = minutes == 0 ? Numbers.Numbers.None : Numbers.Numbers.Get(minutes, Colors.Red);

            if (remainingTime.TotalSeconds <= 10)
            {
                if (remainingTime.TotalSeconds == 10)
                    secondTensNumber = Numbers.Numbers.Get(secondTens, Colors.Yellow);
                else
                    secondTensNumber = Numbers.Numbers.None;
            }
            else
                secondTensNumber = Numbers.Numbers.Get(secondTens, Colors.Green);

            if (remainingTime.TotalSeconds <= 10)
            {
                if (remainingTime.TotalSeconds == 0)
                    secondsNumber = Numbers.Numbers.Get(seconds, Colors.Red);
                else
                    secondsNumber = Numbers.Numbers.Get(seconds, Colors.Yellow);
            }
            else
                secondsNumber = Numbers.Numbers.Get(seconds, Colors.Green);

            return new Tuple<Number, Number, Number>(minutesNumber, secondTensNumber, secondsNumber);
        }
    }
}
