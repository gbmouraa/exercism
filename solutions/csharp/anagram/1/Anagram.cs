using System.Diagnostics.Tracing;

using Xunit.Internal;

public class Anagram
{
    private readonly string _baseWord;
    private Dictionary<char, int> _baseWordLettersCount => getLettersAndCount(_baseWord);

    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    private Dictionary<char, int> getLettersAndCount(string word)
    {
        Dictionary<char, int> letterCount = new Dictionary<char, int> { };

        foreach (char letter in word.ToLower())
        {
            if (letterCount.ContainsKey(letter))
            {
                letterCount[letter] = letterCount[letter] + 1;
            }
            else
            {
                letterCount.Add(letter, 1);
            }
        }

        return letterCount;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> anagrams = new List<string> { };

        foreach (string word in potentialMatches)
        {
            if (!word.ToLower().All(c => _baseWord.ToLower().Contains(c)) || _baseWord.ToLower() == word.ToLower()) continue;

            Dictionary<char, int> letterCount = getLettersAndCount(word);
            bool append = true;

            foreach (var item in letterCount)
            {
                char curentChar = item.Key;
                if (item.Value != _baseWordLettersCount[curentChar])
                {
                    append = false;
                    break;
                }
            }

            if (append) anagrams.Add(word);
        }

        return [.. anagrams];
    }
}