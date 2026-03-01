using System.Security.Cryptography;
using System.Text;
using System.Xml.XPath;

using Xunit.Internal;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] separators = { ' ', '-', '_' };
        var result = String.Join("", phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => x[0]));
        return result.ToUpper();
    }
}