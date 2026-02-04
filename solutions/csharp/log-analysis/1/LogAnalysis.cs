using System.Globalization;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        return str.Substring(index + delimiter.Length);
    }
  
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string delimiter1,string delimiter2)
    {
        int idx1 = str.IndexOf(delimiter1);
        int idx2 = str.IndexOf(delimiter2);
        int betweenLength = idx2 - (idx1 + delimiter1.Length);
        return str.Substring(idx1 + delimiter1.Length, betweenLength);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter("]: ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}

