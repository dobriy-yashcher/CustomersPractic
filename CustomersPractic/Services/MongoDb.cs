using CustomersPractic.Data;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CustomersPractic.Services
{
    public class MongoDb
    {
        public static IMongoDatabase database = new MongoClient("mongodb://localhost:27017").GetDatabase("CustomersPractic");

        #region Add

        public static void AddUserToDataBase(Employer user)
        {
            var collection = database.GetCollection<Employer>("EmployerCollection");
            collection.InsertOne(user);
        }

        public static void AddUserToDataBase(Designer user)
        {
            var collection = database.GetCollection<Designer>("DesignerCollection");
            collection.InsertOne(user);
        }

        public static void AddUserToDataBase(Builder user)
        {
            var collection = database.GetCollection<Builder>("BuilderCollection");
            collection.InsertOne(user);
        }

        #endregion

        //public static void DeleteUserFromDataBase(User user)
        //{
        //    var filter = new BsonDocument("Id", user.Id);
        //    users.DeleteOne(filter);
        //}

        //public static void ReplaceOneUserInDataBase(User user)
        //{
        //    var filter = new BsonDocument("Id", user.Id);
        //    users.ReplaceOne(filter, user);
        //}

        #region Find

        //public static User FindUserById(string id)
        //{
        //    var filter = new BsonDocument("Id", ObjectId.Parse(id));
        //    return users.Find(filter).FirstOrDefault();
        //}

        public static User? FindUserByLogin(string login)
        {
            var log1 = FindEmployerByLogin(login);
            var log2 = FindDesignerByLogin(login);
            var log3 = FindBuilderByLogin(login);

            if (log1 != null) return log1;
            if (log2 != null) return log2;
            if (log3 != null) return log3;

            return null;
        }

        public static Employer FindEmployerByLogin(string login)
        {
            var filter = Builders<Employer>.Filter.Eq("Login", login);
            var collection = database.GetCollection<Employer>("EmployerCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public static Designer FindDesignerByLogin(string login)
        {
            var filter = Builders<Designer>.Filter.Eq("Login", login);
            var collection = database.GetCollection<Designer>("DesignerCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public static Builder FindBuilderByLogin(string login)
        {
            var filter = Builders<Builder>.Filter.Eq("Login", login);
            var collection = database.GetCollection<Builder>("BuilderCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        #endregion

        /*public static IMongoCollection<User> GetUserCollection()
        {
            return users;
        }*/
    }
}
