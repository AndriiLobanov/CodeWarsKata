using System;
namespace TortoiseRace
{
  class Kata
    {
        public static int[] Race(int v1, int v2, int g) 
        {
            int[] res = new int[3];
            if(v1>=v2) return new int[]{-1,-1,-1};
            double diff = v2- v1;
            double time = g/diff;

            var timeSpan = TimeSpan.FromHours(time);
            res[0]= timeSpan.Hours;
            res[1]= timeSpan.Minutes;
            res[2]= timeSpan.Seconds;
            Console.WriteLine("Hours:{0} Minutes:{1} Seconds:{2}", res[0], res[1],res[2]);
            return res;
        }
       static void Main(string[] args)
       {
            int[] x = new int[]{1,1,2};
            Race(80, 91, 37);
            Console.Read();
       }
      }
}
    
