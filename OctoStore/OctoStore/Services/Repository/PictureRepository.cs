using OctoStore.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoStore.Models;
using OctoStore.DataContext;

namespace OctoStore.Services.Repository
{
    public class PictureRepository : IPicture
    {
        private readonly MyContext _db;

        public PictureRepository(MyContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {
            var picture = GetById(id);
            if (picture != null)
            {
                _db.Picture.Remove(picture);
            }
        }

        public Picture GetById(int id)
        {
            return _db.Picture.FirstOrDefault(p => p.PictureId == id);
        }

        public void Insert(Picture pic)
        {
            _db.Picture.Add(pic);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Picture pic)
        {
            _db.Picture.Update(pic);
        }
    }
}
