using Labb_8___Delegater_VG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class Runtime
    {
        internal void Start()
        {
            var productManager = new ProductManager();
            Graphics.MainMenu(productManager);
        }
    }
}
