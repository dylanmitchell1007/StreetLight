﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StreetLight
{
   public class Transition
    {
        public string input
        {
            get;
            private set;
        }

        public State destination
        {
            get;
            private set;
        }

        public Transition(string token, State t)
        {
            input = token;
            destination = t;
        }
    }
}
