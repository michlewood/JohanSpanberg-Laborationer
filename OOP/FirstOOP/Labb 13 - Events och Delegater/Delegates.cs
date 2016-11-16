using Labb_13___Events_och_Delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_Delegater
{
    public delegate bool ItemFilter(Item item);
    public delegate void PrintMessage(string message);
}
