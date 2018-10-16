using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)//2
        {           
            double Ru = 0;
            string line = Console.ReadLine().ToUpper();
            Ru = Opred_Cyr(line);
            if (Ru >.5)
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

        private static double Opred_Cyr(string line)//1
        {
            char[] cyr = cyrillics();
            return line.Sum(c=>cyr.Contains(c)?1.0:0.0) / (double)line.Length;
        }
    }
}
