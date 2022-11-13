using MongoDB.Bson;

namespace CustomersPractic.Data
{
    public class IndustrialBranch
    {
        public ObjectId Id { get; set; }

        string Name { get; set; }

        public IndustrialBranch() { }
    }

    public class Employer : User
    {
        public IndustrialBranch IndustrialBranch { get; set; }

        public Employer() { }

        public Employer(string login, string password, string email) : base (login, password, email)
        {
            Login = login;
            Password = password;
            Email = email;
        }
    }
}
