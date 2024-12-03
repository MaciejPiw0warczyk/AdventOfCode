namespace AdventOfCode;
internal class Program
{
    static void Main(string[] args)
    {
        Helper.SessionId = args[0];
        Helper.Year = args[1];

        var day = new DayOne();
        
        Console.WriteLine(day.PartOne());
        Console.WriteLine(day.PartTwo());
    }
}
