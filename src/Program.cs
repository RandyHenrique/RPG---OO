using System;
using Jogo_RPG.src.entity;

namespace Jogo_RPG.src
{
    public class Program
    {
        static void Main(String[] args){
            
           // Hero arus = new Hero("Arus", 23, "Knight");
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            
        }
    }
}