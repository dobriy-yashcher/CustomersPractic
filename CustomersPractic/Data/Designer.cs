﻿namespace CustomersPractic.Data
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
    }
}
