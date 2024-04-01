using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public  class TwoPartJoke:Joke
    {
        public string Setup { get; set; }
        public string Delivery { get; set; }
    }
}
