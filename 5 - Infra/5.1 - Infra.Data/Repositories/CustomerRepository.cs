using Projeto.Domain.Interfaces;
using Projeto.Domain.Models;
using Projeto.Infra.Configuration;

namespace Projeto.Infra.Repositories
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(Context context) : base(context) { }
    }
}