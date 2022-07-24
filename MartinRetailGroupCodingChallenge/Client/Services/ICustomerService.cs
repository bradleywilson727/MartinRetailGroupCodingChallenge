using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MartinRetailGroupCodingChallenge.Shared;
using System.Linq;

namespace MartinRetailGroupCodingChallenge.Client.Services
{
    public interface ICustomerService
    {
        event Action OnChange;

        List<Customer> Customers { get; set; }

        Task<List<Customer>> GetCustomers();

        Task<List<Customer>> CreateCustomer(Customer customer);
    }
}
