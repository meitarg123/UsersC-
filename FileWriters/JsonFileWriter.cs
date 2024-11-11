using Newtonsoft.Json;
using HomeAssignment.Models;
using System.IO;

namespace HomeAssignment.Writers;  // File-scoped namespace

public class JsonFileWriter : IFileWriter
{
    // Method to serialize users to JSON and write to a file
    public void WriteToFile(List<User> users, string filePath)
    {
        Console.WriteLine("enter");
        // Serialize the list of users to JSON
        var json = JsonConvert.SerializeObject(users, Formatting.Indented);

        // Write the JSON to the specified file path
        File.WriteAllText(filePath, json);
    }
}
