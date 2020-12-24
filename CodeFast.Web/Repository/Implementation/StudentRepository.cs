using CodeFast.Web.Models;
using CodeFast.Web.Repository.Interface;

namespace CodeFast.Web.Repository.Implementation
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(EfDbContext context) : base(context)
        {
        }
    }
}
