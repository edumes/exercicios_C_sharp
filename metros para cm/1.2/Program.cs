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

            Console.WriteLine("Digite a o numero que quer converter: ");
            n1 = int.Parse(Console.ReadLine());
            int conversao = n1 * 1000;
            Console.WriteLine("{0} centimetros", conversao);
            Console.ReadKey();
        }
    }
}
