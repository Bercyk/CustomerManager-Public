using CustomerManager.Domain.DTOs;
using CustomerManager.Model;

namespace CustomerManager.Domain.Mappers
{
    public interface ICustomerMapper
    {
        public Customer Map(CustomerDTO dto);

        public CustomerType MapCustomerType(CustomerTypeDTO typeDTO);

        public CustomerDTO Map(Customer customer);

        public CustomerTypeDTO MapCustomerType(CustomerType customerType);

    }
}
