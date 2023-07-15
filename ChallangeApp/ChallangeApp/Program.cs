
using ChallangeApp;
using System;
using System.Runtime.CompilerServices;

Employee empl1 = new Employee("Jack  ", "Black", 53);
Employee empl2 = new Employee("Elon  ", "Musk ", 52);
Employee empl3 = new Employee("Donald", "Trump", 77);

empl1.addScore(9); empl1.addScore(9); empl1.addScore(7); empl1.addScore(7); empl1.addScore(10);

empl2.addScore(2); empl2.addScore(2); empl2.addScore(5); empl2.addScore(3); empl2.addScore(3);

empl3.addScore(1); empl3.addScore(2); empl3.addScore(1); empl3.addScore(1); empl3.addScore(1);

//Console.WriteLine(empl2.Result);


List<Employee> employees = new List<Employee>()
{
    empl1, empl2, empl3
};

int empl1Score = empl1.Result;
int empl2Score = empl2.Result;
int empl3Score = empl3.Result;
int maxScore = Math.Max(empl1Score, Math.Max(empl2Score, empl3Score));
//Console.WriteLine(maxScore);
Console.WriteLine("Name" + "   Surname" + "  Age  " + "Score");
Console.WriteLine("       ");

foreach (var empl in employees)
{
    if (empl.Result == maxScore)
    {
        Console.WriteLine(empl.Name + "   " + empl.Surname +"   "+ empl.Age + "   " + empl.Result);
    }
    else
    {
        Console.WriteLine(empl.Name + "   " + empl.Surname + "   " + empl.Age + "   Loser");
    }
}