using ChallangeApp;

Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine("Wpisz ocenę jako liczbę lub jako literę: A, B, C, D lub E");
Console.WriteLine("lub wpisz literę q lub Q aby wyświeltlić statystyki pracwonika");
Console.WriteLine();
var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę");
    var input = Console.ReadLine();     
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddMark(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avarage Score Letter  {statistics.AvarageLetter}");
Console.WriteLine($"Avarage {statistics.Avarage}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"Min {statistics.Min}");