using CustomerManager.Model;

namespace CustomerManager.DatabaseAccess.Repositories
{
    public interface ICustomerTypeRepository
    {
        IList<CustomerType> GetAll();

        CustomerType Get(int id);
    }
}
