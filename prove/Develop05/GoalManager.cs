using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Runtime;

namespace GoalTracker
{
    public class GoalManager
    {
        public List<Goal> _goals = new List<Goal>();
        public int _score = 0;
        public const string fileName = "";

        public List<Goal> Goals {get {return _goals; }}
        public int Score {get {return _score; }}

        public int GetGoalCount()
        {
            return _goals.Count;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points.");
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("The goal details are: ");
            foreach (var goal in _goals)
            {
                goal.Display();
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Which type of goal would you like to create? ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                string name, description;
                int points, target, bonus;
                bool isComplete = false;

                switch (choice)
                {
                    case 1:
                        //simple goal
                        Console.WriteLine("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal? ");
                        description = Console.ReadLine();
                        Console.WriteLine("How many points do you want associated with this goal? ");
                        int.TryParse(Console.ReadLine(), out points);
                        _goals.Add(new SimpleGoal(name, description, points, isComplete)); 
                        break;
                    case 2:
                        //eternal goal
                        Console.WriteLine("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal? ");
                        description = Console.ReadLine();
                        Console.WriteLine("How many points do you want associated with this goal? ");
                        int.TryParse(Console.ReadLine(), out points);
                        _goals.Add(new EternalGoal(name, description, points, isComplete)); 
                        break;
                    case 3:
                        //checklist goal
                        Console.WriteLine("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal? ");
                        description = Console.ReadLine();
                        Console.WriteLine("How many points do you want associated with this goal? ");
                        int.TryParse(Console.ReadLine(), out points);
                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                        int.TryParse(Console.ReadLine(), out target);
                        Console.WriteLine("What is the bonus for accomplishng it that many times? ");
                        int.TryParse(Console.ReadLine(), out bonus);
                        _goals.Add(new CheckListGoal(name, description, points, isComplete, target, bonus));
                        break;
                    default:
                        Console.WriteLine("Please enter a number 1-3");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number 1-3.");
            }
        }

        public void RecordEvent()
        {
            int choice = 0;
            while (choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine("Goals left to complete: ");
                ListGoalsToComplete();

                Console.WriteLine("which goal did you accomplish? ");
                int.TryParse(Console.ReadLine(), out choice);
            }

            Goal goalToComplete = _goals[choice - 1];
            goalToComplete.RecordEvent();
            _score += goalToComplete.GetPoints();
            Console.WriteLine($"You now have {_score} points!");
        }

        private void ListGoalsToComplete()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].Name}");
            }
        }

        public void SaveGoals()
        {
            Console.WriteLine("Enter filename to save to: ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.SaveGoal());
                }
            }
        } 

        public void LoadGoals()
        {
            Console.WriteLine("Enter the filename to load goals from: ");
            string filename = Console.ReadLine();
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if(parts[0] == "SimpleGoal")
                {
                    SimpleGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    _goals.Add(goal);
                }
                else if(parts[0] == "EternalGoal")
                {
                    EternalGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    _goals.Add(goal);

                }
                else if(parts[0] == "CheckListGoal")
                {
                    CheckListGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(goal);
                }
                else
                {
                    Console.WriteLine("---test---");
                }
            }
        }
    }
}