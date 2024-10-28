using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public static class CheckTimer
    {
        private static System.Threading.Timer _timer;
        //private static CheckTimer _instance;
        //private static object _lock = new object();
        static CheckTimer() {
            _timer = new System.Threading.Timer(TimerCallback);
        }
        //public static CheckTimer Instance { get; }
        //= new CheckTimer();
        //public static CheckTimer GetInstance()
        //{
        //    lock (_lock)
        //    { 
        //        if (_instance == null)
        //        {
        //            _instance = new CheckTimer();
        //        }
        //        return _instance;
        //    }
        //}

        public static bool IsError { get; private set; }
        public static void Start()
        {
            _timer.Change(0, 5000);
        }
        private static void TimerCallback(object state)
        {
            Console.WriteLine("timer:"+ DateTime.Now);
        }
    }
}
