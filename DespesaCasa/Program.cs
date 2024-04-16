using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespesaCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp, despesa;
            double valor, total = 0;

            do
            {
                Console.WriteLine("Informe a despesa: ");
                despesa = Console.ReadLine();

                Console.WriteLine("Informe o valor: ");
                valor = double.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja inserir uma nova despesa?");

            }
        }
    }
}
