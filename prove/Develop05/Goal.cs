using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _description = description;
        _shortName = name;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
 

    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            string details = $"{_shortName} {_description}";
            return details;
        }
        else 
        {
            string details = $"{_shortName} {_description}";
            return details;
        }
    }

    public abstract string GetStringRepresentation();
}