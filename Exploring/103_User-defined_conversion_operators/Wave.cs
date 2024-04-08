namespace Exploring._01_User_defined_conversion_operators
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
            return new Particle(wave.Energy / (C * C));
        }
    }
}
