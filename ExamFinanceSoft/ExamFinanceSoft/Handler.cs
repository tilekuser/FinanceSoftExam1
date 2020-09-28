using System;
using System.Collections.Generic;
using System.Text;

namespace ExamFinanceSoft
{
    class Handler
    {        
        public void DepositProcessing(IBankAccount account, int SumInput)
        {
            var All = account.Balance + SumInput;
            Console.WriteLine(All);

        }
    }
}
