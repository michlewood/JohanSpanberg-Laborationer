using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3___Biljettbokning
{
    public abstract class Event
    {
        public virtual int Date{ get; set; }

        public virtual string Name{ get; set; }

        public virtual int Price{ get; set; }

        public virtual string Location { get; set; }

        public virtual string Type { get; set; }

        public virtual bool IsBooked { get; set; }

        public virtual string Presentation()
        {
            return String.Format("Ingen information");
        }
    }
}