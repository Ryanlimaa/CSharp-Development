using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Herança.Entities
{
    internal sealed class SavingsAccount : Account //"sealed" evita que a classe seja herdada
    {
        public double InterestRate { get; set; } //Taxa de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() //Atualizar saldo
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)//reaproveitando o metodo da classe base com override e base
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
