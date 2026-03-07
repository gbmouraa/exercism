using System.Runtime.InteropServices;
using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        StringBuilder encoded = new StringBuilder();

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {

            if (i != input.Length - 1)
            {
                if (input[i + 1] == input[i])
                {
                    if (i == 0 || count == 0)
                    {
                        count = count + 2;
                    }
                    else
                    {
                        count++;
                    }
                }
                else
                {
                    if (count > 0)
                    {
                        encoded.Append($"{count}{input[i]}");
                    }
                    else
                    {
                        encoded.Append(input[i]);
                    }
                    count = 0;
                }
            }

            if (i == input.Length - 1)
            {
                if (count > 0)
                {
                    encoded.Append($"{count}{input[i]}");
                }
                else
                {
                    encoded.Append(input[i]);
                }
            }
        }

        return encoded.ToString();
    }

    public static string Decode(string input)
    {
        if (!input.Any(char.IsNumber)) return input;
        StringBuilder decoded = new StringBuilder();

        string numberCount = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsNumber(input[i]))
            {
                numberCount += input[i];
            }
            else
            {
                if (numberCount != "")
                {
                    decoded.Append(new string(input[i], int.Parse(numberCount)));
                }
                else
                {
                    decoded.Append(input[i]);
                }

                numberCount = "";
            }
        }

        return decoded.ToString();
    }
}
