namespace AdventOfCode;
internal class DayThree : Day
{
    private readonly string Input = Helper.GetInput(3).Result.Trim();
    //private readonly string Input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))\r\n";

    public override string PartOne() //TODO make a regex idk why i didnt do it that way from the start
    {
        int output = 0;

        for (int i = 0; i < Input.Length - 3; i++)
        {
            int end = i + 3;
            string command = string.Empty;
            if (Input[i..end] == "mul")
            {
                for (int j = i; j < Input.Length; j++)
                {
                    if (Input[j] != ')')
                    {
                        command += Input[j];
                    }
                    else
                    {
                        command += Input[j];
                        break;
                    }
                }

                var test = command[4..^1];
                bool correct = true;
                foreach (char c in test)
                {
                    if ((!(c == ',' || char.IsDigit(c)))||test.Length==0)
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    var numbers = test.Split(',');
                    int toAdd = 1;
                    if (numbers.Length ==2)
                    {
                        foreach (var number in numbers)
                        {
                            int t;
                            if (int.TryParse(number, out t))
                            {
                                toAdd *= t;
                            }
                            else
                            {
                                toAdd = 0;
                                break;
                            }
                        }
                        output += toAdd;
                    }
                }
            }
        }
        return output.ToString();
    }

    public override string PartTwo()
    {
        int output = 0;
        bool enabled = true;
        for (int i = 0; i < Input.Length - 3; i++)
        {
            //dos and donts
            if (i + 7 < Input.Length)
            {
                int doend = i + 4;
                int dontsend = i + 7;
                if (Input[i..doend] == "do()")
                { enabled = true; continue; }
                else if (Input[i..dontsend] == "don't()")
                { enabled = false; continue; }
            }
            //


            int end = i + 3;
            string command = string.Empty;
            if (Input[i..end] == "mul" && enabled)
            {
                for (int j = i; j < Input.Length; j++)
                {
                    if (Input[j] != ')')
                    {
                        command += Input[j];
                    }
                    else
                    {
                        command += Input[j];
                        break;
                    }
                }

                var test = command[4..^1];
                bool correct = true;
                foreach (char c in test)
                {
                    if ((!(c == ',' || char.IsDigit(c))) || test.Length == 0)
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    var numbers = test.Split(',');
                    int toAdd = 1;
                    if (numbers.Length == 2)
                    {
                        foreach (var number in numbers)
                        {
                            int t;
                            if (int.TryParse(number, out t))
                            {
                                toAdd *= t;
                            }
                            else
                            {
                                toAdd = 0;
                                break;
                            }
                        }
                        output += toAdd;
                    }
                }
            }
        }
        return output.ToString();
    }

}
