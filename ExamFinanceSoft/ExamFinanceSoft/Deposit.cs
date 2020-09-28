using System;
using System.Collections.Generic;
using System.Text;

namespace ExamFinanceSoft
{
    class Deposit : Accounts
    {
        string Name;
        int Balance;

        public Deposit(string name, int balance) : base (name, balance)
        {
            Name = name;
            Balance = balance;
        }

        public override void Replenishment(int input)
        {
            
            if (input > 400)
                throw new Exception("Запрещено пополнять сумму больше 400");
            else
                Balance += input;           
        }
    }
}
