using Model.Commands;
using Model.Numbers;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Model.Managers;
using Model.Enums;

namespace ViewModel
{
    public class CountdownViewModel : INotifyPropertyChanged, IReceiveTimerTick
    {
        private TimerManager timerManager;

        public TimerLenghtEnum TimerLenghtEnum { get; set; }

        private Number firstNumber;

        public Number FirstNumber
        {
            get
            {
                return firstNumber;
            }
            set
            {
                if (value != firstNumber)
                {
                    firstNumber = value;
                    notifyPropertyChanged("FirstNumber");
                }
            }
        }

        private Number secondNumber;

        public Number SecondNumber
        {
            get
            {
                return secondNumber;
            }
            set
            {
                if (value != secondNumber)
                {
                    secondNumber = value;
                    notifyPropertyChanged("SecondNumber");
                }
            }
        }

        private Number thirdNumber;

        public Number ThirdNumber
        {
            get
            {
                return thirdNumber;
            }
            set
            {
                if (value != thirdNumber)
                {
                    thirdNumber = value;
                    notifyPropertyChanged("ThirdNumber");
                }
            }
        }

        private bool colonVisible;

        public bool ColonVisible
        {
            get
            {
                return colonVisible;
            }
            set
            {
                if (value != colonVisible)
                {
                    colonVisible = value;
                    notifyPropertyChanged("ColonVisible");
                }
            }
        }

        public ICommand StartCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CountdownViewModel()
        {
            TimerLenghtEnum = TimerLenghtEnum.FiveMinutes;
            ColonVisible = true;
            StartCommand = new StartCommand(StartCountdown);
        }

        public void StartCountdown()
        {
            TimeSpan timerLenght = getTimerLenght();

            setDisplay(timerLenght);
                
            timerManager = new TimerManager(timerLenght, new TimeSpan(0, 0, 1));
            timerManager.addTimerTickListener(this);
            timerManager.StartTimer();
        }

        public void OnTimerTick(TimeSpan remainingTime)
        {
            SoundManager.CheckAndBeep(remainingTime);
            setDisplay(remainingTime);
        }

        /**
         * Returns time to count from
         **/
        private TimeSpan getTimerLenght()
        {
            TimeSpan timerLenght = new TimeSpan();
            switch (TimerLenghtEnum)
            {
                case TimerLenghtEnum.OneMinute:
                    timerLenght = new TimeSpan(0, 1, 0);
                    break;
                case TimerLenghtEnum.ThreeMinutes:
                    timerLenght = new TimeSpan(0, 3, 0);
                    break;
                case TimerLenghtEnum.FiveMinutes:
                    timerLenght = new TimeSpan(0, 5, 0);
                    break;
            }
            return timerLenght;
        }

        private void setDisplay(TimeSpan remainingTime)
        {
            clearDisplay();
            // colon is no longer needed in last minute
            if (remainingTime.TotalMinutes < 1)
                ColonVisible = false;
            Tuple<Number, Number, Number> numbers = NumbersManager.GetMSS(remainingTime);
            FirstNumber = numbers.Item1;
            SecondNumber = numbers.Item2;
            ThirdNumber = numbers.Item3;
        }

        private void clearDisplay()
        {
            FirstNumber = Numbers.None;
            SecondNumber = Numbers.None;
            ThirdNumber = Numbers.None;
        }

        private void notifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
