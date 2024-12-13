namespace AdventOfCode;
internal class DayFive : Day
{
    private readonly string Input = Helper.GetInput(5).Result.Trim();
    //private readonly string Input = "47|53\r\n97|13\r\n97|61\r\n97|47\r\n75|29\r\n61|13\r\n75|53\r\n29|13\r\n97|29\r\n53|29\r\n61|53\r\n97|53\r\n61|29\r\n47|13\r\n75|47\r\n97|75\r\n47|61\r\n75|61\r\n47|29\r\n75|13\r\n53|13\r\n\r\n75,47,61,53,29\r\n97,61,53,29,13\r\n75,29,13\r\n75,97,47,61,53\r\n61,13,29\r\n97,13,75,29,47";

    private void Prepare(out List<string[]> l1, out List<string[]> l2)
    {
        int output = 0;
        var temp = Input.Split("\n").ToList();
        bool readingRules = true;
        l1 = [];
        l2 = [];
        foreach (var line in temp)
        {
            if (line.Equals(string.Empty))
            {
                readingRules = false;
                continue;
            }

            if (readingRules)
            {
                l1.Add(line.Split("|"));
            }
            else
            {
                l2.Add(line.Split(","));
            }
        }
    }

    private bool UpdateIsCorrect(string[] update, List<string[]> rules)
        {
            string[]? update = updates[i];
            bool isCorrect = true;

            for (int j = 0; j < update.Length; j++)
            {
                string? page = update[j];

                for (int k = j + 1; k < update.Length; k++)
                {
                    foreach (var rule in rules)
                    {
                        if (rule[0] == page && rule[1] == update[k])
                            break;

                        if (rule[0] == update[k] && rule[1] == page)
                        {
                            isCorrect = false;
                            break;
                        }
                        if (!isCorrect)
                        { break; }
                    }
                    if (!isCorrect)
                    { break; }
                }
                if (!isCorrect)
                { break; }
            }
        return isCorrect;
    }

    public override string PartOne()
    {
        int output = 0;
        List<string[]> rules;
        List<string[]> updates;
        List<string[]> correctUpdates = [];

        Prepare(out rules, out updates);

        for (int i = 0; i < updates.Count; i++)
        {
            string[]? update = updates[i];


            if (UpdateIsCorrect(update, rules))
            { correctUpdates.Add(update); }
        }

        foreach (var update in correctUpdates)
        {
            var middlePageIndex = update.Length / 2;
            output += Convert.ToInt32(update[middlePageIndex]);
        }

        return output.ToString();
    }

    public override string PartTwo()
    {
        int output = 0;
        var splited = Input.Split("\n").ToList();
        List<string[]> rules;
        List<string[]> updates;
        List<string[]> inCorrectUpdates = [];

        Prepare(out rules, out updates);

            if (readingRules)
            {
                rules.Add(line.Split("|"));
            }
            else
            {
                updates.Add(line.Split(","));
            }
        }

        for (int i = 0; i < updates.Count; i++)
        {
            string[]? update = updates[i];
            bool isCorrect = true;

            for (int j = 0; j < update.Length; j++)
            {
                string? page = update[j];

                for (int k = j + 1; k < update.Length; k++)
                {
                    foreach (var rule in rules)
                    {
                        if (rule[0] == page && rule[1] == update[k])
                            break;

            if (!UpdateIsCorrect(update, rules))
            { inCorrectUpdates.Add(update); }
        }

        for (int i = 0; i < inCorrectUpdates.Count; i++)
        {
            string[]? update = inCorrectUpdates[i];

            for (int j = 0; j < update.Length; j++)
            {
                for (int k = j + 1; k < update.Length; k++)
                {
                    foreach (var rule in rules)
                    {
                        if (rule[0] == update[j] && rule[1] == update[k])
                            break;

                        if (rule[0] == update[k] && rule[1] == update[j])
                        {
                            var temp = update[j];
                            update[j] = update[k];
                            update[k] = temp;
                            break;
                        }
                    }
                }
            }
            output += Convert.ToInt32(update[update.Length / 2]);
        }

        return output.ToString();
    }
}
