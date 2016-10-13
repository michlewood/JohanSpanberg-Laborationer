using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    public abstract class Animal
    {
        public string AnimalType { get; set; }
        public string AnimalName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int NumberOfLegs { get; set; }
        public int CanSwim { get; set; }
        public int Looks { get; set; }
        public int Move { get; set; }
        public string Sound { get; set; }

        public virtual string Presentation()
        {
            return String.Format("Jag är en {0} som heter {1} och är {2} år gammal. Jag är {3} cm lång och har {4} ben. Jag kan {5}", AnimalType, AnimalName, Age, Height, NumberOfLegs, Sound);
        }
    }

    public class Mammal : Animal
    {
        public int CanRun { get; set; }
        public int FurLength { get; set; }

        public override string Presentation()
        {
            return String.Format("{0}. Jag har dessutom {1} cm lång päls.", base.Presentation(), FurLength);
        }
    }
    public class Reptile : Animal
    {
        public int SkinShredding { get; set; }

        public override string Presentation()
        {
            return String.Format("{0}. Jag ömsar dessutom mitt skinn {1} gånger per år.", base.Presentation(), SkinShredding);
        }

    }
    public class Bird : Animal
    {
        public int CanFly { get; set; }
        public int CanRun { get; set; }
        public int BeakSize { get; set; }

        public override string Presentation()
        {
            return String.Format("{0}. Min näbb dessutom är {1} cm lång.", base.Presentation(), BeakSize);
        }
    }
}
