using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.Models
{
    class Show
    {
        public enum GenreType
        {
            Action = 1,
            Romance,
            SciFi,
            Supernatural,
            Comedy
        }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
