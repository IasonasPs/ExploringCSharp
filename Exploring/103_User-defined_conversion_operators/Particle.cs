namespace Exploring._01_User_defined_conversion_operators
{
    public class Particle
    {
        public const int C = 3;
        public int mass { get; set; }

        public int z { get; set; } //(protons) atomic number

        public int a { get; set; } //(protons+neutrons) mass number

        public Particle(int mass)
        {
            this.mass = mass;
        }
        public Particle()
        {
        }

        //public static implicit operator Wave(Particle particle)
        //{
        //    Wave wave = new Wave();
        //    wave.Energy = particle.mass * C * C;
        //    return wave;
        //}

        public static implicit operator Wave(Particle particle) => new Wave(particle.mass*C*C);
    }
}
