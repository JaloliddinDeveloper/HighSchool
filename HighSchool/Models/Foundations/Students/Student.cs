using System;

namespace HighSchool.Models.Foundations.Students
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }   
        public double GPA { get; set; } 
        public DateTimeOffset CreatedDate { get; set; } 
        public DateTimeOffset UpdatedDate { get; set; } 
    }
}
