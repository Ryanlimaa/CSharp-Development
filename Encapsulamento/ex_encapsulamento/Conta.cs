using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_poo_encap
{
    internal class Conta
    {
        double taxa = 5.00;

        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public Conta(int numero, string titular, double valorDeposiro) : this(titular, numero)
        {
            Deposito(valorDeposiro);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + taxa;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
