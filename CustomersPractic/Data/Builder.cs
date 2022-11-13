namespace CustomersPractic.Data
{
    public class Builder : User
    {
        public string CompanyName { get; set; }

        public string OGRN { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        
        public string Address { get; set; }

        public string GeneralManager { get; set; }

        public Builder() { }

        public Builder(string login, string password, string email) : base(login, password, email)
        {
            Login = login;
            Password = password;
            Email = email;
        }
    }
}
