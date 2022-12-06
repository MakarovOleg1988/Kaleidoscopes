using System;

namespace Kaleidoscopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sell sell = new Sell();
            Console.WriteLine(Math.Round(sell.TotalCost(), 2));
        }
    }

    public class Sell
    {
        private double _kaleidoscopes = Convert.ToInt32(Console.ReadLine());
        public double Kaleidoscopes
        {
            get { return _kaleidoscopes; }
            private set {; } 
        }

        private double _tax = 0.07;
        public double Tax
        {
            get { return _tax; }
            private set {; }
        }

        private double _discount = 0.1;
        public double Discount
        {
            get { return _discount; }
            private set {; }
        }

        private double _cost = 5.0;
        public double Cost
        {
            get { return _cost; }
            private set {; }
        }

        public double TotalCost()
            {
                double TotalCost = 0.0;

                if (_kaleidoscopes > 1) TotalCost = (_kaleidoscopes * _cost * (_tax + 1)) * (1 - _discount);
                else TotalCost = _kaleidoscopes * (_cost * _tax);

                return TotalCost;
            }
    }
}
