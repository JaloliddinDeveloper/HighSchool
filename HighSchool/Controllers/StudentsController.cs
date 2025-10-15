using HighSchool.Dtos.Students;
using HighSchool.Models.Foundations.Students;
using HighSchool.Models.Foundations.Students.Exceptions;
using HighSchool.Services.Foundations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HighSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<Student>> PostStudentAsync(StudentCreateDto studentDto)
        {
            try
            {
                var student = new Student
                {
                    Id = Guid.NewGuid(),
                    FullName = studentDto.FullName,
                    Email = studentDto.Email,
                    BirthDate = studentDto.BirthDate,
                    GPA = studentDto.GPA,
                    CreatedDate = DateTimeOffset.UtcNow,
                    UpdatedDate = DateTimeOffset.UtcNow
                };

                Student addedStudent = await this.studentService.AddStudentAsync(student);

                return Ok(addedStudent);
            }
            catch (NullStudentException nullStudentException)
            {
                return BadRequest(nullStudentException.Message);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }
    }
}
