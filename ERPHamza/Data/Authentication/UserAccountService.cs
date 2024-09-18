using System.Collections.Generic;
using System.Linq;

namespace ERPHamza.Data.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> users;

        public UserAccountService()
        {
            users = new List<UserAccount>
            {
                new UserAccount { UserName = "admin", Password = "admin", Role = "admin" },
                new UserAccount { UserName = "user", Password = "user", Role = "user" }
            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            return users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
