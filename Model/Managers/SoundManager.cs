using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Managers
{
    public static class SoundManager
    {
        /**
         * Checks if sound shoudl be played for given remaining time and plays it in the background
         **/
        public static void CheckAndBeep(TimeSpan remainingTime)
        {
            if (remainingTime.TotalSeconds == 0)
            {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += new DoWorkEventHandler(beepFinal);
                backgroundWorker.RunWorkerAsync();
                return;
            }

            if (remainingTime.TotalSeconds <= 10)
            {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += new DoWorkEventHandler(beepShort);
                backgroundWorker.RunWorkerAsync();
                return;
            }

            if (remainingTime.Seconds == 0)
            {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += new DoWorkEventHandler(beepLong);
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void beepShort(object sender, DoWorkEventArgs e)
        {
            Console.Beep(2000, 200);
        }

        private static void beepLong(object sender, DoWorkEventArgs e)
        {
            Console.Beep(2000, 1000);
        }

        private static void beepFinal(object sender, DoWorkEventArgs e)
        {
            Console.Beep(2000, 2000);
        }
    }
}
