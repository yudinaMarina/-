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
            int Ru = 0;
            string line = Console.ReadLine().ToUpper();
            Ru = Opred_Cyr(Ru, line);
            if (Ru > line.Length/2)
            {
                Console.WriteLine("данный текст является предложением русского языка");
            }
            else Console.WriteLine("данный текст не является предложением русского языка");
            Console.ReadKey();
        }

        private static int Opred_Cyr(int Ru, string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (((c >= 'А') && (c <= 'Я')) ||c=='Ё')
                    Ru++;
            }
            return Ru;
        }
    }
}
