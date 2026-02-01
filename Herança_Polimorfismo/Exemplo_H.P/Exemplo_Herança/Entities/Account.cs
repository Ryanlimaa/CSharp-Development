using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Herança.Entities
{
    internal class Account
    {
        public int Number { get; private set; } //Numero da conta
        public string Holder { get; private set; } //Titular
        public double Balance { get; protected set; } //Saldo (pode ser alterado somente por outra calsse)

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) //Sacar (quantia), usando a palavra "virtual" para liberar a operação em outras classes/ override
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) //deposito (quantia)
        {
            Balance += amount;
        }
    }
}
