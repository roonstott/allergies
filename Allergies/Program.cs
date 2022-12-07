using System;
using System.Collections.Generic;
using Allergies.Models;


namespace Allergies {
    public class Program
    {
        public static void Main() {
            Console.WriteLine("Enter a number: ");
            int score = int.Parse(Console.ReadLine());

            Allergens allergies = new Allergens(score);
            Console.WriteLine("Your allergic to the following: {0} ", allergies.getAllergies() );
        }
    }
}