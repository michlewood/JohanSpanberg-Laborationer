using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_6___Interfaces.Interfaces
{
    // Generellt för ett interface är att dom definerar _vad_ någonting kan göra eller innehåller.
    // Ett beteende
    // Alltså bara vad, inte hur.
    interface IFlyable
    {
        int TopSpeed { get; set; }
        void Fly();
    }
}
