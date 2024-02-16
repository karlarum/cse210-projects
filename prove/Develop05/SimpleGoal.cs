using System;

namespace GoalTracker
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int point, bool isComplete)
        : base(name, description, point, isComplete)
        {
        }

        public SimpleGoal(StreamReader read) : base(read)
        {
            _name = read.ReadLine();
            _description = read.ReadLine();
            _isComplete = bool.Parse(read.ReadLine());
            _pointsPerCompletion = int.Parse(read.ReadLine());
            _points = int.Parse(read.ReadLine());
        }
    
        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string SaveGoal()
        {
            return $"SimpleGoal| {_name} | {_description} | {_points} | {_isComplete}";
        }
    }
}