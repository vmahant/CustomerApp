using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Model;

namespace CustomerApp.Repository
{
    public interface IReadOnlyRepository
    {
        /// <summary>
		/// get all records
		/// </summary>
		/// <returns>return all entities in the database, returns entity. If no matches are found, returns null</returns>
		Task<IEnumerable<Customer>> GetAll();

        /// <summary>
		/// Find an entity by its Id
		/// </summary>
		/// <param name="id">Id of entity</param>
		/// <returns>If Id matches an entity in the database, returns entity. If no matches are found, returns null</returns>
		Task<Customer> GetById(int id);

        /// <summary>
        /// Find entities by their Ids
        /// </summary>
        /// <param name="ids">List of ids of entities to return</param>
        /// <returns>List of entities that match the supplied IDs will be returned.</returns>
        Task<IEnumerable<Customer>> GetByIds(IEnumerable<int> ids);
    }
}
