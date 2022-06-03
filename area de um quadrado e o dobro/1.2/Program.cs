using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.WriteLine("Digite o 1 perimetro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 perimetro: ");
            n2 = int.Parse(Console.ReadLine());
            
            int area = (n1 * n2) * 2;
            Console.WriteLine("o dobro da area é {0}", area);
            Console.ReadKey();

            
        }
    }
}
