using System;

namespace ExercicioContaBancaria {
    internal class ExercicioContaBancaria {
        static void Main (string[]args) {

            Cliente cliente = new Cliente();

            System.Console.Write("Digite o número da conta: ");
            cliente.DefinirNumeroConta (double.Parse(Console.ReadLine()));

            System.Console.Write("Digite o nome do titular da conta: ");
            cliente.DefinirTitularConta ((Console.ReadLine()));

            System.Console.WriteLine("Dados da conta");
            System.Console.WriteLine($"Número da conta: {cliente.NumeroConta}, Titular da conta: {cliente.TitularConta}, Saldo da conta: {cliente.SaldoConta}");

            System.Console.WriteLine("Deseja fazer um depósito inicial? (SIM/NÃO)");
            string resposta = Console.ReadLine().ToUpper();

            cliente.DepoistoInicial(resposta, cliente.SaldoConta);

            Console.WriteLine($"Saldo atualizado da conta: {cliente.SaldoConta}");

            System.Console.WriteLine("Deseja realizar um Saque?");
            string respostaSaque = Console.ReadLine().ToUpper();

            cliente.SaqueFinal(respostaSaque, cliente.SaldoConta);

            Console.WriteLine($"Saldo atualizado da conta: {cliente.SaldoConta}");
        }
    }
}