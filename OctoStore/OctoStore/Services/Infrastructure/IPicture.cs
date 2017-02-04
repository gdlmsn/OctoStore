using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Services.Infrastructure
{
    public interface IPicture
    {
        Picture GetById(int id);

        void Insert(Picture pic);

        void Update(Picture pic);

        void Delete(int id);

        void Save();
    }
}
