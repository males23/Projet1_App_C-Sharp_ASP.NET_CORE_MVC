namespace MvcSchool.Views.Home
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Course>? Courses { get; set; }

    }
}
