using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaStellar.Data.Models
{
    public class Car:Vehicle
    {
        public int id { get; set; }
        public bool wheels { get; set; }
        public bool headlights { get; set; }
    }
}
