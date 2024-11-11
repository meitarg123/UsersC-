using System;
using HomeAssignment.DataSources;
using HomeAssignment.Models;
using HomeAssignment.Writers;

namespace HomeAssignment;  // File-scoped namespace

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("which format do you want to use? (JSON or CSV)");
        string? userChoice = Console.ReadLine()?.ToLower();

        var reqResUserSource = new ReqResUserSource(); 
        List<User> users = await reqResUserSource.FetchUsersAsync();


        if (userChoice != null && userChoice == "json")
        {
            // Write to JSON file
            var jsonFileWriter = new JsonFileWriter();
            string filePath = @"C:\Users\maita\learnC#\MyNewProject\users.json"; // Specify the file path where the JSON will be saved
            jsonFileWriter.WriteToFile(users, filePath);
        }
        else if (userChoice == "csv")
        {
            Console.WriteLine("You chose not to save in JSON format.");
        }
    }
}
