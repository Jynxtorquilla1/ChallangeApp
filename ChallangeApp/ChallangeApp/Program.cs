using ChallangeApp;

var employee1 = new Employee("Korki", "Bucek");
employee1.AddMark(8.55M);
employee1.AddMark(11);
employee1.AddMark(2);
employee1.AddMark(1);
employee1.AddMark("400");
employee1.AddMark("5");
employee1.AddMark("Stefan");
employee1.AddMark(39.599228828D);
employee1.AddMark(94);

var statistics = employee1.GetStatistics();
Console.WriteLine($"Avarage {statistics.Avarage}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"Min {statistics.Min}");

var avarageCeiling = (int)(Math.Ceiling(statistics.Avarage));
Console.WriteLine($"Up rounded Avarage {avarageCeiling}");

