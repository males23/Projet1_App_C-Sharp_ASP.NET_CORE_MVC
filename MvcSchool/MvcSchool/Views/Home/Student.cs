namespace MvcSchool.Views.Home
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
