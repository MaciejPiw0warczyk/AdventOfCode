namespace AdventOfCode;
public class DayOne : Day
{
    private readonly string Input = Helper.GetInput(1).Result.Trim();
    public override string PartOne()
    {
        int output = 0;

        var splited = Input.Split("\n");
        List<int> leftValues = [];
        List<int> rightValues = [];

        foreach (var line in splited)
        {
            var values = line.Split();
            leftValues.Add(Convert.ToInt32(values[0]));
            rightValues.Add(Convert.ToInt32(values[^1]));
        }

        leftValues.Sort();
        rightValues.Sort();

        for(int i = 0; i < leftValues.Count-1; i++)
        {
            output += Math.Abs(leftValues[i] - rightValues[i]);
        }

        return output.ToString();
    }

    public override string PartTwo()
    {
        int output = 0;

        var splited = Input.Split("\n");
        List<int> leftValues = [];
        List<int> rightValues = [];
        
        foreach (var lValue in leftValues)
        {
            int occurences = 0;
            foreach(var rValue  in rightValues)
            {
                if (rValue == lValue) occurences++;
            }
            output += lValue * occurences;
        }


        return output.ToString();
    }
}
