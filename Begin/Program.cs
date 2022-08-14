// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Lekan";
            int characterAge;
            characterAge = 20;

            Console.WriteLine("Welcome to G-Land Computing!");
            Console.WriteLine("   ***********");
            Console.WriteLine("             ***********");
            Console.WriteLine("             ***********");
            Console.WriteLine("   ***********");
            Console.WriteLine(" Now, story for the guys!");
            Console.WriteLine("There was a boy called" + characterName);
            Console.WriteLine("Whose mother sells paints and building materials");
            characterName = "Tom";
            Console.WriteLine("All of a sudden, " +characterName+ " died and his friend stops going to his mother");
            Console.WriteLine("Untill now, that friend of his has yet to visit his mother");
            Console.WriteLine("And he was just at " + characterAge + " when he gave up the ghost");
            Console.WriteLine("Although, he did not pray to die at " + characterAge + "but this eventually happened to him at 20");

            Console.ReadLine();
        }
    }
}

