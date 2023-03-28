using System;
public static class LogLine {
    public static string Message(string logLine) {
        int start = logLine.IndexOf(": ") + 2;
        int end = logLine.Length;
        
        return logLine[start..end].Trim();
    }
    public static string LogLevel(string logLine) {
        int start = 1;
        int end = logLine.IndexOf("]");
        
        return logLine[start..end].ToLower();
    }
    public static string Reformat(string logLine) {
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);
        
        return $"{message} ({logLevel})";
    }
}
