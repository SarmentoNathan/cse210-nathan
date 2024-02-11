using System;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.IO;

public class GoalManager
{
    /*Class attributes*/
    private List<Goal> _goals;
    private int _score;

    /*Class constructor*/
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    /*Class methods*/
    public void Start()
    {
        bool flag = true;
        string answer = "";

        while(flag)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu options:\n\t1.Create New Goal\n\t2.List Goals\n\t3.Save Goals\n\t4.Load Goals\n\t5.Record Goal\n\t6.Quit");
            answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    CreateGoal();
                    flag = true;

                    break;
                
                case "2":
                    ListGoalDetails();
                    flag = true;

                    break;
                
                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    SaveGoals(Console.ReadLine());

                    break;
                
                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    LoadGoals(Console.ReadLine());

                    break;
                    
                case "5":
                    RecordEvent();
                    flag = true;

                    break;

                case "6":
                    flag = false;

                    break;
                
                default:
                    Console.WriteLine("Invalid Option!!!");
                    flag = true;

                    break;
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        int goalCount = 1;

        foreach(Goal meta in _goals)
        {
            Console.WriteLine($"{goalCount}. {meta.GetName()}");
            goalCount ++;
        }
    }

    public void ListGoalDetails()
    {
        foreach(Goal meta in _goals)
        {
            Console.WriteLine(meta.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        string goalName;
        string goalDescription;
        int goalPoints;
        int goalTarget;
        int goalBonus;
        string option;

        Console.WriteLine("The types of goals are:\n\t1.Simple Goal\n\t2.Eternal Goal\n\t3.Checklist Goal\nWhich type of goal would you like to create?");
        option = Console.ReadLine();

        switch(option)
        {
            case "1":
                Console.WriteLine("What is the name of your goal?");
                goalName = Console.ReadLine();
                Console.WriteLine("Give a short description of your goal.");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points associated to this goal?");
                goalPoints = int.Parse(Console.ReadLine());

                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(newSimpleGoal);

                break;

            case "2":
                Console.WriteLine("What is the name of your goal?");
                goalName = Console.ReadLine();
                Console.WriteLine("Give a short description of your goal.");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points associated to this goal?");
                goalPoints = int.Parse(Console.ReadLine());

                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(newEternalGoal);

                break;
            case "3":
                Console.Write("\nWhat is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("\nGive a short description of your goal. ");
                goalDescription = Console.ReadLine();
                Console.Write("\nHow many points associated to this goal? ");
                goalPoints = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                goalTarget = int.Parse(Console.ReadLine());
                Console.Write("How many points associated to this goal? ");
                goalBonus = int.Parse(Console.ReadLine());

                ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                _goals.Add(newChecklistGoal);
                
                break;

            default:
                Console.WriteLine("Invalid Option!!!");
                break;
        }
    }

    public void RecordEvent()
    {
        int goalChoice;
        
        Console.WriteLine("The Goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        goalChoice = int.Parse(Console.ReadLine());

        _goals[goalChoice-1].RecordEvent();
        _score += _goals[goalChoice-1].GetPoints();
    }

    public void SaveGoals(string fileName)
    {
        using(StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(_score.ToString());

                    foreach(Goal meta in _goals)
                    {
                        outputFile.WriteLine(meta.GetStringRepresentation());
                    }
                    
                }
    }

    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string goalType;
        string goalInformation;
        string[] parts;
        string[] goalData;

        _score = int.Parse(lines[0]);

        /*Creating a new array without the first line*/
        string[] newLineArray = new string[lines.Length - 1];

        Array.Copy(lines, 1, newLineArray, 0, lines.Length-1);

        foreach(string line in newLineArray)
        {
            parts = line.Split(":");

            goalType = parts[0];
            goalInformation = parts[1];

            goalData = goalInformation.Split(",");

            switch(goalType)
            {
                case "Simple Goal":
                    SimpleGoal recovGoal1 = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));

                    if(goalData[3] == "True")
                        recovGoal1.RecordEvent();
                    
                    _goals.Add(recovGoal1);

                    break;
                
                case "Eternal Goal":
                    EternalGoal recovGoal2 = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));

                    _goals.Add(recovGoal2);

                    break;

                case "Checklist Goal":
                    ChecklistGoal recovGoal3 = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[3]));

                    for(int numberCompleted = 1; numberCompleted <= int.Parse(goalData[5]); numberCompleted ++)
                    {
                        recovGoal3.RecordEvent();
                    }
                    
                    _goals.Add(recovGoal3);

                    break;
                
                default:
                    break;

            }
            
        }
    }
}