namespace MvcStudentDemo.Models
{
    public class Student
    {
        public int Id { get; set; }        // Primary key
        public string Name { get; set; } = string.Empty; // Required
        public int Age { get; set; }       // Optional
    }
}
