using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;

namespace KodlamaIO.Business.Concrete
{
    public class CourseManager:ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Add(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }
    }
}
