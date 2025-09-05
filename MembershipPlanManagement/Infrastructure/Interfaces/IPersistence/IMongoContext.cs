using MongoDB.Driver;

namespace Infrastructure.Interfaces.IPersistence; 

public interface IMongoContext
{
    IMongoCollection<T> GetCollection<T>(string name);
}