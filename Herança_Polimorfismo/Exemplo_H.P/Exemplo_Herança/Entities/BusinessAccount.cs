using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Herança.Entities
{
    internal class BusinessAccount : Account //Subclasse de Account
    {
        public double LoanLimit { get; set; } //Limite especial

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) //Emprestimo (quantia)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
