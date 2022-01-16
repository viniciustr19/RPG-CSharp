using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
        }
    }
}