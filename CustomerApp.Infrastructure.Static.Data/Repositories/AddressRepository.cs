using System.Collections.Generic;
using System.Linq;
using CustomerApp.Core.DomainService;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Static.Data.Repositories
{
    public class AddressRepository: IAddressRepository
    {
        public AddressRepository()
        {
            if (FakeDB.Addresses.Count >= 1) return;
            var address1 = new Address()
            {
                Id = FakeDB.AddressId ++,
                StreetName = "SonkuStreet",
                StreetNumber = "22A"
                
            };
            FakeDB.Addresses.Add(address1);

        }
        
        public IEnumerable<Address> ReadAll()
        {
            return FakeDB.Addresses;
        }

        public Address ReadyById(int id)
        {
            return FakeDB.Addresses.FirstOrDefault(addr => addr.Id == id);
        }
    }
}