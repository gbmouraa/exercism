using System.Security.Cryptography;
using System.Text;
using System.Xml.XPath;

using Xunit.Internal;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var str = new StringBuilder();
        var result = "";
        phrase = phrase.Replace('-', ' ');

        foreach (char c in phrase)
        {
            if (c != '_') str.Append(c);
        }

        var test = str.ToString().Split(' ').Where(x => x.All(x => x != ' '));
        foreach (var item in test)
        {
            if (item == "") continue;
            result += item[0];
        }
        return result.ToUpper();
    }
}