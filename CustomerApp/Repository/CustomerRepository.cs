using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Context;
using CustomerApp.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CustomerApp.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context = null;

        public CustomerRepository(IOptions<Settings> settings)
        {
            _context = new CustomerContext(settings);
        }

        public async Task Add(Customer customer)
        {
            await _context.Customers.InsertOneAsync(customer);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
           return await _context.Customers.Find(_ => true).ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            var filter = Builders<Customer>.Filter.Eq("Id", id);
            return await _context.Customers
                                .Find(filter)
                                .FirstOrDefaultAsync();
        }

        public Task GetByIds(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> RemoveAll()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResult> Update(int id, string body)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceOneResult> UpdateDocument(string id, string body)
        {
            throw new NotImplementedException();
        }
        
        Task<IEnumerable<Customer>> IReadOnlyRepository.GetByIds(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}
