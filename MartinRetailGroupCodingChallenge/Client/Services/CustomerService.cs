using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MartinRetailGroupCodingChallenge.Shared;

namespace MartinRetailGroupCodingChallenge.Client.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Customer> Customers { get; set; } = new List<Customer>();

        public event Action OnChange;


        public async Task<List<Customer>> GetCustomers()
        {
            Customers = await _httpClient.GetFromJsonAsync<List<Customer>>("api/customer");
            return Customers;
        }


        public async Task<List<Customer>> CreateCustomer(Customer customer)
        {
            var result = await _httpClient.PostAsJsonAsync<Customer>($"api/customer", customer);

            Customers = await result.Content.ReadFromJsonAsync<List<Customer>>();

            OnChange.Invoke();

            return Customers;
        }

    }
}
