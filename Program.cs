namespace AdventOfCode;
internal class Program
{
    static void Main(string[] args)
    {
        Helper.SessionId = args[0];
        Helper.Year = args[1];

        List<Day> days = new List<Day>();

        days.Add(new DayOne());
        days.Add(new DayTwo());
        days.Add(new DayThree());
        days.Add(new DayFour());
        days.Add(new DayFive());

        foreach (Day day in days)
        {
            Console.WriteLine(nameof(day));
            Console.WriteLine(day.PartOne());
            Console.WriteLine(day.PartTwo());
            Console.WriteLine();
        }
    }
}
