using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop___Labb_3.Models.Events
{
    class Movie : Event
    {
        public float Length { get; set; }
        
        public override string GetEventInfo()
        {
            var eventInfo = base.GetEventInfo();
            return String.Format("");
        }
    }
}
