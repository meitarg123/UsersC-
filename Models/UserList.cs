namespace HomeAssignment.Models;  // File-scoped namespace

public sealed class UserList
{
    private static UserList instance = null;
    private static readonly object padlock = new object();

    public List<User> Users { get; set; } = new List<User>();

    // Private constructor to prevent instantiation outside of this class
    private UserList()
    {
        Users = new List<User>();
    }

    public static UserList Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new UserList();
                }
                return instance;
            }
        }
    }

    // Method to add a list of users to the UserList
    public void AddUsers(List<User> users)
    {
        if (users != null)
        {
            Users.AddRange(users);
        }
    }
}
