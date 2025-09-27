public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // For saving to file: "Date|Prompt|Response"
    public string ToSaveString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // For display: "Date: ... – Prompt: ...\nResponse"
    public string ToDisplayString()
    {
        return $"Date: {Date} – Prompt: {Prompt}\n{Response}";
    }

    // Reconstruct from saved line
    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length >= 3)
        {
            return new Entry(parts[1], parts[2], parts[0]);
        }
        throw new System.ArgumentException("Invalid entry format");
    }
}