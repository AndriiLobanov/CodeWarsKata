using System;
using System.Linq;

namespace MissingLetter
{
    internal class Program
    {
        public static char FindMissingLetter(char[] array)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] temp = alphabet.ToCharArray();
            char res =  alphabet.First(x => x == Char.ToLower(array[0]));
            int index = alphabet.IndexOf(res);
            for (int i = 0; i < array.Length; i++)
            {
                if (Char.ToLower(array[i]) != temp[i + index])
                {
                        return char.ToUpper(temp[i + index]);
                }
            }
            return ' ';
        }
        static void Main(string[] args)
        {
            char c = FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' });
            Console.WriteLine(c);
        }
    }
}
