using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDlevyApplication
{
    class Biisi
    {
        public string Songname { get; set; }
        public string Songlength { get; set; }

        public override string ToString()
        {
            return Songname + " " + Songlength;
        }


    }
}
