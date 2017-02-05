using OctoStore.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoStore.Models;
using OctoStore.DataContext;

namespace OctoStore.Services.Repository
{
    public class OrderLineRepository : IOrderLine
    {
        private readonly MyContext _db;

        public OrderLineRepository(MyContext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.OrderLine.Count();
        }

        public IEnumerable<OrderLine> GetAll()
        {
            return _db.OrderLine.Select(ol => ol);
        }

        public OrderLine GetById(int id)
        {
            return _db.OrderLine.FirstOrDefault(ol => ol.OrderLineId == id);
        }

        public void Insert(OrderLine ordl)
        {
            _db.OrderLine.Add(ordl);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(OrderLine ordl)
        {
            _db.OrderLine.Update(ordl);
        }
    }
}
