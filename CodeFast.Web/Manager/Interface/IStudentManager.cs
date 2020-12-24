using CodeFast.Web.Models;
using System.Linq;

namespace CodeFast.Web.Manager.Interface
{
    public interface IStudentManager
    {
        public IQueryable<Student> GetStudents();
        public Student Create(Student model);
        Student GetStudentById(int studentId);
        Student Update(Student model);
    }
}
