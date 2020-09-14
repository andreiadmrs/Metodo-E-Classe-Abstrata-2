using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratos2.Entities;

namespace MetodosAbstratos2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.WriteLine("Números de pessoas que irão pagar imposto: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Pessoa física ou juridica (f/j): ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(gastosSaude, nome, rendaAnual));
                }
                else
                {
                    Console.Write("Número de funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(funcionarios, nome, rendaAnual));
                }
               
            }
            Console.WriteLine("");
            Console.WriteLine("Impostos pagos: ");
            foreach (Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.Nome + (": R$") + pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
