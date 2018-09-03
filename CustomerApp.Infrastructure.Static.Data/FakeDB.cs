using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Static.Data
{
    public static class FakeDB
    {
        public static int id = 1;
        public static readonly List<Customer> Customers = new List<Customer>();
        
    }
}