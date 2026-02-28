public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement)) return ("Fine. Be that way!");

        if (statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(char.IsUpper))
        {
            if (statement.Last() == '?') return "Calm down, I know what I'm doing!";
            return "Whoa, chill out!";
        }

        if (statement.Where(c => !char.IsWhiteSpace(c)).Last() == '?') return "Sure.";
        return "Whatever.";
    }
}