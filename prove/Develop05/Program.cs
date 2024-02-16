using System;

namespace GoalTracker
{
    public class Program
    {
        private static List<string> motivationalMessage = new List<string>
        {
            "'We cannot become what we want by remaining what we are' -Max Depree",
            "'You already know what the right thing to do is. You just gotta do it.' -Jocko Willink",
            "'Doubting yourself is normal. Letting it stop you is a choice' -Mel Robbins",
            "'What good are wings without the courage to fly.' -Atticus"
        };

        private static GoalManager goalManager = new GoalManager();

        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                DisplayQuote();

                goalManager.DisplayPlayerInfo();

                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");

                int choice = SafeParse();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        goalManager.CreateGoal();
                        break;
                    case 2:
                        goalManager.ListGoalDetails();
                        break;
                    case 3:
                        goalManager.SaveGoals();
                        break;
                    case 4:
                        goalManager.LoadGoals();
                        break;
                    case 5:
                        goalManager.RecordEvent();
                        break;
                    case 6:
                        exit = true;
                        break;
                }
            }    
        }

        public static void DisplayQuote()
        {
            Random rand = new Random();
            int index = rand.Next(motivationalMessage.Count);
            Console.WriteLine("Today's Motivational Message: " + motivationalMessage[index]);
        }

        public static int SafeParse()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a number 1-6.");
            }
            return choice;
        }
    }
}