using System.Globalization;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return false;

        Dictionary<char, bool> alphabet = new Dictionary<char, bool>
        {
            {'a', false},
            {'b', false},
            {'c', false},
            {'d', false},
            {'e', false},
            {'f', false},
            {'g', false},
            {'h', false},
            {'i', false},
            {'j', false},
            {'k', false},
            {'l', false},
            {'m', false},
            {'n', false},
            {'o', false},
            {'p', false},
            {'q', false},
            {'r', false},
            {'s', false},
            {'t', false},
            {'u', false},
            {'v', false},
            {'w', false},
            {'x', false},
            {'y', false},
            {'z', false},
        };

        input = input.ToLower();

        foreach (char c in input)
        {

            if (alphabet.ContainsKey(c))
            {
                alphabet[c] = true;
            }
        }

        return alphabet.All(x => x.Value == true);
    }
}
