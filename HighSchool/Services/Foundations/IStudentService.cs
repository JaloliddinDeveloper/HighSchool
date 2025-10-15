using HighSchool.Models.Foundations.Students;
using System.Threading.Tasks;

namespace HighSchool.Services.Foundations
{
    public interface IStudentService
    {
        ValueTask<Student> AddStudentAsync(Student student);
    }
}
