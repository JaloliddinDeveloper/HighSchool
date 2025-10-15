using HighSchool.Models.Foundations.Students;
using HighSchool.Models.Foundations.Students.Exceptions;
using System;

namespace HighSchool.Services.Foundations
{
    public partial class StudentService
    {
        public void ValidateStudent(Student student)
        {
            if (student is null)
            {
                throw new NullStudentException("Student is null");
            }

            if (string.IsNullOrWhiteSpace(student.FullName))
                throw new ArgumentException("Student full name is required.");

            if (student.BirthDate > DateTimeOffset.Now)
                throw new ArgumentException("Birth date cannot be in the future.");
        }
    }
}
