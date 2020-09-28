using System;
using System.Collections.Generic;
using System.Text;

namespace ExamFinanceSoft
{
    abstract class Accounts : IBankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public Accounts(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }
        public abstract void Replenishment(int input);
        
    }
}
