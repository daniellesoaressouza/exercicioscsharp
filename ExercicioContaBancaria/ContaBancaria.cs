using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioContaBancaria
{
    internal class ContaBancaria
    {
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }
        public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
           SaldoConta += quantia;
        }

        public void Saque(double quantia)
        {
            SaldoConta-= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta " 
                + NumeroConta
                + ", Titular: " 
                + Nome
                + ", Saldo:$ " 
                + SaldoConta.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}
