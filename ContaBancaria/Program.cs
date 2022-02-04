using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem-Vindo ao banco Bamerinus!");
            Console.WriteLine("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string titularConta = Console.ReadLine();
            double valorDepositoInicial = 0;
            Console.WriteLine("Deseja fazer um deposito inicial (s/n)? ");
            char fazerDepositoInicial = char.Parse(Console.ReadLine());

            if(fazerDepositoInicial == 's' || fazerDepositoInicial == 'S')
            {
                Console.WriteLine("Valor para depósito (decimal separado por ponto): ");
                 valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            } else
            {
                valorDepositoInicial = 0;
            }

            Conta usuario1 = new Conta(numeroConta, titularConta, valorDepositoInicial);

            Console.WriteLine(usuario1);

            Console.WriteLine("------------------------------");
            retornoMenu:
            Console.WriteLine("O que deseja fazer agora?\n1. Depósito\n2. Saque\n3. Ver Saldo\n9. Sair");

            int escolhaMenu = int.Parse(Console.ReadLine());

            switch(escolhaMenu)
            {
                case 1:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Você escolheu Depósito");
                    Console.WriteLine("Valor para depósito (decimal separado por ponto): ");
                    usuario1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    Console.WriteLine(usuario1);
                    Console.WriteLine("------------------------------");
                    goto retornoMenu;
                case 2:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Você escolheu Saque");
                    Console.WriteLine("Nosso saque tem um valor de R$5.00 por operação.");
                    Console.WriteLine("Valor para saque (decimal separado por ponto): ");
                    usuario1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    Console.WriteLine(usuario1);
                    Console.WriteLine("------------------------------");
                    goto retornoMenu;
                case 3:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Você escolheu Ver Saldo");
                    Console.WriteLine(usuario1);
                    Console.WriteLine("------------------------------");
                    goto retornoMenu;
                case 9:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Você escolheu Sair");
                    Console.WriteLine("Até a próxima... Tchau!");
                    Console.WriteLine("------------------------------");
                    break;
                default:
                    Console.WriteLine($"{escolhaMenu} é uma opção inválida! Tente novamente");
                    goto retornoMenu;
            }
        }
    }
}
