namespace AdventOfCode;
static public class Helper
{
    public static string SessionId = string.Empty;
    public static string Year = string.Empty;
    static public async Task<string> GetInput(int dayNumber)
    {
        using var handler = new HttpClientHandler();
        handler.CookieContainer = new();
        handler.CookieContainer.Add(new Uri("https://adventofcode.com"), new System.Net.Cookie("session", SessionId));

        using var client = new HttpClient(handler);
        return await client.GetStringAsync($"https://adventofcode.com/{Year}/day/{dayNumber}/input");
    }
}

public class Day
{
    public virtual string PartOne() => "Not implemented";
    public virtual string PartTwo() => "Not implemented";
}