using CustomerManager.Domain.DTOs;

namespace CustomerManager.Domain.Services
{
    public interface ICustomerService
    {
        CustomerDTO Get(int id);

        IList<CustomerDTO> GetAll();

        void Create(CustomerDTO customer);

        void Update(CustomerDTO customer);

        void Delete(int id);

        IList<CustomerTypeDTO> GetAllTypes();
    }
}
