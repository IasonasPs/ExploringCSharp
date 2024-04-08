namespace Exploring._101_Miscellaneous
{
    internal class Gc
    {
        private readonly List<int> _numbers;
        public Gc()
        {
            _numbers = new List<int>();
        }
        public void AllocateMemory()
        {
            for(int i = 0; i < 1000000; i++)
            {
                _numbers.Add(i);
            }
        }
    }
}
