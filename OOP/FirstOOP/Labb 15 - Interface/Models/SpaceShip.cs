using Labb_15___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15___Interface.Models
{
    class SpaceShip : IVehicle
    {
        public bool Locked { get; set; } = true;
        public bool Started { get; set; } = false;

        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Spaceship is locked.");
        }

        public void Start()
        {
            Started = true;
            Console.WriteLine("Spaceship is started.");
        }

        public void Stop()
        {
            Started = false;
            Console.WriteLine("Spaceship is stopped.");
        }

        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Spaceship is unlocked.");
        }
    }
}
