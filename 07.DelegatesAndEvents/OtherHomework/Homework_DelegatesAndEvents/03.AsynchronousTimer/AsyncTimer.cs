using System;
using System.Threading;

namespace Timer
{
    public class AsyncTimer
    {
        private int ticks;
        private int interval;

        public AsyncTimer(Action<int> action, int ticks, int interval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public Action<int> Action { get; private set; }

        public int Ticks
        {
            get { return this.ticks; }

            set
            {
                if (value <= 0)
                {
                    throw  new ArgumentOutOfRangeException("value", "The number of your ticks can not be negative or zero");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get { return this.interval; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Your interval can not be negative or zero");
                }

                this.interval = value;
            }
        }

        public void Execute()
        {
            Thread paralelThread = new Thread(this.Run);
            paralelThread.Start();
        }

        public void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.Interval);

                if (this.Action != null)
                {
                    this.Action(i);
                }
            }
        }
    }
}
