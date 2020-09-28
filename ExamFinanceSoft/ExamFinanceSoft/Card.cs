using System;
using System.Collections.Generic;
using System.Text;

namespace ExamFinanceSoft
{
    class Card : Accounts
    {
        string Name;
        int Balance;
        public Card(string name, int balance) : base(name, balance)
        {
            Name = name;
            Balance = balance;
        }

        public override void Replenishment(int input)
        {

            if (input > 300)
                Console.WriteLine($"Было пополнено больше чем положено, наименование счета: {Name}");
            Balance += input;
        }


    }
}
