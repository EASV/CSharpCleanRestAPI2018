using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Static.Data
{
    public static class FakeDB
    {
        public static int Id = 1;
        public static readonly List<Customer> Customers = new List<Customer>();
        
        public static int AddressId = 1;
        public static readonly List<Address> Addresses = new List<Address>();

    }
}