using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Services.Infrastructure
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAll();

        Customer GetById(int id);

        void Insert(Customer cust);

        void Update(Category cust);

        void Delete(int id);

        void Save();
    }
}
