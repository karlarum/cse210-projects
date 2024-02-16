using System;
using System.Collections.Generic;

namespace GoalTracker
{
    public class CheckListGoal : Goal
    {
        private int _amountCompleted = 0;
        private int _target = 0;
        private int _bonus = 0;

        public CheckListGoal(string name, string description, int points, bool isComplete, int target, int bonus)
            : base(name, description, points, isComplete)
        {
            _target = target;
            _bonus = bonus;
        }

        public override void Display()
        {
            int updatedCompleted = _amountCompleted;
            // if (!_isComplete)
            // {
            //     updatedCompleted++;
            // }
            Console.WriteLine($"{CompletedCheckbox()} Goal: {_name} ({_description}) -- Currently Completed: {updatedCompleted}/{_target}");
        }

        public CheckListGoal(StreamReader read) 
            : base(read)
        {
            _target = int.Parse(read.ReadLine());
            _amountCompleted = int.Parse(read.ReadLine());
            _bonus = int.Parse(read.ReadLine());
        }

        public override void RecordEvent()
        {
            if (!_isComplete)
            {
                _amountCompleted++;
                _points += _pointsPerCompletion;
                if (_amountCompleted == _target)
                {
                    _isComplete = true;
                    _points += _bonus;
                }
            }
        }

        public override string SaveGoal()
        {
            return $"CheckListGoal| {_name} | {_description} | {_points} | {_isComplete} | {_target} | {_bonus}";
        }
    }
}