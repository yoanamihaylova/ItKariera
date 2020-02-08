using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Model
{
    public class Tip
    {
        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private decimal percent;

        public decimal Percent
        {
            get { return percent; }
            set
            {
                if (value > 1) this.percent = value / 100.0m;
                else percent = value;
            }
        }
        public Tip() : this(0, 0) { }
        public Tip(decimal amount, decimal percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }
        public decimal CalculateTip()
        {
            return Amount * Percent;
        }
        public decimal CalculateTotal()
        {
            return Amount + CalculateTip();
        }
    }
}
