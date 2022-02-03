using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string phoneNumber = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 3)
                {
                    if (i == 0)
                        phoneNumber += "(";
                    
                    phoneNumber += numbers[i];
                    if (i == 2)
                        phoneNumber += ")" + " ";
                }

                else if(i>=3 && i < 6) { 
                    
                    phoneNumber += numbers[i];
                    if (i == 5) phoneNumber += "-";
                }
                else if(i>=6 && i<10)
                    phoneNumber += numbers[i];
            }
            return phoneNumber;
        }
        static void Main(string[] args)
        {
            int[] res = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            Console.WriteLine("{0}", CreatePhoneNumber(res));
            Console.Read();
        }
    }
}
