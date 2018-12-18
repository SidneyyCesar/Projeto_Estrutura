using Projeto.Application.Interfaces;
using Projeto.Domain.Interfaces;
using Projeto.Domain.Models;
using System.Collections.Generic;

namespace Projeto.Application.Services  
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _repository;
        
        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public Customer GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Customer> ListAll()
        {
            return _repository.ListAll();
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Save(Customer entity)
        {
            if(entity.id == 0)
                _repository.Insert(entity);
            else
                _repository.Update(entity);
        }
    }
}