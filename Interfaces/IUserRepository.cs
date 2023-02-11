using VulnASP.NET_API.Models;

namespace VulnASP.NET_API.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int id);
        User GetUser(string username);
        User GetUserRaw(string username);
        User GetUserRawParameterized(string username);
        ICollection<User> GetUserRawList(string username);
    }
}
