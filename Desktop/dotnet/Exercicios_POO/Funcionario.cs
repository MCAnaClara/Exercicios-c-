using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }

        public decimal Salario { get; private set; }

        public decimal DefinirSalario()
        {
            Console.WriteLine("Insira o salário: ");
            decimal salario = decimal.Parse(Console.ReadLine()!);

            return Salario = salario;
        }

        public decimal AumentarSalario()
        {
            Console.WriteLine("Insira a % desejada: ");

            decimal porcentagem = decimal.Parse(Console.ReadLine()!);

            porcentagem = porcentagem / 100;

            return Salario + (Salario * porcentagem);
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O salário atual é de {Salario}");
        }

    }
}