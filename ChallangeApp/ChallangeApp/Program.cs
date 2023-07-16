using ChallangeApp;

Employee empl1 = new Employee("Jack  ", "Black", 53);
Employee empl2= new Employee("Elon  ", "Musk ", 52);
Employee empl3 = new Employee("Donald", "Trump", 77);

empl1.addMark(9);
empl1.addMark(9);
empl1.addMark(7);
empl1.addMark(7);
empl1.addMark(10);
empl1.removeMark(42);

empl2.addMark(2);
empl2.addMark(2);
empl2.addMark(5);
empl2.addMark(3);
empl2.addMark(3);

empl3.addMark(1);
empl3.addMark(2);
empl3.addMark(1);
empl3.addMark(1);
empl3.addMark(1);

//Console.WriteLine(empl2.Result);


List<Employee> employees = new List<Employee>()
{
    empl1, empl2, empl3
};

int empl1Mark = empl1.Result;
int empl2Mark = empl2.Result;
int empl3Mark = empl3.Result;
int maxMark = Math.Max(empl1Mark, Math.Max(empl2Mark, empl3Mark));

//Console.WriteLine(maxScore);

Console.WriteLine("Name" + "   Surname" + "  Age  " + "Score");
Console.WriteLine("       ");

foreach (var empl in employees)
{
    if (empl.Result == maxMark)
    {
        Console.WriteLine(empl.Name + "   " + empl.Surname +"   "+ empl.Age + "   " + empl.Result + "   Employee with the best result");
    }
    else
    {
        Console.WriteLine(empl.Name + "   " + empl.Surname + "   " + empl.Age +"   " + empl.Result + "   Loser");
    }
}

int maxResult = -1;
Employee emplWithMax = null;

foreach (Employee empl in employees)
{
    if (empl.Result > maxResult)
    {
        emplWithMax = empl;
        Console.WriteLine(empl.Name + empl.Result);
    }
}

