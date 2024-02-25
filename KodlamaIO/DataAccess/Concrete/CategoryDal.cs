using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;

namespace KodlamaIO.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine("Veritabanına kategori eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Veritabanından kategori silindi");
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            return categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Veritabanındaki kategori güncellendi");
        }
    }
}
