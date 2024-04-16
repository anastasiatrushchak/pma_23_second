using BookStore.Bll.Interfaces;
using BookStore.Common.Dtos;
using BookStore.Dal;
using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Bll.Implementations;

public class CustomerRepository : ICustomerRepository
{
    private BookstoreContext context;

    public CustomerRepository(BookstoreContext context)
    {
        this.context = context;
    }
    
    public  async Task<Customer?> CreateCustomer(CustomerDto customerModel)
    {
        Customer? customer = new Customer
        {
            FirstName = customerModel.FirstName,
            LastName = customerModel.LastName,
            Email = customerModel.Email,
            PhoneNumber = customerModel.PhoneNumber,
            Address = customerModel.Address,
        };
        await context.Customers.AddAsync(customer);
        return customer;
    }

    public async Task<List<Customer?>> GetCustomers()
    {
        return await context.Customers.ToListAsync();
    }

    public async Task<Customer?> GetCustomerById(int customerId)
    {
        return await context.Customers.FindAsync(customerId);
    }

    public async Task<Customer> UpdateCustomer(int customerId, CustomerDto customerModel)
    {
        var customer = await context.Customers.FindAsync(customerId);
        customer.FirstName = customerModel.FirstName;
        customer.LastName = customerModel.LastName;
        customer.Email = customerModel.Email;
        customer.PhoneNumber = customerModel.PhoneNumber;
        customer.Address = customerModel.Address;
        return customer;
    }

    public async Task DeleteCustomer(int customerId)
    {
        var customer = await GetCustomerById(customerId);
        context.Customers.Remove(customer);
    }
}