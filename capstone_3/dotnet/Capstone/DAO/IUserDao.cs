using Capstone.Models;

namespace Capstone.DAO
{
    public interface IUserDao
    {
        User GetUser(string username);
        User AddUser(string username, string password, string role);
        bool DeleteUser(int id);

        void AddProfile(Profile theProfile);
    }
}
