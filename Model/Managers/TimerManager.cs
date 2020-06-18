using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace Model.Managers
{
    /**
     * Counting down from specified time by specified interval and notifies listeners of each passed interval
     **/
    public class TimerManager
    {
        private TimeSpan remainingTime;

        private TimeSpan interval;

        private List<IReceiveTimerTick> listeners = new List<IReceiveTimerTick>();

        private DispatcherTimer timer;

        public TimerManager(TimeSpan timerLenght, TimeSpan interval)
        {
            this.interval = interval;
            remainingTime = timerLenght;
            timer = new DispatcherTimer(DispatcherPriority.Render);
            timer.Tick += new EventHandler(onTick);
            timer.Interval = interval;
        }

        public void StartTimer()
        {
            timer.Start();
        }

        public void addTimerTickListener(IReceiveTimerTick listener)
        {
            listeners.Add(listener);
        }

        private void onTick(object sender, EventArgs e)
        {
            remainingTime = remainingTime.Subtract(interval);
            if (remainingTime.TotalMilliseconds <= 0)
                timer.Stop();
            notifyListeners();
        }

        private void notifyListeners()
        {
            foreach (IReceiveTimerTick listener in listeners)
                listener.OnTimerTick(remainingTime);
        }
    }
}
