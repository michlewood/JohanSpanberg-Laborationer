using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_14___Klasser__Objekt__Arv_och_Polymorfism
{
    public class Book : Publication
    {
        public string Genre { get; set; }
        public int Pages { get; set; }
    }
}