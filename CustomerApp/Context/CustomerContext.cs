using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CustomerApp.Context
{
    public class CustomerContext
    {
        private readonly IMongoDatabase _database = null;

        public CustomerContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Customer> Customers
        {
            get
            {
                return _database.GetCollection<Customer>("Customer");
            }
        }
    }
}
