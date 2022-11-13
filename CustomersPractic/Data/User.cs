using MongoDB.Bson;
using System.Data;

namespace CustomersPractic.Data
{
    public enum Roles
    {
        Employer,
        Builder,
        Designer
    }

    public class User
    {
        public ObjectId Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }

        //public Roles Role { get; set; }

        public User() { }

        public User(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
        }
    }
}
