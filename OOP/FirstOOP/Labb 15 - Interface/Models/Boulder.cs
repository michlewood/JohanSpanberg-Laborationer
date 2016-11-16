using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Boulder : IPushable
    {
        public string Push()
        {
            return "Boulder has been pushed away.";
        }
    }
}
