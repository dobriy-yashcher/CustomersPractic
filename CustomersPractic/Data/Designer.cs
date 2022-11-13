namespace CustomersPractic.Data
{
    public class Designer : User
    {
        public string CompanyName { get; set; }

        public string OGRN { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }

        public string Address { get; set; }

        public string GeneralManager { get; set; }
        public string GeneralDesigner { get; set; }

        public Designer() { }

        public Designer(string login, string password, string email) : base(login, password, email)
        {
            Login = login;
            Password = password;
            Email = email;
        }
    }
}
