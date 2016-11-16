using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class Car : IVehicle
    {
        public bool Locked { get; set; }
        public bool Started { get; set; }

        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Car is locked.");
        }

        public void Start()
        {
            Started = true;
            Console.WriteLine("Car is started.");
        }

        public void Stop()
        {
            Started = false;
            Console.WriteLine("Car is stopped.");
        }

        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Car is unlocked.");
        }
    }
}
