﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClientVSFly.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public int Weight { get; set; }
    }
}
