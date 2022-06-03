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
            int n3;
            int n4;

            Console.WriteLine("Digite a N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a N2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a N3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a N4: ");
            n4 = int.Parse(Console.ReadLine());
            int media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("a media do aluno foi de {0}", media);
            Console.ReadKey();
        }
    }
}
