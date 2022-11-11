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
    }
}
