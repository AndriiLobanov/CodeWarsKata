using System;
namespace Odd_number
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
         int result = 0;
        int count = 0;
        int countMax= 0;
        for(int i =0; i < seq.Count(); ++i)
        {
            for(int j = 0; j < seq.Count(); ++j)
            {
                if(seq[i] == seq[j])
                {
                    count++;
                }
            }

            if(result == seq[i])
            {
                count = 0;
            }
            if(count % 2 != 0 ){
                if(count>countMax)
                {
                    countMax=count;
                    count=0;
                    result=seq[i];
                }
            }
        }
      return result;
      }
       static void Main(string[] args)
       {
            int[] x = new int[]{1,1,2};
            Console.WriteLine("{0}", find_it(x));
            Console.Read();
       }
    }
    
}