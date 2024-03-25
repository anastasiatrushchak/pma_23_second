using Lab_6.Adapter.Adapter;
using System.Text.Json;

internal class TxtToJsonToString(string filename) : IJsonToString
{
    readonly string _filename = filename;

    public string ConvertToString()
    {
        string[] lines = File.ReadAllLines(_filename);
        if (lines.Length < 3)
        {
            throw new ArgumentException("Input file doesn't contain enough lines.");
        }
        string name = lines[0].Trim();
        int age = int.Parse(lines[1].Trim());
        string city = lines[2].Trim();
        var jsonObject = new
        {
            name,
            age,
            city
        };

        return JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions { WriteIndented = true });
    }

}
