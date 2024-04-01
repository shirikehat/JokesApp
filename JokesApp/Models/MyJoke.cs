using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class MyJoke:OneLiner
    {
        public int FormatVersion { get; set; } = 3;
        public string Lang { get; set; } = "en";

        public string Type { get; set; } = "single";
        public string Category { get; set; } = "Misc";
    }
}
