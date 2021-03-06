using CustomerManager.Model;

namespace CustomerManager.DatabaseAccess.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(int id);

        IList<Customer> GetAll();

        void Create(Customer customer);

        void Update(Customer customer);

        void Delete(int id);
    }
}
