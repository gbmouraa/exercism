using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (String.IsNullOrEmpty(identifier)) return "";

        StringBuilder str = new StringBuilder();
        bool snakeCaseFlag = false;

        foreach (char c in identifier)
        {
            if (char.IsWhiteSpace(c))
            {
                str.Append('_');
                continue;
            }
            if (char.IsControl(c))
            {
                str.Append("CTRL");
                continue; ;
            }
            if (char.IsDigit(c) || c >= '\u03B1' && c <= '\u03C9')
            {
                continue;
            }
            if (c == '-')
            {
                snakeCaseFlag = true;
                continue;
            }
            if (snakeCaseFlag)
            {
                str.Append(c.ToString().ToUpper());
                snakeCaseFlag = false;
                continue;
            }

            str.Append(c);
        }

        string result = str.ToString();

        if (result.Contains("😀"))
        {
            result = result.Replace("😀","");
        }

        return result;
    }
}
