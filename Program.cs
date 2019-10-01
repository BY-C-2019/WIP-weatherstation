using System;
using System.Collections.Generic;
namespace weatherstation
{
    class Program
    {
        static void Main(string[] args)
        {
           List<double> stationer = new List<double>();
            Console.Clear();
            Console.WriteLine("Välkommen till Väderstationen!");
            Console.WriteLine("Hur många stationer ingår i mätningen?");
            int antalMätningar = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= antalMätningar; i++)
            {   Console.WriteLine("Skriv in mätning: "+i);
                double grader= Convert.ToDouble(Console.ReadLine());
                stationer.Add(grader);
            }
            double sum = 0;
            foreach (var item in stationer)
            {

///
              sum+=item;
            }
            double summa= sum/antalMätningar;

            Console.WriteLine("Medeltemperaturen på "+antalMätningar+" antal mätningar är: "+ summa.ToString("0.00")+" grader.");
        }
    }
}
