using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StreetLight
{
        public enum Lights
        {
            Init = 0,
             Red = 1,
             Yellow = 2,
             Green = 3,
             Exit = 4,
        }


   public class State
    {
        public Enum name;

        public Lights state;

        Stopwatch time;
       


    }
}
