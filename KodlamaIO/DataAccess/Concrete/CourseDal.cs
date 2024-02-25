using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;

namespace KodlamaIO.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine("Veritabanına kurs eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Veritabanından kurs silindi");
        }

        public List<Course> GetAll()
        {
            List<Course> courses = new List<Course>();
            foreach (var course in courses)
            {
                Console.WriteLine("Kurs ID: {0}\nKurs Adi: {1}\nAciklama: {2}\nKategori ID: {3}\nEgitmen ID: {4}\n",
                    course.Id, course.Name, course.Description, course.CategoryId, course.InstructorId);
            }

            Console.WriteLine("Kurslar Listelendi");
            return courses;
            
        }

        public void Update(Course course)
        {
            Console.WriteLine("Veritabanındaki kurs güncellendi");
        }
    }
}
