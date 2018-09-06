using CustomerApp.Core.Entity;

namespace CustomerApp.Core.ApplicationService
{
    public interface IAddressService
    {
        Address FindAddressById(int id);

    }
}