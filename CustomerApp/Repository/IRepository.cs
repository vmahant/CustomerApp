using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Model;
using MongoDB.Driver;

namespace CustomerApp.Repository
{
    public interface IRepository :IReadOnlyRepository
    {
        Task Add(Customer customer);
        Task<DeleteResult> Remove(int id);

        Task<UpdateResult> Update(int id, string body);

        Task<ReplaceOneResult> UpdateDocument(string id, string body);

        Task<DeleteResult> RemoveAll();
    }
}
