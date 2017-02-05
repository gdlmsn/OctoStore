using OctoStore.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoStore.Models;
using OctoStore.DataContext;

namespace OctoStore.Services.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly MyContext _db;

        public SubCategoryRepository(MyContext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.SubCategory.Count();
        }

        public void Delete(int id)
        {
            var subcategory = GetById(id);
            if (subcategory != null)
            {
                _db.SubCategory.Remove(subcategory);
            }
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return _db.SubCategory.Select(sbc => sbc);
        }

        public SubCategory GetById(int id)
        {
            return _db.SubCategory.FirstOrDefault(sbc => sbc.SubCategoryId == id);
        }

        public void Insert(SubCategory subc)
        {
            _db.SubCategory.Add(subc);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(SubCategory subc)
        {
            _db.SubCategory.Update(subc);
        }
    }
}
