﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Team
{
    public string Name { get; set; }
    private List<Worker> workers;
    public Team(string name)
    {
        Name = name;
        workers = new List<Worker>();
    }
    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }

    public void ShowTeamInfo()
    {
        Console.WriteLine($"Команда: {Name}");
        foreach (var worker in workers)
        {
            Console.WriteLine(worker.Name);
        }
    }

    public void ShowDetailedInfo()
    {
        Console.WriteLine($"Команда: {Name}");
        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
        }
    }
}