namespace KodlamaIO.Entities;
public class Course
{
    public Course(int id, int categoryId, int instructorId, string name, string description, Instructor instructor)
    {
        Id = id;
        CategoryId = categoryId;
        InstructorId = instructorId;
        Name = name;
        Description = description;
        Instructor = instructor;
    }

    public int  Id { get; set; }
    public int  CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Instructor Instructor{ get; set; }
}
