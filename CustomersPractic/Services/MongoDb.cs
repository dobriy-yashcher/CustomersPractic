using CustomersPractic.Data;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CustomersPractic.Services
{
    public class MongoDb
    {
        public static IMongoCollection<User> users =
            new MongoClient("mongodb://localhost:27017").GetDatabase("CustomersPractic").GetCollection<User>("Users");

        public static void AddUserToDataBase(User user)
        {
            users.InsertOne(user);
        }

        public static void DeleteUserFromDataBase(User user)
        {
            var filter = new BsonDocument("Id", user.Id);
            users.DeleteOne(filter);
        }

        public static void ReplaceOneUserInDataBase(User user)
        {
            var filter = new BsonDocument("Id", user.Id);
            users.ReplaceOne(filter, user);
        }

        public static User FindUserById(string id)
        {
            var filter = new BsonDocument("Id", ObjectId.Parse(id));
            return users.Find(filter).FirstOrDefault();
        }

        public static IMongoCollection<User> GetUserCollection()
        {
            return users;
        }
    }
}
