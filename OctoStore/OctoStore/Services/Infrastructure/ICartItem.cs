using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Services.Infrastructure
{
    public interface ICartItem
    {
        IEnumerable<CartItem> GetAll();

        CartItem GetById(int id);

        void Insert(CartItem crti);

        void Update(CartItem crti);

        void Delete(int id);

        int Count();

        void Save();
    }
}
