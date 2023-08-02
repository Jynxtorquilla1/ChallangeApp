using ChallangeApp;

var employee1 = new Employee("Bogusław", "Łęcina");
employee1.AddMark(8.55M);
employee1.AddMark(94);
employee1.AddMark(2);
employee1.AddMark(1);
employee1.AddMark("400");
employee1.AddMark("5");
employee1.AddMark("Stefan");
employee1.AddMark(39.599228828D);
employee1.AddMark(94);

var statisticsForeach = employee1.GetStatisticsWithForeach();
Console.WriteLine($"Avarage {statisticsForeach.Avarage}");
Console.WriteLine($"Max {statisticsForeach.Max}");
Console.WriteLine($"Min {statisticsForeach.Min}");

var statisticsFor = employee1.GetStatisticsWithFor();
Console.WriteLine($"Avarage {statisticsFor.Avarage}");
Console.WriteLine($"Max {statisticsFor.Max}");
Console.WriteLine($"Min {statisticsFor.Min}");

var statisticsWhile = employee1.GetStatisticsWithForeach();
Console.WriteLine($"Avarage {statisticsWhile.Avarage}");
Console.WriteLine($"Max {statisticsWhile.Max}");
Console.WriteLine($"Min {statisticsWhile.Min}");

var statisticsDoWhile = employee1.GetStatisticsWithForeach();
Console.WriteLine($"Avarage {statisticsDoWhile.Avarage}");
Console.WriteLine($"Max {statisticsDoWhile.Max}");
Console.WriteLine($"Min {statisticsDoWhile.Min}");

//var avarageCeiling = (int)(Math.Ceiling(statistics.Avarage));
//Console.WriteLine($"Up rounded Avarage {avarageCeiling}");



