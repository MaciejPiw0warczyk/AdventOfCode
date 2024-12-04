using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode;
internal class DayFour : Day
{
    //private readonly string Input = Helper.GetInput(4).Result.Trim();
    private readonly string Input = "MMMSXXMASM\nMSAMXMSMSA\nAMXSXMAAMM\nMSAMASMSMX\nXMASAMXAMM\nXXAMMXXAMA\nSMSMSASXSS\nSAXAMASAAA\nMAMMMXMMMM\nMXMXAXMASX";

    public override string PartOne()
    {
        int output = 0;

        string word = "xmas";

        foreach(var line in Input.Split("\n"))
            foreach(var c in line)
            {

            }

        return output.ToString();
    }

    public override string PartTwo()
    {
        return base.PartTwo();
    }
}
