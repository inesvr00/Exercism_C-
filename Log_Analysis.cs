using System;
public static class LogAnalysis 
{
     
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string substring)
    {
        string[] string_split = log.Split(substring);
        return string_split[1];
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string start, string end)
    {
        int startIndex = log.IndexOf(start) + start.Length;
        int endIndex = log.IndexOf(end, startIndex);
        if (startIndex < start.Length || endIndex < 0)
        {
            return string.Empty; // Alguno de los delimitadores no fue encontrado
        }
        return log.Substring(startIndex, endIndex - startIndex).Trim();
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log)
    {
        return SubstringAfter(log, ": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log)
    {
        int indexInicio = 1;
        int indexFin = log.IndexOf("]");
        return log[indexInicio..indexFin];
    }
}
