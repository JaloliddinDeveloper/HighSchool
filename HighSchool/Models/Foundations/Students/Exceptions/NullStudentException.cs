using System;

namespace HighSchool.Models.Foundations.Students.Exceptions
{
    public class NullStudentException:Exception
    {
        public NullStudentException(string message)
            : base(message) { }
    }
}
