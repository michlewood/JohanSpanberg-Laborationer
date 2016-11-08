using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_8___Events_and_Delegates
{
    class Counter
    {
        public int Threshold { get; set; }
        public int Total { get; set; } = 0;

        // To define an event we use the event-keyword in the declaration
        // The name of an event should describe the condition for raising it.
        public event EventHandler ThresholdReached;

        public void Add(int n)
        {
            Total += n;

            if (Total >= Threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
