using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop___Labb_3.Models;
using Workshop___Labb_3.Models.Events;

namespace Workshop___Labb_3
{
    class Runtime
    {
        public void Start()
        {
            List<Event> events = new List<Event>();

            events.AddRange(new Event[]
                { new Movie
                { Name = "Korvjakt"
                }
                });
        }
    }
}
