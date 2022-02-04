using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {

        public int NumeroConta { get; private set; }
        public string NomeTitularConta { get; set; }
        public double SaldoDaConta { get; private set; }
        
        public Conta(int numeroConta, string nomeTitularConta)
        {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;
            SaldoDaConta = 0;
        }

        public Conta(int numeroConta, string nomeTitularConta, double depositoInicial) : this(numeroConta, nomeTitularConta)
        {
            SaldoDaConta = depositoInicial;
        }


        public void Deposito(double valorDeposito)
        {
            SaldoDaConta += valorDeposito;
            ToString();
        }

        public void Saque(double valorSaque)
        {
            SaldoDaConta -= valorSaque + 5.0;
            ToString();
        }


        public override string ToString()
        {
            return "Dados da Conta:\n"
                + $"Conta: {NumeroConta}, Titular: {NomeTitularConta}, Saldo R${SaldoDaConta}";
        }

    }
}
