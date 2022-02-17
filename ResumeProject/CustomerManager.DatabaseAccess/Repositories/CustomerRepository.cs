using CustomerManager.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.DatabaseAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Create(Customer customer)
        {
            using (var context = new DbConfigContext())
            {
                var customerType = context.CustomerTypes.Find(customer.Type.Id);
                customer.Type = customerType;

                context.Customers.Add(customer);              
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new DbConfigContext())
            {
                context.Customers.Remove(new Customer { Id = id });
                context.SaveChanges();
                
            }
        }
        public IList<Customer> GetAll()
        {
            using (var context = new DbConfigContext())
            {
               var CustomersList = context.Customers.Include(x => x.Type);
               return CustomersList.ToList();
            }
        }
        public Customer Get(int id)
        {
            using(var context = new DbConfigContext())
            {
                return context.Customers.Include(x => x.Type).FirstOrDefault(x => x.Id == id);
            }
        }

        public void Update(Customer customer)
        {
            using (var context = new DbConfigContext())
            {
                Customer customerToUpdate = context.Customers.AsTracking().First(x => x.Id == customer.Id);

                customerToUpdate.Name = customer.Name;
                customerToUpdate.NIP = customer.NIP;

                var customerType = context.CustomerTypes.Find(customer.Type.Id);
                customer.Type = customerType;

                customerToUpdate.Description = customer.Description;
                customerToUpdate.Status = customer.Status;

                context.Update(customerToUpdate);

                context.SaveChanges();
            }
        }
    }
}
