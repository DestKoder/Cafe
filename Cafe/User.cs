using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    //TELLER - кассир
    public enum UserRole
    {
        ADMIN,
        MANAGER,
        TELLER
    }

    public class User
    {
        //TODO: Добавить свойство Image для хранениея фотографии пользователя
        public String Login { get; set; }
        public String Password { get; set; }
    
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Email { get; set; }
        public UserRole Role { get; set; }
    
        public User() { }
        public User(String login, String pass, string firstName, String lastName, String email, UserRole role)
        {
            Login = login;
            Password = pass;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
        }
    }
}
