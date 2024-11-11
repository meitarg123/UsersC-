using HomeAssignment.Models;

namespace HomeAssignment.Writers
{
    public interface IFileWriter
    {
        void WriteToFile(List<User> users, string filePath);  // Changed IEnumerable to List
    }
}
