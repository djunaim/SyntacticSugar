using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var preds = new List<string>()
            {
                "Rinne",
                "Jose",
                "Saros"
            };

            var prey = new List<string>()
            {
                "Kane",
                "Toews",
                "Dach"
            };

            var dooDoo = new Bug("Poo", "Dangerous", preds, prey);
            Console.WriteLine($"This is the name of the bug: {dooDoo.Name}");
            Console.WriteLine($"THis is the species of the bug: {dooDoo.Species}");
            Console.WriteLine($"This is the list of prey: {dooDoo.PreyList()}");
            Console.WriteLine($"This is the list of predators: {dooDoo.PredatorList()}");

            Console.ReadLine();
        }
    }
}
