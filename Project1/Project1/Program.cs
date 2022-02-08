using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FruitSalad = "Fruit Salad";
            const string PastaSalad = "Pasta Salad";
            const string Smoothie = "Smoothie";
            const string FruitJuice = "Fruit Juice";
            const string CupCake = "Cup Cake";
            const string ShortCake = "Short Cake";

            const double FruitSaladPrice = 9.95;
            const double PastaSaladPrice = 12.00;
            const double SmoothiePrice = 4.95;
            const double FruitJuicePrice = 3.95;
            const double CupCakePrice = 3.00;
            const double ShortCakePrice = 6.00;
            const double TaxRate = .095;

            int QtyFruitSalad = 0;
            int QtyPastaSalad = 0;
            int QtySmoothie = 0;
            int QtyFruitJuice = 0;
            int QtyCupCake = 0;
            int QtyShortCake = 0;

            Console.WriteLine("*********Menu**********");
            Console.WriteLine(FruitSalad + " : $" + FruitJuicePrice);
            Console.WriteLine(PastaSalad + " : $" + PastaSaladPrice);
            Console.WriteLine(Smoothie + " : $" + SmoothiePrice);
            Console.WriteLine(FruitJuice + " : $" + FruitJuicePrice);
            Console.WriteLine(CupCake + " : $" + CupCakePrice);
            Console.WriteLine(ShortCake + " : $" + ShortCakePrice);
            Console.WriteLine("********Enter Your Order********");

            Console.WriteLine("How many " + FruitSalad + "? --- $" + FruitSaladPrice);
            QtyFruitSalad = int.Parse(Console.ReadLine());

            Console.WriteLine("How many " + PastaSalad + "? --- $" + PastaSaladPrice);
            QtyPastaSalad = int.Parse(Console.ReadLine());

            Console.WriteLine("How many " + Smoothie + "? --- $" + SmoothiePrice);
            QtySmoothie = int.Parse(Console.ReadLine());

            Console.WriteLine("How many " + FruitJuice + "? --- $" + FruitJuicePrice);
            QtyFruitJuice = int.Parse(Console.ReadLine());

            Console.WriteLine("How many " + CupCake + "? --- $" + CupCakePrice);
            QtyCupCake = int.Parse(Console.ReadLine());

            Console.WriteLine("How many " + ShortCake + "? --- $" + ShortCakePrice);
            QtyShortCake = int.Parse(Console.ReadLine());

            Console.WriteLine("**************************");

            double FruitSaladTotal = (QtyFruitSalad * FruitSaladPrice);
            double PastaSaladTotal = (QtyPastaSalad * PastaSaladPrice);
            double SmoothieTotal = (QtySmoothie * SmoothiePrice);
            double FruitJuiceTotal = (QtyFruitJuice * FruitJuicePrice);
            double CupCakeTotal = (QtyCupCake * CupCakePrice);
            double ShortCakeTotal = (QtyShortCake * ShortCakePrice);

            double FruitSaladTotalTaxed = (FruitSaladTotal * TaxRate);
            double PastaSaladTotalTaxed = (PastaSaladTotal * TaxRate);
            double SmoothieTotalTaxed = (SmoothieTotal * TaxRate);
            double FruitJuiceTotalTaxed = (FruitJuiceTotal * TaxRate);
            double CupCakeTotalTaxed = (CupCakeTotal * TaxRate);
            double ShortCakeTotalTaxed = (ShortCakeTotal * TaxRate);

            double SubTotal = (FruitSaladTotal + PastaSaladTotal + SmoothieTotal + FruitJuiceTotal + CupCakeTotal + ShortCakeTotal);
            double TotalTax = (FruitSaladTotalTaxed + PastaSaladTotalTaxed + SmoothieTotalTaxed + FruitJuiceTotalTaxed + CupCakeTotalTaxed + ShortCakeTotalTaxed);
            double TotalCost = (SubTotal + TotalTax);

            Console.WriteLine("SubTotal: {0}", SubTotal.ToString("C"));
            Console.WriteLine("Tax: {0}", TotalTax.ToString("C"));
            Console.WriteLine("Total: {0}", TotalCost.ToString("C"));



            Console.ReadKey();
        }
    }
}
