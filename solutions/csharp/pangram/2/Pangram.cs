using System.Globalization;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToLower();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        return alphabet.All(c => input.Contains(c));
    }
}
