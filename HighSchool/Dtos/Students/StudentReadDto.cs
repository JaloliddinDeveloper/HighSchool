using System;
using System.ComponentModel.DataAnnotations;

namespace HighSchool.Dtos.Students
{
    public class StudentReadDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public double GPA { get; set; }
    }
}
