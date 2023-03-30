using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        List<string> value_1 = new List<string> { "a", "e", "i", "o", "u", "l", "n", "r", "s", "t" };
        List<string> value_2 = new List<string> { "d", "g" };
        List<string> value_3 = new List<string> { "b", "c", "m", "p" };
        List<string> value_4 = new List<string> { "f", "h", "v", "w", "y" };
        List<string> value_5 = new List<string> { "k" };
        List<string> value_8 = new List<string> { "j", "x" };
        List<string> value_10 = new List<string> { "q", "z" };

        int score = 0;
        foreach (char letter in input.ToLower())
        {
            if (value_1.Contains(letter.ToString()))
            {
                score += 1;
            }
            else if (value_2.Contains(letter.ToString()))
            {
                score += 2;
            }
            else if (value_3.Contains(letter.ToString()))
            {
                score += 3;
            }
            else if (value_4.Contains(letter.ToString()))
            {
                score += 4;
            }
            else if (value_5.Contains(letter.ToString()))
            {
                score += 5;
            }
            else if (value_8.Contains(letter.ToString()))
            {
                score += 8;
            }
            else if (value_10.Contains(letter.ToString()))
            {
                score += 10;
            }
        }

        return score;
    }
}
