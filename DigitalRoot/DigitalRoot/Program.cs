using System;

namespace DigitalRoot
{
    internal class Program
    {
        public static int DigitalRoot(long n)
        {
            int s = 0;
            while (n > 0)
            {
                s += (int)n % 10;
                n = (n / 10);
            }
            if (s >= 10)
                return DigitalRoot(s);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}",DigitalRoot(456));
        }
    }
}
