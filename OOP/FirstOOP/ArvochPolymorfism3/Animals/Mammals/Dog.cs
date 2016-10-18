using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvochPolymorfism3
{
    public class Dog : Mammal
    {
        public float TailLength { get; set; }

        public override string Move()
        {
            string baseMove = base.Move();
            return String.Format("{0}. The dog jumps around", baseMove);
        }
    }

}