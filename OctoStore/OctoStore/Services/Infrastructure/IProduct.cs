using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Services.Infrastructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Insert(Product prd);

        void Update(Product prd);

        void Delete(int id);

        int Count();

        void Save();
    }
}
