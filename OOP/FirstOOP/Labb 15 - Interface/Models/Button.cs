using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Button : IPushable
    {
        public string Push()
        {
            return "Button has been pushed";
        }
    }
}
