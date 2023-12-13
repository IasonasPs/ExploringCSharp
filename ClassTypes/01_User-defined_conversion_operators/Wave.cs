using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes._01_User_defined_conversion_operators
{
    public class Wave
    {
        public int Energy { get; set; }
        private const int C = 3;
        public Wave(int energy)
        {
            Energy = energy;
        }

        public static explicit operator Particle(Wave wave) 
        {
            Particle particle = new Particle(wave.Energy / (C * C));
            return particle;
        }
    }
}
