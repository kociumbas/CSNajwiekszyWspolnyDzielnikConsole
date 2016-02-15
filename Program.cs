using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("\n\tPROGRAM ZNAJDUJE NAJWIEKSZY WSPOLNY DZIELNIK");
            Console.WriteLine("\n\n\n\tPodaj pierwsza liczbe");
            Console.Write("\n\tn= ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\tPodaj druga liczbe");
            Console.Write("\n\tm= ");
            m = Convert.ToInt32(Console.ReadLine());
            while (n != m)
                if (n > m) n = n - m;
                else m = m - n;
            Console.WriteLine("\n\tnajwiekszy wspolny dzielnik= " + n);
            Console.WriteLine("\n\n\tNacisnij ENTER");
            Console.ReadLine();
        }
    }
}
