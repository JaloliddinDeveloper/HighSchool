using HighSchool.Brokers.Storages;
using HighSchool.Models.Foundations.Students;
using System.Threading.Tasks;

namespace HighSchool.Services.Foundations
{
    public partial class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;

        public StudentService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Student> AddStudentAsync(Student student)
        {
            ValidateStudent(student);
            return await this.storageBroker.InsertStudentAsync(student);
        }
    }
}
