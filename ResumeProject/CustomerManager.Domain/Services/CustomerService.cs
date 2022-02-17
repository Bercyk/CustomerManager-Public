using CustomerManager.DatabaseAccess.Repositories;
using CustomerManager.Domain.DTOs;
using CustomerManager.Domain.Mappers;

namespace CustomerManager.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        private readonly ICustomerMapper _customerMapper;

        private readonly ICustomerTypeRepository _customerTypeRepository;

        public CustomerService(ICustomerRepository customerRepository, ICustomerMapper customerMapper, ICustomerTypeRepository customerTypeRepository)
        {
            _customerRepository = customerRepository;
            _customerMapper = customerMapper;
            _customerTypeRepository = customerTypeRepository;
        }

        public void Create(CustomerDTO customer)
        {
            var newCustomer = _customerMapper.Map(customer);

            newCustomer.Type = _customerTypeRepository.Get(customer.Type.Id);

            _customerRepository.Create(newCustomer);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }

        public CustomerDTO Get(int id)
        {
            return _customerMapper.Map(_customerRepository.Get(id));
        }

        public IList<CustomerDTO> GetAll()
        {
            return _customerRepository.GetAll().Select(x=> _customerMapper.Map(x)).ToList();
        }

        public void Update(CustomerDTO customer)
        {
            _customerRepository.Update(_customerMapper.Map(customer));
        }

        public IList<CustomerTypeDTO> GetAllTypes()
        {
            return _customerTypeRepository.GetAll().Select(x => _customerMapper.MapCustomerType(x)).ToList();
        }
    }
}