using System.Collections.Generic;
using CustomerApp.Core.ApplicationService;
using CustomerApp.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CustomerRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        // GET api/customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _customerService.GetAllCustomers();
        }

        // GET api/customers/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/customers
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName))
            {
                return BadRequest("Firstname is Required for Creating Customer");
            }

            if (string.IsNullOrEmpty(customer.LastName))
            {
                return BadRequest("LastName is Required for Creating Customer");
            }
            //return StatusCode(503, "Horrible Error CALL Tech Support");
            return _customerService.CreateCustomer(customer);
        }
        
        // PUT api/customers/5 -- Update
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, [FromBody] Customer customer)
        {
            if (id < 1 || id != customer.Id)
            {
                return BadRequest("Parameter Id and customer ID must be the same");
            }

            return Ok();
        }

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
