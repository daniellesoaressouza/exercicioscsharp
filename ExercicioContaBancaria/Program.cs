using ExercicioContaBancaria;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[]args)
        {
            double deposito;
            ContaBancaria X;


            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o numero da sua nova conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Deseja fazer um deposito inicial (digite s para sim e n para não): ");
            char opcaoDeposito= char.Parse(Console.ReadLine());

            
            if (opcaoDeposito == 's' || opcaoDeposito == 'S')
            {
                Console.WriteLine("Entre com o valor de deposito inicial");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                X = new ContaBancaria(nome, numeroConta, deposito);
                X.Deposito(deposito);
                
            }
            else 
            {
                X = new ContaBancaria(nome, numeroConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(X);
            Console.WriteLine(" ");

            Console.Write("Entre com um valor para deposito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.Deposito(deposito);
            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(X);
            Console.WriteLine(" ");

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.Saque(saque);
            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(X);
        }
    }
}
