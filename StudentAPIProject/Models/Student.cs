
namespace StudentAPIProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public Student(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
