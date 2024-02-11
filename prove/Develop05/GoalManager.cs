using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals(string file)
    {
         string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"");
            }
        }

    }

    public void LoadGoals(string file)
    {
        string fileName = file;
        Goal goal;
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            
            string [] parts = line.Split(",");
            goal._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry); 
       
        }
    }
}