using System;
using System.Collections.Generic;
using System.Text;

namespace ExamFinanceSoft
{
    interface IBankAccount
    {
        string Name { get;}
        int Balance { get; }
        void Replenishment(int input);

    }
}
