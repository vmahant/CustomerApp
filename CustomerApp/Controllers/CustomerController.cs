using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Infrastructure;
using CustomerApp.Model;
using CustomerApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [NoCache]
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _customerRepository.GetAll();
        }

        // GET api/notes/5
        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            return await _customerRepository.GetById(id);
        }

        // POST api/notes
        [HttpPost]
        public void Post([FromBody]string values)
        {
            _customerRepository.Add(new Customer { Name = values, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now });
        }
    }
}
