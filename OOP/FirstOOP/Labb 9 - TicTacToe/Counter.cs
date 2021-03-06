﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
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
        }

        public virtual void OnThresholdReached(object sender, EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(sender, e);
            }

        }
    }
}
