using System;

namespace GoalTracker
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points, isComplete)
        {
        }

        public EternalGoal(StreamReader read) : base(read)
        {
            _name = read.ReadLine();
            _description = read.ReadLine();
            _isComplete = bool.Parse(read.ReadLine());
            _pointsPerCompletion = int.Parse(read.ReadLine());
            _points = int.Parse(read.ReadLine());
        }

        public override void RecordEvent()
        {
            _isComplete = false;
            Console.WriteLine($"EternalGoal: {_name}; This goal has no end.");
            _points += _pointsPerCompletion;            
        }

        public override string SaveGoal()
        {
            return $"EternalGoal| {_name} | {_description} | {_points} | {_isComplete}";
        }
    }
}