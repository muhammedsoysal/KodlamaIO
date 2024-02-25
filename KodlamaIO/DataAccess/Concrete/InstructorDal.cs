using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.DataAccess.Abstract;

namespace KodlamaIO.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> GetAll()
        {
            List<Instructor> instructors = new List<Instructor>();
            return instructors;
        }

        public void Add(Instructor entity)
        {
            Console.WriteLine("Veritabanına eğitmen eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Veritabanından eğitmen silindi");
        }

        public void Update(Instructor entity)
        {
            Console.WriteLine("Veritabanındaki eğitmen güncellendi");
        }
    }
}
