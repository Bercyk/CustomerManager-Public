using CustomerManager.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.DatabaseAccess.Repositories
{
    public class CustomerTypeRepository : ICustomerTypeRepository
    {
        public IList<CustomerType> GetAll()
        {
            using (var context = new DbConfigContext())
            {
                return context.CustomerTypes.ToList();
            }
        }
        public CustomerType Get(int id)
        {
            using (var context = new DbConfigContext())
            {
                return context.CustomerTypes.AsTracking().First(x => x.Id == id);
            }
        }
    }
}
