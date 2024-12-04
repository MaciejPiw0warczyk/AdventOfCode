namespace AdventOfCode;
internal class Program
{
    static void Main(string[] args)
    {
        Helper.SessionId = args[0];
        Helper.Year = args[1];

        var day = new DayOne();
        var day2 = new DayTwo();

        Console.WriteLine("Day One");
        Console.WriteLine(day.PartOne());
        Console.WriteLine(day.PartTwo());

        Console.WriteLine("Day Two");
        Console.WriteLine(day2.PartOne());
        Console.WriteLine(day2.PartTwo());
    }
}
