using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes._01_User_defined_conversion_operators
{
    public class Convertor
    {
        public static void ConvertorMain(string[] args)
        {
            #region implicit operator 
            Particle particle = new Particle(12);

            Console.WriteLine("Particle's mass is : {0}",particle.mass);


            Wave wave = particle; // use of implicit operator

            Console.WriteLine("Particle converted to Wave with energy : {0}", wave.Energy);
            #endregion

            Particle parentParticle = (Particle)wave; //use of explicit operator

            Console.WriteLine("Wave converted to particle with mass : {0}",parentParticle.mass);
        }




    }
}
