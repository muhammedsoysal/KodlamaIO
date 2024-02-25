using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;

namespace KodlamaIO.Business.Concrete
{
    public class InstructorManager: IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Add(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void Update(Instructor entity)
        {
            _instructorDal.Update(entity);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }
    }
}
