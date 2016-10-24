using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.Models
{
    class Game
    {
        public enum GenreType
        {
            Action = 1,
            RPG,
            Adventure,
            Strategy,
            Racing
        }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
