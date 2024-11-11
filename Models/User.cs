namespace HomeAssignment.Models;  // File-scoped namespace

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int SourceId { get; set; }

    // Constructor (optional, can also use object initialization)
    public User(string firstName, string lastName, string email, int sourceId)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        SourceId = sourceId;
    }
}
