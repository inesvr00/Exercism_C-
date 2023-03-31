using System;
using System.Collections.Generic;
using System.Linq;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        Dictionary<int, string> Roman_Values = new Dictionary<int, string>()
        { 
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
    
        string Roman_Number = "";

        foreach (var Roman_Value in Roman_Values.OrderByDescending(v => v.Key))
        {
            while (value >= Roman_Value.Key)
            {
                Roman_Number += Roman_Value.Value;
                value -= Roman_Value.Key;
            }
        }
    
        return Roman_Number;
    }
}