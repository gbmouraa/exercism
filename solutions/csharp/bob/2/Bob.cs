public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";

        if (statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(char.IsUpper))
        {
            if (statement.EndsWith('?')) return "Calm down, I know what I'm doing!";
            return "Whoa, chill out!";
        }

        if (statement.Trim().EndsWith('?')) return "Sure.";
        return "Whatever.";
    }
}