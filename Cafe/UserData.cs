using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class UserData : ISerializable
    {
        public List<User> AllUsers { get; set; } = new List<User>();
        public string FileName { get; set; } = nameof(DishData);

        public User FindUser(String login)
        {
            foreach(User user in AllUsers)
            {
                if (user.Login.Equals(login)) return user;
            }

            return null;
        }

        
    }
}
