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
            string rus = "йцукенгшщзхъфывапролджэячсмитьбю1234567890";
            char[] rusmas = rus.ToCharArray();
            Console.Write("Введите строку: ");
            char[] str = Console.ReadLine().ToCharArray();
            int counter = 0;
            int k = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == ' ')
                {
                    str[j] = str[j + 1];
                    k++;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < rusmas.Length; j++)
                {
                    if (str[i] == rusmas[j])
                    {
                        counter++;
                    }
                }
            }
            if (counter==rusmas.Length-k)
            {
                Console.WriteLine("Предложение на русском языке");
            }
            else { Console.WriteLine("Не все на русском"); }
            //double x = (double)counter / str.Length;
            //Console.Write("Частота встречаемости: {0}", x);
            Console.ReadLine();
        }
    }
}
