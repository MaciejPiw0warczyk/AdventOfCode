namespace AdventOfCode;
internal class DayTwo : Day
{
    private readonly string Input = Helper.GetInput(2).Result.Trim();
    public override string PartOne()
    {
        int output = 0;
        var splited = Input.Split("\n").Select(x => x.Split()).ToList();

        foreach (var report in splited)
        {
            var levels = report.Select(x => Convert.ToInt32(x)).ToList(); //move conversion to splited init
            bool isSafe = true;
            bool incrementing = false;

            if (levels[0] == levels[1])
                continue;
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
            if (isSafe)
                output++;

        }
        return output.ToString();
    }

    public override string PartTwo()
    {
        return base.PartTwo();
    }
}
