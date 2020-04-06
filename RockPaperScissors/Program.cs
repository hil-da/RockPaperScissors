using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game Rock-PAper-Scissors, please choose your weapon:");

            Random rnd = new Random();
            string[] botWeapons = { "Rock", "Paper", "Scissors" };
            bool reMatch = true;
            string choice = "";
            int score = 0;
            int botScore = 0;

            while (reMatch)
            {
                Console.WriteLine("Choose ---------------- Current score: {0} - {1}", score, botScore);
                Console.WriteLine("\n\ta - Rock");
                Console.WriteLine("\tb - Paper");
                Console.WriteLine("\tc - Scissors");
                string userWeapon = Console.ReadLine();
                string botChoice = botWeapons[rnd.Next(botWeapons.Length)];

                Console.Clear();
                switch (userWeapon)
                {

                    case "a":
                        Console.WriteLine("You chose Rock, and the bot chose {0}", botChoice);
                        choice = "Rock";

                        if (botChoice == choice)
                        {
                            Console.WriteLine("\nDraw");
                        }
                        else if (botChoice == "Scissors")
                        {
                            score++;
                            Console.WriteLine("\nYou got the point");

                        }
                        else
                        {
                            botScore++;
                            Console.WriteLine("\nThe bot got the point");
                        }

                        break;

                    case "b":
                        Console.WriteLine("\nPaper! What an excellent choice! Now my friend, let's see what the bot chose...");
                        choice = "Paper";
                        if (botChoice == choice)
                        {
                            Console.WriteLine("\nDraw");
                        }
                        else if (botChoice == "Rock")
                        {
                            score++;
                            Console.WriteLine("\nYou got the point");

                        }
                        else
                        {
                            botScore++;
                            Console.WriteLine("\nThe bot got the point");
                        }
                        break;

                    case "c":
                        Console.WriteLine("\nScissors! What an excellent choice! Now my friend, let's see what the bot chose...");
                        choice = "Scissors";
                        if (botChoice == choice)
                        {
                            Console.WriteLine("\nDraw");
                        }
                        else if (botChoice == "Paper")
                        {
                            score++;
                            Console.WriteLine("\nYou got the point");

                        }
                        else
                        {
                            botScore++;
                            Console.WriteLine("\nThe bot got the point");
                        }
                        break;
                }

                if (score == 3 || botScore == 3)
                    reMatch = false;
            }

            if (score == 3)
                Console.WriteLine("----------------\nYou won!");
            else
                Console.WriteLine("----------------\nYou lost");
        }
    }
}
//Hilda Ava Nateghi Baneh