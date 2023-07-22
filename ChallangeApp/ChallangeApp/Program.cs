using ChallangeApp;

var employee1 = new Employee("Korki", "Bucek");
employee1.addMark(7);
employee1.addMark(9);
employee1.addMark(2);
employee1.addMark(5);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Avarage {statistics.Avarage}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"Min {statistics.Min}");

