using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)//2
        {
            string line = Console.ReadLine().ToUpper();
            bool Ru = Opred_Cyr(line);
            if (Ru==true)
            {
                Console.WriteLine("данный текст является предложением русского языка");
            }
            else Console.WriteLine("данный текст не является предложением русского языка");
            Console.ReadKey();
        }
     
        private static char[] cyrillics()//1
        {
            string cyr = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            return (cyr + cyr.ToUpper()).ToCharArray();
        }

        public static bool Opred_Cyr(string line)//1
        {
            char[] cyr = cyrillics();
            if ((line.Sum(c => cyr.Contains(c) ? 1.0 : 0.0) / (double)line.Length) > .5)
            {
                return true;
            }
            else return false;

        }
    }
}

