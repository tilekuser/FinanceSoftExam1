using System;

namespace ExamFinanceSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var deposit = new Deposit("Депозит", 1360);
            var card1 = new Card("Card1", 800);
            var card2 = new Card("Card2", 1990);
            var handler = new Handler();
            //handler.Processing( 450); 
        }
    }
}
