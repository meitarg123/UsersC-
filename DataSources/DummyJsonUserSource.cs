using HomeAssignment.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HomeAssignment.DataSources;

public class DummyJsonUserSource : IUserSource
{
    private static HttpClient _httpClient = new HttpClient();
    private int sourceID = 3;

    // Fetch the users from the API asynchronously
    public async Task<List<User>> FetchUsersAsync()  // Ensure this matches the interface
    {
        string url = "https://dummyjson.com/users"; // URL for ReqRes API

        try
        {
            // Fetch the response from the API
            var response = await _httpClient.GetStringAsync(url);

            // Deserialize the entire response and access the 'data' part directly
            var apiResponse = JsonConvert.DeserializeObject<dynamic>(response);

            var filteredUsers = new List<User>();                
            if (apiResponse?.users != null)
            {
                foreach (var userData in apiResponse.users)
                {
                    // Create a User object for each item in 'data' and add it to the list
                    filteredUsers.Add(new User(
                        userData.firstName.ToString(),
                        userData.lastName.ToString(),
                        userData.email.ToString(),
                        sourceID
                    ));
                }
                UserList.Instance.AddUsers(filteredUsers);
            }

            // Return the filtered list of users
            return filteredUsers;
        }
        catch (Exception ex)
        {
            // Handle errors if the API call fails
            Console.WriteLine($"Error fetching users: {ex.Message}");
            return new List<User>(); // Return an empty list in case of error
        }
    }
}
