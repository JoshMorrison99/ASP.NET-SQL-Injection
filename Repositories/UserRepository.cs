using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VulnASP.NET_API.Data;
using VulnASP.NET_API.Interfaces;
using VulnASP.NET_API.Models;

namespace VulnASP.NET_API.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) 
        { 
            _context = context;
        }

        public User GetUser(int id)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public User GetUser(string username)
        {
            return _context.Users.Where(x => x.UserName == username).FirstOrDefault();
        }

        public User GetUserRaw(string username)
        {
            var query = "SELECT * FROM Users WHERE username = '" + username + "'";
            return _context.Users.FromSqlRaw(query).FirstOrDefault();
        }

        public User GetUserRawParameterized(string username)
        {
            return _context.Users.FromSqlRaw("SELECT * FROM Users WHERE username = {0}", username).FirstOrDefault();
        }

        public ICollection<User> GetUserRawList(string username)
        {
            var query = "SELECT * FROM Users WHERE username = '" + username + "'";
            return _context.Users.FromSqlRaw(query).ToList();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(x => x.Id).ToList();
        }
    }
}
