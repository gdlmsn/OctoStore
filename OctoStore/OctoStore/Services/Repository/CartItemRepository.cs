using OctoStore.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoStore.Models;
using OctoStore.DataContext;

namespace OctoStore.Services.Repository
{
    
    public class CartItemRepository : ICartItem
    {
        private readonly MyContext _db;

        public CartItemRepository(MyContext db)
        {
            _db = db;
        }

        public int Count()
        {
            return _db.CartItem.Count();
        }

        public void Delete(int id)
        {
            var cartItem = GetById(id);
            if (cartItem != null)
            {
                _db.CartItem.Remove(cartItem);
            }
        }

        public IEnumerable<CartItem> GetAll()
        {
            return _db.CartItem.Select(ci => ci);
        }

        public CartItem GetById(int id)
        {
            return _db.CartItem.FirstOrDefault(ci => ci.CartId == id);
        }

        public void Insert(CartItem crti)
        {
             _db.CartItem.Add(crti);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CartItem crti)
        {
            _db.CartItem.Update(crti);   
        }
    }
}
