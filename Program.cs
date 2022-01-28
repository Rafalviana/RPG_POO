using System;
using POO_RPG.src.Entities;

namespace POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 25, "Knight");
            Wizard Jennica = new Wizard("Jennica", 50,"Wizard");

            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(Jennica);
            Console.WriteLine(Jennica.Attack());
            Console.WriteLine(Jennica.Attack(10)); // sobrecarga bonus
            Console.WriteLine(Jennica.Attack(3)); // sobrecarga bonus

            System.Console.ReadKey();

        }
    }
}
