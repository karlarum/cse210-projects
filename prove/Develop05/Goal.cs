using System;
using System.Collections.Generic;

namespace GoalTracker
{
    public abstract class Goal
    {
       protected string _name = "";
       protected string _description = "";
       protected bool _isComplete = false;
       protected int _pointsPerCompletion = 0;
       protected int _points = 0;

       public Goal(string name, string description, int points, bool isComplete)
       {
           _name = name;
           _description = description;
           _points = points;
           _isComplete = isComplete;
       }

       public Goal(StreamReader read)
       {
            _name = read.ReadLine();
            _description = read.ReadLine();
            _isComplete = bool.Parse(read.ReadLine());
            _pointsPerCompletion = int.Parse(read.ReadLine());
            _points = int.Parse(read.ReadLine());
       }

       public virtual int GetPoints()
       {
           return _points;
       }

       public virtual void Display()
       {
            Console.WriteLine($"{CompletedCheckbox()} Goal: {_name} ({_description})");
       }

       public virtual bool IsComplete()
       {
           return _isComplete;
       }

       protected virtual string CompletedCheckbox()
       {
            return _isComplete ? "[X]" : "[ ]";
       }
       public virtual void RecordEvent()
       {
            Console.WriteLine($"Event recorded for goal: {_name}");
            _isComplete = true;
       }

       public virtual string GetDetailsString()
       {
            return $"{CompletedCheckbox()} {SaveGoal()}";
       }

       public virtual string SaveGoal()
       {
            return $"Goal| {_name} | {_description} | {_points} | {_isComplete}";
       }
       
       public string Name => _name;
       public string Description => _description;
    }
}