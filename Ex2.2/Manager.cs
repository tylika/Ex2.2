using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Manager : Worker
{
    private Random random = new Random();

    public Manager(string name) : base(name)
    {
        Position = "Менеджер";
    }

    public override void FillWorkDay()
    {
        int firstCallCount = random.Next(1, 11); // Випадкове число від 1 до 10
        for (int i = 0; i < firstCallCount; i++)
        {
            Call();
        }
        Relax();
        int secondCallCount = random.Next(1, 6); // Випадкове число від 1 до 5
        for (int i = 0; i < secondCallCount; i++)
        {
            Call();
        }
    }
}
