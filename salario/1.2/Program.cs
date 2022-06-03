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
            int hora;
            int horaMes;

            Console.WriteLine("Digite o quanto vc ganha por hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas no mes: ");
            horaMes = int.Parse(Console.ReadLine());

            int salario = hora * horaMes;
            Console.WriteLine("seu salario é de {0} reais", salario);
            Console.ReadKey();

            
        }
    }
}
