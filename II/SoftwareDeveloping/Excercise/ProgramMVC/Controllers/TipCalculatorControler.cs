using ConsoleMVC.Model;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Controllers
{
    public class TipCalculatorControler
    {
        private Tip tip;
        private Display display;

        public TipCalculatorControler()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndAmount();
        }
    }
}
