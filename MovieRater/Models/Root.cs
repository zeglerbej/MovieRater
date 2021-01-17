using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class Root
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Film> results { get; set; }

        public Root(List<Film> films)
        {
            results = films;
        }
    }
}
