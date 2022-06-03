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
            const double PI = 3.14;
            double area = 0;
            double raio = 0;

            Console.WriteLine("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());

            area = PI * (raio * raio);

            Console.WriteLine("a area do circulo é de: " + area);

            Console.ReadKey();

            
        }
    }
}
