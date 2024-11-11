using HomeAssignment.Models;
namespace HomeAssignment.DataSources;

public interface IUserSource
{
    Task<List<User>> FetchUsersAsync();
}
