using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Views
{
    public class Display
    {
        public decimal Amount { get; set; }
        public decimal Percent { get; set; }
        public decimal TipAmount { get; set; }
        public decimal Total { get; set; }

        public Display()
        {
            Amount = 0;
            Percent = 0;
            TipAmount = 0;
            Total = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Enter amount: ");
            Amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter percent: ");
            Percent = decimal.Parse(Console.ReadLine());
        }
        public void ShowTipAndAmount()
        {
            Console.WriteLine($"Your tip amount is: {TipAmount:C}");
            Console.WriteLine($"The total amount will be: {Total:C}");

        }
    }
}
