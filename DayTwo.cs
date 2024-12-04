namespace AdventOfCode;
internal class DayTwo : Day
{
    private readonly string Input = Helper.GetInput(2).Result.Trim();
    //private readonly string Input = "7 6 4 2 1\n1 2 7 8 9\n9 7 6 2 1\n1 3 2 4 5\n8 6 4 4 1\n1 3 6 7 9";
    public override string PartOne()
    {
        int output = 0;
        var splited = Input.Split("\n").Select(x => x.Split()).ToList();

        foreach (var report in splited)
        {
            var levels = report.Select(x => Convert.ToInt32(x)).ToList(); //move conversion to splited init
            if (Test(levels))
                output++;

        }
        return output.ToString();
    }
    private bool Test(List<int> levels)
    {
        bool isSafe = true;
        bool incrementing = false;

        if (levels[0] == levels[1])
            return false;
        else if (levels[0] < levels[1])
            incrementing = true;
        else
            incrementing = false;

        for (int i = 0; i < levels.Count - 1; i++)
        {
            if (i + 1 <= levels.Count - 1)
            {
                if (levels[i] == levels[i + 1])
                { isSafe = false; break; }

                if (incrementing)
                {
                    if (levels[i] > levels[i + 1])
                    { isSafe = false; break; }
                }
                else if (levels[i] < levels[i + 1])
                { isSafe = false; break; }


                var diff = Math.Abs(levels[i] - levels[i + 1]);
                if (!(diff >= 1 && diff <= 3))
                { isSafe = false; break; }
            }
        }
        return isSafe;
    }
    public override string PartTwo()
    {
        int output = 0;
        var splited = Input.Split("\n").Select(x => x.Split()).ToList();

        foreach (var report in splited)
        {
            var levels = report.Select(x => Convert.ToInt32(x)).ToList(); //move conversion to splited init
            if (Test(levels))
                output++;
            else
            {
                for (int i = 0; i < levels.Count; i++)
                {
                    var newLevels = new List<int>(levels);
                    newLevels.RemoveAt(i);
                    if (Test(newLevels))
                    {
                        output++;
                        break;  
                    }
                }
            }
        }
        return output.ToString();
    }
}
