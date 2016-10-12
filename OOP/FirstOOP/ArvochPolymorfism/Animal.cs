using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    public class Runtime
    {
        public void TheProgram()
        {
            Console.WriteLine("Hejsan!");
            var dog = new Dog();
            var snake = new Snake();

            Console.WriteLine(dog.Move());
            Console.WriteLine(snake.Sound());
            Console.ReadLine();
        }
    }
    public abstract class Animal
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public virtual string Move()
        {
            return "Jag kan röra på mig.";
        }
        public virtual string Sound()
        {
            return "Jag kan låta.";
        }
        public virtual string Looks()
        {
            return "Jag har ett utseende.";
        }
    }

    public abstract class Mammal : Animal
    {
        public virtual int NumberOfLegs() { return 0; }
        public virtual bool CanSwim() { return false; }
        public virtual bool CanRun() { return false; }
        public virtual bool CanFly() { return false; }
    }
    public abstract class Reptile : Animal
    {
        public virtual int NumberOfLegs() { return 0; }
        public virtual bool CanSwim() { return false; }
        public virtual bool CanRun() { return false; }
        public virtual bool CanFly() { return false; }
    }
    public abstract class Bird : Animal
    {
        public virtual int NumberOfLegs() { return 0; }
        public virtual bool CanSwim() { return false; }
        public virtual bool CanRun() { return false; }
        public virtual bool CanFly() { return false; }
    }
}
