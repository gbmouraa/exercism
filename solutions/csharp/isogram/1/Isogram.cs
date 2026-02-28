using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> letters = new List<char>{};
        word = new string([.. word.Where(char.IsLetter)]).ToLower();

        foreach(char c in word)
        {
            if (letters.Contains(c)) return false;
            letters.Add(c);
        }

        return true;
        
    }
}
