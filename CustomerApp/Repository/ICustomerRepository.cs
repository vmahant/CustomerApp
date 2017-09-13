using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Model;

namespace CustomerApp.Repository
{
    public interface ICustomerRepository: IRepository
    {
        /// <summary>
        /// Find entities by their Names
        /// </summary>
        /// <param name="name">name of entities to return</param>
        /// <returns>List of entities that match the supplied name will be returned.</returns>
        Task<IEnumerable<Customer>> GetByName(string name);
    }
}
