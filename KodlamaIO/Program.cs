using KodlamaIO.Business.Concrete;
using KodlamaIO.Bussiness.Concrete;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.DataAccess.Concrete;
using KodlamaIO.Entities;

Category category = new Category
{
    ID = 1,
    Name = "Software",
    Description = "C#"
};

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.GetAll();
categoryManager.Delete(1);
categoryManager.Delete(2);
categoryManager.Add(category);
categoryManager.Update(category);

Instructor instructor = new Instructor
{
    Id = 1,
    FirstName = "Engin",
    LastName = "Demiroğ",
    DateOfBirth = DateTime.Today,
    Desription = "Desc",
    ImageUrl = "img/enginhoca.png"
};

InstructorManager instructorManager=new  InstructorManager(new InstructorDal());
instructorManager.GetAll();
instructorManager.Delete(3);
instructorManager.Add(instructor);
instructorManager.Update(instructor);


Course course = new Course(1, 1, 1, "C#", "Desc", new Instructor());

CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.GetAll();
courseManager.Delete(1);
courseManager.Add(course);
courseManager.Update(course);


