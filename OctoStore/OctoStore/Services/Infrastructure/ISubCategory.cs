using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Services.Infrastructure
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetAll();

        SubCategory GetById(int id);

        void Insert(SubCategory subc);

        void Update(SubCategory subc);

        void Delete(int id);

        int Count();

        void Save();
    }
}
