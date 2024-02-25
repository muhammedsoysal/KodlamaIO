using KodlamaIO.Business.Abstract;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;

namespace KodlamaIO.Bussiness.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Update(Category entity)
        {
        _categoryDal.Update(entity);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }
    }
}
