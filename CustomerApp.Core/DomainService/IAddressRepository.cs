using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.DomainService
{
    public interface IAddressRepository
    {
        IEnumerable<Address> ReadAll();
        Address ReadyById(int id);

    }
}