using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Team> teams = new List<Team>();

        while (true)
        {
            Console.WriteLine("Оберіть дію:");
            Console.WriteLine("1. Створити нову команду");
            Console.WriteLine("2. Додати працівника до команди");
            Console.WriteLine("3. Вивести інформацію про всі команди");
            Console.WriteLine("4. Вийти");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введіть назву команди: ");
                string teamName = Console.ReadLine();
                Team newTeam = new Team(teamName);
                teams.Add(newTeam);
            }
            else if (choice == 2)
            {
                Console.Write("Введіть назву команди: ");
                string teamToFind = Console.ReadLine();
                Team teamToAddTo = teams.FirstOrDefault(t => t.Name == teamToFind);
                if (teamToAddTo != null)
                {
                    Console.Write("Введіть ім'я працівника: ");
                    string workerName = Console.ReadLine();
                    Console.Write("Введіть посаду працівника (Розробник або Менеджер): ");
                    string position = Console.ReadLine();

                    Worker newWorker;
                    if (position.ToLower() == "розробник")
                    {
                        newWorker = new Developer(workerName);
                    }
                    else if (position.ToLower() == "менеджер")
                    {
                        newWorker = new Manager(workerName);
                    }
                    else
                    {
                        Console.WriteLine("Невідома посада.");
                        continue;
                    }

                    teamToAddTo.AddWorker(newWorker);
                    newWorker.FillWorkDay();
                }
                else
                {
                    Console.WriteLine("Команда не знайдена.");
                }
            }
            else if (choice == 3)
            { if (teams.Count==0) Console.WriteLine("Команд немає.");
                else
                { foreach (var team in teams)
                    {
                        team.ShowDetailedInfo();
                    }
                }
                Console.WriteLine();
            }
            else if (choice == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("Некоректний вибір.");
            }
        }
    }
}