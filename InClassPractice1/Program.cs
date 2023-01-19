using System;

namespace InClassPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to the dice rolling simulator!");
            //Declaring and instantiating array
            int[] blah = new int[13];

            //Getting number of rolls from user
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            //Loop to roll the correct amount of times and store count to array
            for (int i = 0; i < numRolls; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 7);
                int num2 = rnd.Next(1, 7);
                int sum = num + num2;
                blah[sum]++;
            }
            // Dice rolling results
            Console.WriteLine("Dice rolling simulation results");
            Console.WriteLine("Each * represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls = " + numRolls);
            //Converting results to asterices
            for (int i = 2; i < 13; i++)
            {
                float count = blah[i];
                float percent = MathF.Round(((count / numRolls) * 100), 0);
                string asteriks = "";

                for (float j = 0; j < percent + 1; j++)
                {
                        asteriks = "*" + asteriks;                  
                }
                Console.WriteLine(i + ": " + asteriks);
            }
        }
    }
}



