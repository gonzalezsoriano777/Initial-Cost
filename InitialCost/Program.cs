using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialCost
{
    class Cost
    {
        public double mealCost = 12.00;
        public int tipPercent = 20;
        public int taxPercent = 8;

        public void TotalCost()
        {
            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;

            Console.WriteLine("{0}", Math.Round(totalCost));
        }

        static void Main(string[] args)
        {
            Cost myCost = new Cost();

            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            myCost.TotalCost();
            


        }
    }
}
