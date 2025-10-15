using System;
using System.ComponentModel.DataAnnotations;

namespace HighSchool.Dtos.Students
{
    public class StudentUpdateDto
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public DateTimeOffset BirthDate { get; set; }

        [Range(0.0, 4.0)]
        public double GPA { get; set; }
    }
}
