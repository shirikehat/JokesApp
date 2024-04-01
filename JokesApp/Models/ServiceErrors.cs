using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokesApp.Models
{

    public class ServiceError
    {

        public bool Error { get; set; }
        public bool InternalError { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public string[] CausedBy { get; set; }
        public string AdditionalInfo { get; set; }
        public long Timestamp { get; set; }
    }

}
