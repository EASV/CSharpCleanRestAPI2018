using System;
using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.ApplicationService
{
    public interface ICustomerService
    {
        //New Customer
        Customer NewCustomer(string firstName,
                                string lastName,
                                string address);

        //Create
        Customer CreateCustomer(Customer cust);
        //Read
        Customer FindCustomerById(int id);
        List<Customer> GetAllCustomers();
        List<Customer> GetAllByFirstName(string name);
        //Update
        Customer UpdateCustomer(Customer customerUpdate);
        
        //Delete
        Customer DeleteCustomer(int id);
    }
}
