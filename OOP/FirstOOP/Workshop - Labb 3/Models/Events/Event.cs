using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop___Labb_3.Models.Events
{
    abstract class Event
    {
        public enum EventTypes
        {
            Movie,
            Concert
        }

        public virtual string Name { get; set; }
        public virtual DateTime Start { get; set; }

        public EventTypes Type { get; set; }

        public virtual string GetEventInfo()
        {
            return String.Format("");
        }
    }
}
