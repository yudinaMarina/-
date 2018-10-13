using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ru = 0, En = 0;
            string line = Console.ReadLine().ToUpper();
            Opred_yaz(ref Ru, ref En, line);
            if (Ru == line.Length)
            {
                Console.WriteLine("данный текст является предложением русского языка ");
            }
            else Console.WriteLine("данный текст не является предложением русского языка");
            Console.ReadKey();
        }

        private static void Opred_yaz(ref int Ru, ref int En, string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (((c >= 'А') && (c <= 'Я')) || ((c >= '0') && (c <= '9')) || c == ' ' || c == '.' || c == ',' || c == '!' || c == '?' || c == '-')
                    Ru++;
                else if ((c >= 'A') && (c <= 'Z')) En++;
            }
        }
    }
}
