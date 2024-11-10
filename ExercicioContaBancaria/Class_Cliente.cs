using System;
using System.Dynamic;

namespace ExercicioContaBancaria {
    class Cliente {
        public double NumeroConta {get; private set;}
        public string TitularConta {get; private set;}
    
        public double SaldoConta {get; private set;}

// ------------------------------------------------------------
        public void DefinirNumeroConta (double numeroConta) {
            NumeroConta = numeroConta;
        }

        public void DefinirTitularConta (string titularConta) {
            TitularConta = titularConta;
        }

        public void DefinirSaldoConta (double saldoconta) {
            saldoconta = 0;
            SaldoConta = saldoconta;
        }

// ------------------------------------------------------------
        public double DepoistoInicial (string resposta, double novoSaldo) {
            if (resposta.ToUpper() == "SIM") {
                System.Console.WriteLine("Digite o valor de depósito: ");
                novoSaldo = double.Parse(Console.ReadLine());
                SaldoConta = novoSaldo;
                return SaldoConta;
            } else {
                System.Console.WriteLine("FIM!");
                return SaldoConta;
            }
        }
        
        public double SaqueFinal(string respostaSaque, double saldoFinal) {
    if (respostaSaque.ToUpper() == "SIM") {
        Console.WriteLine("Digite o valor de saque: ");
        saldoFinal = double.Parse(Console.ReadLine());

        if (saldoFinal <= SaldoConta) { // Verifica se o saldo é suficiente
            SaldoConta -= saldoFinal;
            SaldoConta -= 5;
        } else {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    } else {
        Console.WriteLine("FIM!");
    }

    return SaldoConta;
}
  }

}