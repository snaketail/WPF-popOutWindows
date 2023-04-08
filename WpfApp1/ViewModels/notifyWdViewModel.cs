using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace WpfApp1.ViewModels
{
    public class notifyWdViewModel:ViewModelBase
    {
        private int updateInterval = 3000;
        private Timer _updateTimer; //this timer is to update the realtime curve from displayCache.

        private Visibility _wdVisiable;

        public Visibility WdVisiable
        {
            get { return _wdVisiable; }
            set 
            { 
                _wdVisiable = value;
                base.OnPropertyChanged("WdVisiable");
                Console.WriteLine("Window Visibility Changed");
            }
        }


        private string _strNotification;

        public string StrNotification
        {
            get { return _strNotification; }
            set 
            { 
                _strNotification = value;
                base.OnPropertyChanged("StrNotification");
            }
        }


        public notifyWdViewModel()
        {
            Console.WriteLine("Notification Window Created and Shown");
            WdVisiable = Visibility.Visible;
            StrNotification = "Notification Window Shown";


            _updateTimer = new Timer();
            _updateTimer.Interval = updateInterval;
            _updateTimer.AutoReset = true;
            _updateTimer.Elapsed += OnTimerEvent;
            _updateTimer.Enabled = true;

        }

        private void OnTimerEvent(Object source, ElapsedEventArgs e)
        {
            if (WdVisiable == Visibility.Visible)
            {
                WdVisiable = Visibility.Collapsed;
                StrNotification = "Notification Window Hidden";
                Console.WriteLine("Notification Window Hidden");
            }
            else
            {
                WdVisiable = Visibility.Visible;
                StrNotification = "Notification Window Shown";

                Console.WriteLine("Notification Window Shown");
            }
        }

    }
}
