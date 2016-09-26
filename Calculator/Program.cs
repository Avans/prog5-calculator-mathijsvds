using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeCalculatorNamespace;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeCalculator calc = new AgeCalculator();
            Console.WriteLine("Geef een datum om te berekenen (format: dd-mm-yyyy):");
            Console.WriteLine("Typ 'Q' om te stoppen\n");
            String input =  Console.ReadLine();

            while (input.ToLower() != "q")
            {
                DateTime result;
                if (calc.ParseInput(input, out result))
                {
                    Console.WriteLine("Je leeftijd is {0}", calc.CalculateAge(result));
                    Console.WriteLine("\nGeef een datum om te berekenen (format: dd-mm-yyyy):");
                }
                else
                {
                    Console.WriteLine("Ongeldige input! probeer het nogmaals (dd-mm-yyyy):");
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
