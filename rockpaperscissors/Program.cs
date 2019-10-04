using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerHealth = 100;
            bool isGamerOver = false;
            string commandAttack = "Attack";
            int playerAttackDamage = 25;  
            string commandDefend = "Defend";
            int defend = 5;
            string commandMagic = "Magic";
            int magicDamage = 50;
            bool playerRan = false;
            string bloodType = "O-";

            string monster = "Creepy Creature";
            string attackMonster = "Punch";
            int monsterAttackDamage = 15;
            int monsterHealth = 75;

            // Kleur van achtergrond en tekst
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            /*
            
                        Vanaf hier begint de Game

             */
            
            // Maakt de console schoon.
            Console.Clear();

            // Informatie begin
            Console.WriteLine("####################################");
            Console.WriteLine("####################################");
            Console.WriteLine("##                                ##");
            Console.WriteLine("##      Rock Paper Scissors©      ##");
            Console.WriteLine("##       Patrick Meerleveld       ##");
            Console.WriteLine("##      Mediacollege Project      ##");
            Console.WriteLine("##  Meerleveld, Copyright © 2019  ##");
            Console.WriteLine("##                                ##");
            Console.WriteLine("####################################");
            Console.WriteLine("####################################");
            
            Console.CursorTop += 2;
            Console.CursorLeft = 10;

            Console.WriteLine("Player Health: " + playerHealth + "HP");
            Console.WriteLine("Monster Health: " + monsterHealth + "HP");
            
            Console.Write("De volgende commando's kunnen gebruikt worden:\n"); // \n betkent "new line"
            Console.Write("\n\n\n\n");
            Console.Write("Kies uit: " + " " + commandAttack + " " + commandDefend + " " + commandMagic);

            
            // Vraag om gebruiker input:
            //Console.ReadLine();
            
        }
    }
}
