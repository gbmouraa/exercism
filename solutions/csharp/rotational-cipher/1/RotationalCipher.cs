using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey == 0 || shiftKey == 26) return text;

        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        StringBuilder cypher = new StringBuilder();

        foreach (char c in text)
        {
            if (c == ' ')
            {
                cypher.Append(c);
            }
            else
            {
                int charIndex;
                bool isUpper = false;

                if (c.ToString().ToUpper() == c.ToString())
                {
                    isUpper = true;
                }

                charIndex = alphabet.IndexOf(c.ToString().ToLower());
                if (charIndex == -1)
                {
                    cypher.Append(c);
                    continue;
                }

                int cypherCharIndex = charIndex + shiftKey > 25 ? charIndex + shiftKey - 26 : charIndex + shiftKey;

                if (isUpper)
                {
                    cypher.Append(alphabet[cypherCharIndex].ToString().ToUpper());
                }
                else
                {
                    cypher.Append(alphabet[cypherCharIndex]);
                }
            }
        }

        return cypher.ToString();
    }
}