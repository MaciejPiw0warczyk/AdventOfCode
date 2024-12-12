namespace AdventOfCode;
internal class DayFour : Day
{
    //private readonly string Input = Helper.GetInput(4).Result.Trim();
    private readonly string Input = "MMMSXXMASM\nMSAMXMSMSA\nAMXSXMAAMM\nMSAMASMSMX\nXMASAMXAMM\nXXAMMXXAMA\nSMSMSASXSS\nSAXAMASAAA\nMAMMMXMMMM\nMXMXAXMASX";

    public override string PartOne()
    {
        int output = 0;

        string word = "XMAS";
        string wordReversed = Reverse(word);
        var splited = Input.Split("\n");
        foreach (var line in splited)
        {
            output += NumberOfWord(line, word);
            output += NumberOfWord(Reverse(line), wordReversed);
        }

        int column = 0; 
        int row = splited.GetLength(0)-1;

        while (column < splited[0].Length) 
        {
            string diagonal = string.Empty;
            string otherDiagonal = string.Empty;
            var tempRow = row;
            var tempColumn = column;

            do
            {
                diagonal += splited[tempRow][tempColumn];
                otherDiagonal += Reverse(splited[tempRow])[tempColumn];
                tempRow--;
                tempColumn--;

            } while (tempRow >= 0 && tempColumn >= 0);

            column++;
            output += NumberOfWord(diagonal, word);
            output += NumberOfWord(Reverse(diagonal), wordReversed);

            output += NumberOfWord(otherDiagonal, word);
            output += NumberOfWord(Reverse(otherDiagonal), wordReversed);

        }

        return output.ToString();
    }
         

    private int NumberOfWord(string line, string word) //bad name
    {
        int output = 0;
        for (int i = 0; i < line.Length - word.Length; i++)
        {
            var bufferSize = i + word.Length;
            var check = line[i..bufferSize];
            if (check == word)
            {
                output++;
            }
        }
        return output;
    }


    public override string PartTwo()
    {
        return base.PartTwo();
    }


    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
