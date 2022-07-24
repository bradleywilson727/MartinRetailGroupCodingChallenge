using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MartinRetailGroupCodingChallenge.Shared;


namespace MartinRetailGroupCodingChallenge.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "Bradley Wilson", EmailAddress = "bradleywilson727@gmail.com", Message = "This service is great!"},

            new Customer {Name = "Andy Brown", EmailAddress = "notreal@dontwannaspamyou.com", Message = "I hope this service is great!"}
        };


        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            customers.Add(customer);

            return Ok(customers);
        }
    }
}
