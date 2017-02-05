using OctoStore.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoStore.Models;
using OctoStore.DataContext;

namespace OctoStore.Services.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly MyContext _db;

        public ProductRepository(MyContext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.Product.Count();
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _db.Product.Remove(product);

            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Product.Select(pro => pro);
        }

        public Product GetById(int id)
        {
            return _db.Product.FirstOrDefault(pro => pro.ProductId == id);
        }

        public void Insert(Product prd)
        {
            _db.Product.Add(prd);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product prd)
        {
            _db.Product.Update(prd);
        }
    }
}
