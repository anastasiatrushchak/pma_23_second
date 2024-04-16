using BookStore.Common.Dtos;
using BookStore.Dal.Models;

namespace BookStore.Bll.Interfaces;

public interface ICustomerRepository
{
    Task<Customer?> CreateCustomer(CustomerDto customerModel);
    
    Task<List<Customer?>> GetCustomers();
    
    Task<Customer?> GetCustomerById(int customerId);
    
    Task<Customer> UpdateCustomer(int customerId, CustomerDto customerModel);
    
    Task DeleteCustomer(int customerId);
}