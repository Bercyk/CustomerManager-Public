using Autofac;
using CustomerManager.DatabaseAccess;
using CustomerManager.DatabaseAccess.Repositories;
using CustomerManager.Domain.Mappers;
using CustomerManager.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager
{

    internal static class Program
    {

        public static IContainer container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            using (var context = new DbConfigContext())
            {
                context.Database.Migrate();
            }

            ApplicationConfiguration.Initialize();

            container = Configure();

            CustomerListForm customerListForm = new CustomerListForm(container.Resolve<ICustomerService>());

            Application.Run(customerListForm);

        }
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();

            builder.RegisterType<CustomerService>().As<ICustomerService>();

            builder.RegisterType<CustomerMapper>().As<ICustomerMapper>();

            builder.RegisterType<CustomerTypeRepository>().As<ICustomerTypeRepository>();

            builder.RegisterType<CustomerListForm>();

            builder.RegisterType<AddEditCustomerForm>();

            return builder.Build();
        }
    }
}