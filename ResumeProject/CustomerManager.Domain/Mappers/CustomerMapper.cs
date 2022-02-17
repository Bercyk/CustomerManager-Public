using CustomerManager.Domain.DTOs;
using CustomerManager.Model;

namespace CustomerManager.Domain.Mappers
{
    public class CustomerMapper : ICustomerMapper
    {
        public Customer Map(CustomerDTO dto)
        {
            Customer customer = new Customer();
            customer.Id = dto.Id;
            customer.Name = dto.Name;
            customer.NIP = dto.NIP;
            customer.Type = MapCustomerType(dto.Type);
            customer.Description = dto.Description;
            customer.Status = dto.Status;

            return customer;
        }

        public CustomerType MapCustomerType(CustomerTypeDTO typeDTO)
        {
            CustomerType customerType = new CustomerType();
            customerType.Id = typeDTO.Id;
            customerType.Name = typeDTO.Name;

            return customerType;
        }

        public CustomerDTO Map(Customer customer)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.Id = customer.Id;
            customerDTO.Name = customer.Name;
            customerDTO.NIP = customer.NIP;
            customerDTO.Type = MapCustomerType(customer.Type);
            customerDTO.Description = customer.Description;
            customerDTO.Status = customer.Status;

            return customerDTO;
        }

        public CustomerTypeDTO MapCustomerType(CustomerType customerType)
        {
            CustomerTypeDTO customerTypeDTO = new CustomerTypeDTO();
            customerTypeDTO.Id = customerType.Id;
            customerTypeDTO.Name = customerType.Name;

            return customerTypeDTO;
        }
    }
}
