using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class Joke
    {
        public Flags Flags { get; set; }
        public int Id { get; set; } 
        public ServiceError ServiceError { get; set; }

    }
}
