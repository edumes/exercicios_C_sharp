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
            float C;
            
            Console.WriteLine("Digite a temperatura em farenheit: ");
            F = float.Parse(Console.ReadLine());
            float conversao = 5 * ((F - 32) / 9);
            Console.WriteLine("{0} graus celsius", conversao);
            Console.ReadKey();
        }
    }
}
