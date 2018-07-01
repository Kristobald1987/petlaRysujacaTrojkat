using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlaRysujacaTrojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("Podaj n>1: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++) Console.Write(" "); //jaka wartość przyjmuje "i" przy pierwszej pętli w tym wierszu
                for (j = 1; j <= 2 * i - 1; j++) Console.Write("*");
                Console.WriteLine("");



            }
            Console.ReadKey();
        }
    }
}
