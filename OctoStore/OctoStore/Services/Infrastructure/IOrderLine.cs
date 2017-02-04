using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Services.Infrastructure
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetAll();

        OrderLine GetById(int id);

        void Insert(OrderLine ordl);

        void Update(OrderLine ordl);

        int Count();

        void Save();
    }
}
