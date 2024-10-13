using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Worker
{

    private string name;
    private string position;
    private string workDay;
    
    public string Name { get { return name; } set { name = value; } }
    public string Position { get { return position; } set { position = value; } }
    public string WorkDay { get { return workDay; } set { workDay = value; } }

    public Worker(string name)
    {
        Name = name;
        WorkDay = "";
    }

   
    public void Call()
    {
        WorkDay += " Call() ";
    }

    public void WriteCode()
    {
        WorkDay += " WriteCode() ";
    }

    public void Relax()
    {
        WorkDay += " Relax() ";
    }

    public abstract void FillWorkDay();
}
