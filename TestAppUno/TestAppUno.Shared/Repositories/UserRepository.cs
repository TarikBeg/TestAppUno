using System.Collections.Generic;
using System.Linq;
using TestAppUno.Model;

namespace TestAppUno.Repositories
{
    public class UserRepository
    {
        private static List<User> knownUsers = new List<User>()
        {
            new User() { UserName = "gillcleeren", Password="123456"},
            new User() { UserName = "someuser", Password="123456"}
        };

        public User SearchUser(string userName)
        {
            return knownUsers.FirstOrDefault(u => u.UserName == userName);
        }
    }
}
